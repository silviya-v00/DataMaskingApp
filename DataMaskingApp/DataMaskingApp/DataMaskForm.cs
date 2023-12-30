using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMaskingApp
{
    public partial class DataMaskForm : Form
    {
        private DataTable OriginalDataTable;
        private DataTable MaskedDataTable;
        private string delimiter;
        private const int defaultCellValueLength = 4;

        public DataMaskForm(string filePath)
        {
            InitializeComponent();
            delimiter = DetectCSVDelimiter(filePath);
            PopulateCSVColumns(filePath);
        }

        private string DetectCSVDelimiter(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] possibleDelimiters = new string[] { ",", "\t", ";" };

                        var delimiterCount = possibleDelimiters.ToDictionary(delimiter => delimiter, delimiter => line.Split(new[] { delimiter }, StringSplitOptions.None).Length);

                        var maxDelimiter = delimiterCount.OrderByDescending(x => x.Value).FirstOrDefault();

                        if (maxDelimiter.Value > 1)
                        {
                            return maxDelimiter.Key;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error detecting the delimiter: {ex.Message}");
            }

            return null;
        }

        private void PopulateCSVColumns(string filePath)
        {
            var columnTitles = GetCSVColumnTitles(filePath);

            chkListBoxCSVColumnTitles.Items.Clear();
            foreach (var title in columnTitles)
            {
                chkListBoxCSVColumnTitles.Items.Add(title);
            }

            HandleUploadedCSVFile(filePath);
        }

        private List<string> GetCSVColumnTitles(string filePath)
        {
            List<string> columnTitles = new List<string>();

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    if (!string.IsNullOrEmpty(delimiter))
                    {
                        string headerLine = reader.ReadLine();
                        if (!string.IsNullOrEmpty(headerLine))
                        {
                            string[] columns = headerLine.Split(new string[] { delimiter }, StringSplitOptions.None);
                            columnTitles.AddRange(columns);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unable to detect the delimiter used in the CSV file.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading CSV file: {ex.Message}");
            }

            return columnTitles;
        }

        private void HandleUploadedCSVFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(delimiter))
                {
                    MessageBox.Show("Unable to detect the delimiter used in the CSV file.");
                    return;
                }

                OriginalDataTable = ParseCSVFile(filePath);

                if (OriginalDataTable != null && OriginalDataTable.Rows.Count > 0)
                {
                    DisplayCSVData(OriginalDataTable);
                    MaskedDataTable = OriginalDataTable.Copy();
                }
                else
                {
                    MessageBox.Show("No data found in the CSV file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading or displaying CSV data: {ex.Message}");
            }
        }

        private DataTable ParseCSVFile(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = delimiter,
                    HasHeaderRecord = true,
                    Quote = '"',
                    IgnoreBlankLines = true,
                }))
                {
                    DataTable dt = new DataTable();

                    csv.Read();
                    csv.ReadHeader();

                    foreach (var header in csv.HeaderRecord)
                    {
                        dt.Columns.Add(header);
                    }

                    while (csv.Read())
                    {
                        DataRow row = dt.NewRow();
                        foreach (DataColumn column in dt.Columns)
                        {
                            row[column.ColumnName] = csv.GetField(column.DataType, column.ColumnName);
                        }
                        dt.Rows.Add(row);
                    }

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing CSV file: {ex.Message}");
                return null;
            }
        }

        private void chkShufflingMasking_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShufflingMasking.Checked)
            {
                chkSubstitutionMasking.Checked = false;
                EnableDisableSubstitutionTools(false);
            }
            else
            {
                chkSubstitutionMasking.Checked = true;
                EnableDisableSubstitutionTools(true);
            }
        }

        private void chkSubstitutionMasking_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubstitutionMasking.Checked)
            {
                chkShufflingMasking.Checked = false;
                EnableDisableSubstitutionTools(true);
            }
            else
            {
                chkShufflingMasking.Checked = true;
                EnableDisableSubstitutionTools(false);
            }
        }

        private void EnableDisableSubstitutionTools(bool enabled)
        {
            lblSubstitutionSymbol.Enabled = enabled;
            textBoxSubstitutionSymbol.Enabled = enabled;
            lblSubstitutionLength.Enabled = enabled;
            textBoxSubstitutionLength.Enabled = enabled;
        }

        private void textBoxSubstitutionLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnMaskData_Click(object sender, EventArgs e)
        {
            if (MaskedDataTable == null || MaskedDataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data loaded to mask.");
                return;
            }

            List<int> selectedIndices = chkListBoxCSVColumnTitles.CheckedIndices.Cast<int>().ToList();

            if (chkShufflingMasking.Checked)
            {
                ShuffleData(selectedIndices);
            }

            if (chkSubstitutionMasking.Checked)
            {
                SubstituteData(selectedIndices);
            }

            DisplayCSVData(MaskedDataTable);
        }
                
        private void ShuffleData(List<int> selectedIndices)
        {
            Random random = new Random();

            foreach (int columnIndex in selectedIndices)
            {
                List<string> columnValues = MaskedDataTable.AsEnumerable()
                    .Select(row => row.Field<string>(columnIndex))
                    .ToList();

                columnValues = columnValues.OrderBy(x => random.Next()).ToList();

                for (int i = 0; i < MaskedDataTable.Rows.Count; i++)
                {
                    MaskedDataTable.Rows[i][columnIndex] = columnValues[i];
                }
            }
        }

        private void SubstituteData(List<int> selectedIndices)
        {
            if (textBoxSubstitutionSymbol.Enabled && String.IsNullOrEmpty(textBoxSubstitutionSymbol.Text.Trim()))
            {
                MessageBox.Show("Substitution Symbol cannot be empty.");
                return;
            }

            string substitutionSymbol = textBoxSubstitutionSymbol.Text;

            int substitutionLength = 0;
            int.TryParse(textBoxSubstitutionLength.Text, out substitutionLength);

            foreach (int columnIndex in selectedIndices)
            {
                foreach (DataRow row in MaskedDataTable.Rows)
                {
                    string substitutedValue = "";
                    string cellValue = row[columnIndex].ToString();

                    if (substitutionLength == 0)
                    {
                        substitutedValue = new string(substitutionSymbol[0], defaultCellValueLength);
                    }
                    else
                    {
                        int length = Math.Min(cellValue.Length, substitutionLength);
                        substitutedValue = new string(substitutionSymbol[0], length) + cellValue.Substring(length);
                    }

                    row[columnIndex] = substitutedValue;
                }
            }
        }

        private void DisplayCSVData(DataTable dataTable)
        {
            splitContainer1.Panel2.Controls.Clear();

            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            splitContainer1.Panel2.Controls.Add(dataGridView);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaskedDataTable == null || MaskedDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export.");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        for (int i = 0; i < MaskedDataTable.Columns.Count; i++)
                        {
                            writer.Write(MaskedDataTable.Columns[i].ColumnName);
                            if (i < MaskedDataTable.Columns.Count - 1)
                            {
                                writer.Write("\t");
                            }
                        }
                        writer.WriteLine();

                        foreach (DataRow row in MaskedDataTable.Rows)
                        {
                            for (int i = 0; i < MaskedDataTable.Columns.Count; i++)
                            {
                                writer.Write(row[i].ToString());
                                if (i < MaskedDataTable.Columns.Count - 1)
                                {
                                    writer.Write("\t");
                                }
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show($"Data exported successfully to {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}");
            }
        }

        private void linkLblNewImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void linkLblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
