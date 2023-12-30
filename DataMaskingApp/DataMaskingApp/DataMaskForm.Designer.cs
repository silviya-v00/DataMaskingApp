
namespace DataMaskingApp
{
    partial class DataMaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnMaskData = new System.Windows.Forms.Button();
            this.lblMaskingMethod = new System.Windows.Forms.Label();
            this.lblSubstitutionLength = new System.Windows.Forms.Label();
            this.lblSubstitutionSymbol = new System.Windows.Forms.Label();
            this.textBoxSubstitutionLength = new System.Windows.Forms.TextBox();
            this.textBoxSubstitutionSymbol = new System.Windows.Forms.TextBox();
            this.chkSubstitutionMasking = new System.Windows.Forms.CheckBox();
            this.chkShufflingMasking = new System.Windows.Forms.CheckBox();
            this.lblCSVColumns = new System.Windows.Forms.Label();
            this.chkListBoxCSVColumnTitles = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnExport);
            this.splitContainer1.Panel1.Controls.Add(this.btnMaskData);
            this.splitContainer1.Panel1.Controls.Add(this.lblMaskingMethod);
            this.splitContainer1.Panel1.Controls.Add(this.lblSubstitutionLength);
            this.splitContainer1.Panel1.Controls.Add(this.lblSubstitutionSymbol);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSubstitutionLength);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSubstitutionSymbol);
            this.splitContainer1.Panel1.Controls.Add(this.chkSubstitutionMasking);
            this.splitContainer1.Panel1.Controls.Add(this.chkShufflingMasking);
            this.splitContainer1.Panel1.Controls.Add(this.lblCSVColumns);
            this.splitContainer1.Panel1.Controls.Add(this.chkListBoxCSVColumnTitles);
            this.splitContainer1.Panel1MinSize = 300;
            this.splitContainer1.Panel2MinSize = 950;
            this.splitContainer1.Size = new System.Drawing.Size(1301, 619);
            this.splitContainer1.SplitterDistance = 347;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(190, 507);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 29);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnMaskData
            // 
            this.btnMaskData.Location = new System.Drawing.Point(27, 507);
            this.btnMaskData.Name = "btnMaskData";
            this.btnMaskData.Size = new System.Drawing.Size(125, 29);
            this.btnMaskData.TabIndex = 11;
            this.btnMaskData.Text = "Mask Data";
            this.btnMaskData.UseVisualStyleBackColor = true;
            this.btnMaskData.Click += new System.EventHandler(this.btnMaskData_Click);
            // 
            // lblMaskingMethod
            // 
            this.lblMaskingMethod.AutoSize = true;
            this.lblMaskingMethod.Location = new System.Drawing.Point(27, 247);
            this.lblMaskingMethod.Name = "lblMaskingMethod";
            this.lblMaskingMethod.Size = new System.Drawing.Size(182, 20);
            this.lblMaskingMethod.TabIndex = 10;
            this.lblMaskingMethod.Text = "Select masking method:";
            // 
            // lblSubstitutionLength
            // 
            this.lblSubstitutionLength.AutoSize = true;
            this.lblSubstitutionLength.Enabled = false;
            this.lblSubstitutionLength.Location = new System.Drawing.Point(27, 404);
            this.lblSubstitutionLength.Name = "lblSubstitutionLength";
            this.lblSubstitutionLength.Size = new System.Drawing.Size(144, 20);
            this.lblSubstitutionLength.TabIndex = 9;
            this.lblSubstitutionLength.Text = "Substitution Length";
            // 
            // lblSubstitutionSymbol
            // 
            this.lblSubstitutionSymbol.AutoSize = true;
            this.lblSubstitutionSymbol.Enabled = false;
            this.lblSubstitutionSymbol.Location = new System.Drawing.Point(27, 340);
            this.lblSubstitutionSymbol.Name = "lblSubstitutionSymbol";
            this.lblSubstitutionSymbol.Size = new System.Drawing.Size(145, 20);
            this.lblSubstitutionSymbol.TabIndex = 8;
            this.lblSubstitutionSymbol.Text = "Substitution Symbol";
            // 
            // textBoxSubstitutionLength
            // 
            this.textBoxSubstitutionLength.Enabled = false;
            this.textBoxSubstitutionLength.Location = new System.Drawing.Point(27, 427);
            this.textBoxSubstitutionLength.Name = "textBoxSubstitutionLength";
            this.textBoxSubstitutionLength.Size = new System.Drawing.Size(140, 26);
            this.textBoxSubstitutionLength.TabIndex = 7;
            this.textBoxSubstitutionLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSubstitutionLength_KeyPress);
            // 
            // textBoxSubstitutionSymbol
            // 
            this.textBoxSubstitutionSymbol.Enabled = false;
            this.textBoxSubstitutionSymbol.Location = new System.Drawing.Point(27, 363);
            this.textBoxSubstitutionSymbol.MaxLength = 1;
            this.textBoxSubstitutionSymbol.Name = "textBoxSubstitutionSymbol";
            this.textBoxSubstitutionSymbol.Size = new System.Drawing.Size(140, 26);
            this.textBoxSubstitutionSymbol.TabIndex = 6;
            // 
            // chkSubstitutionMasking
            // 
            this.chkSubstitutionMasking.AutoSize = true;
            this.chkSubstitutionMasking.Location = new System.Drawing.Point(27, 300);
            this.chkSubstitutionMasking.Name = "chkSubstitutionMasking";
            this.chkSubstitutionMasking.Size = new System.Drawing.Size(177, 24);
            this.chkSubstitutionMasking.TabIndex = 5;
            this.chkSubstitutionMasking.Text = "Substitution Masking";
            this.chkSubstitutionMasking.UseVisualStyleBackColor = true;
            this.chkSubstitutionMasking.CheckedChanged += new System.EventHandler(this.chkSubstitutionMasking_CheckedChanged);
            // 
            // chkShufflingMasking
            // 
            this.chkShufflingMasking.AutoSize = true;
            this.chkShufflingMasking.Checked = true;
            this.chkShufflingMasking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShufflingMasking.Location = new System.Drawing.Point(27, 270);
            this.chkShufflingMasking.Name = "chkShufflingMasking";
            this.chkShufflingMasking.Size = new System.Drawing.Size(156, 24);
            this.chkShufflingMasking.TabIndex = 4;
            this.chkShufflingMasking.Text = "Shuffling Masking";
            this.chkShufflingMasking.UseVisualStyleBackColor = true;
            this.chkShufflingMasking.CheckedChanged += new System.EventHandler(this.chkShufflingMasking_CheckedChanged);
            // 
            // lblCSVColumns
            // 
            this.lblCSVColumns.AutoSize = true;
            this.lblCSVColumns.Location = new System.Drawing.Point(27, 34);
            this.lblCSVColumns.Name = "lblCSVColumns";
            this.lblCSVColumns.Size = new System.Drawing.Size(216, 20);
            this.lblCSVColumns.TabIndex = 3;
            this.lblCSVColumns.Text = "Select CSV columns to mask:";
            // 
            // chkListBoxCSVColumnTitles
            // 
            this.chkListBoxCSVColumnTitles.FormattingEnabled = true;
            this.chkListBoxCSVColumnTitles.Location = new System.Drawing.Point(27, 57);
            this.chkListBoxCSVColumnTitles.Name = "chkListBoxCSVColumnTitles";
            this.chkListBoxCSVColumnTitles.Size = new System.Drawing.Size(288, 172);
            this.chkListBoxCSVColumnTitles.TabIndex = 2;
            // 
            // DataMaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 619);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DataMaskForm";
            this.Text = "Data Masking";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox chkListBoxCSVColumnTitles;
        private System.Windows.Forms.Label lblCSVColumns;
        private System.Windows.Forms.Label lblMaskingMethod;
        private System.Windows.Forms.Label lblSubstitutionLength;
        private System.Windows.Forms.Label lblSubstitutionSymbol;
        private System.Windows.Forms.TextBox textBoxSubstitutionLength;
        private System.Windows.Forms.TextBox textBoxSubstitutionSymbol;
        private System.Windows.Forms.CheckBox chkSubstitutionMasking;
        private System.Windows.Forms.CheckBox chkShufflingMasking;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnMaskData;
    }
}