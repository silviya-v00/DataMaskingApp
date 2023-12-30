
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataMaskForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkLblExit = new System.Windows.Forms.LinkLabel();
            this.linkLblNewImport = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.linkLblExit);
            this.splitContainer1.Panel1.Controls.Add(this.linkLblNewImport);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
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
            // linkLblExit
            // 
            this.linkLblExit.AutoSize = true;
            this.linkLblExit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLblExit.LinkColor = System.Drawing.Color.Indigo;
            this.linkLblExit.Location = new System.Drawing.Point(29, 574);
            this.linkLblExit.Name = "linkLblExit";
            this.linkLblExit.Size = new System.Drawing.Size(31, 17);
            this.linkLblExit.TabIndex = 15;
            this.linkLblExit.TabStop = true;
            this.linkLblExit.Text = "Exit";
            this.linkLblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblExit_LinkClicked);
            // 
            // linkLblNewImport
            // 
            this.linkLblNewImport.AutoSize = true;
            this.linkLblNewImport.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLblNewImport.LinkColor = System.Drawing.Color.Indigo;
            this.linkLblNewImport.Location = new System.Drawing.Point(231, 574);
            this.linkLblNewImport.Name = "linkLblNewImport";
            this.linkLblNewImport.Size = new System.Drawing.Size(86, 17);
            this.linkLblNewImport.TabIndex = 14;
            this.linkLblNewImport.TabStop = true;
            this.linkLblNewImport.Text = "New Import";
            this.linkLblNewImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblNewImport_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 97);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Lavender;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.Color.Indigo;
            this.btnExport.Location = new System.Drawing.Point(192, 515);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 29);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnMaskData
            // 
            this.btnMaskData.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMaskData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaskData.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnMaskData.Location = new System.Drawing.Point(29, 515);
            this.btnMaskData.Name = "btnMaskData";
            this.btnMaskData.Size = new System.Drawing.Size(125, 29);
            this.btnMaskData.TabIndex = 11;
            this.btnMaskData.Text = "Mask Data";
            this.btnMaskData.UseVisualStyleBackColor = false;
            this.btnMaskData.Click += new System.EventHandler(this.btnMaskData_Click);
            // 
            // lblMaskingMethod
            // 
            this.lblMaskingMethod.AutoSize = true;
            this.lblMaskingMethod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaskingMethod.Location = new System.Drawing.Point(29, 245);
            this.lblMaskingMethod.Name = "lblMaskingMethod";
            this.lblMaskingMethod.Size = new System.Drawing.Size(185, 18);
            this.lblMaskingMethod.TabIndex = 10;
            this.lblMaskingMethod.Text = "Select masking method:";
            // 
            // lblSubstitutionLength
            // 
            this.lblSubstitutionLength.AutoSize = true;
            this.lblSubstitutionLength.Enabled = false;
            this.lblSubstitutionLength.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubstitutionLength.Location = new System.Drawing.Point(29, 410);
            this.lblSubstitutionLength.Name = "lblSubstitutionLength";
            this.lblSubstitutionLength.Size = new System.Drawing.Size(142, 18);
            this.lblSubstitutionLength.TabIndex = 9;
            this.lblSubstitutionLength.Text = "Substitution Length";
            // 
            // lblSubstitutionSymbol
            // 
            this.lblSubstitutionSymbol.AutoSize = true;
            this.lblSubstitutionSymbol.Enabled = false;
            this.lblSubstitutionSymbol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubstitutionSymbol.Location = new System.Drawing.Point(29, 346);
            this.lblSubstitutionSymbol.Name = "lblSubstitutionSymbol";
            this.lblSubstitutionSymbol.Size = new System.Drawing.Size(148, 18);
            this.lblSubstitutionSymbol.TabIndex = 8;
            this.lblSubstitutionSymbol.Text = "Substitution Symbol";
            // 
            // textBoxSubstitutionLength
            // 
            this.textBoxSubstitutionLength.Enabled = false;
            this.textBoxSubstitutionLength.Location = new System.Drawing.Point(29, 433);
            this.textBoxSubstitutionLength.Name = "textBoxSubstitutionLength";
            this.textBoxSubstitutionLength.Size = new System.Drawing.Size(140, 26);
            this.textBoxSubstitutionLength.TabIndex = 7;
            this.textBoxSubstitutionLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSubstitutionLength_KeyPress);
            // 
            // textBoxSubstitutionSymbol
            // 
            this.textBoxSubstitutionSymbol.Enabled = false;
            this.textBoxSubstitutionSymbol.Location = new System.Drawing.Point(29, 369);
            this.textBoxSubstitutionSymbol.MaxLength = 1;
            this.textBoxSubstitutionSymbol.Name = "textBoxSubstitutionSymbol";
            this.textBoxSubstitutionSymbol.Size = new System.Drawing.Size(140, 26);
            this.textBoxSubstitutionSymbol.TabIndex = 6;
            // 
            // chkSubstitutionMasking
            // 
            this.chkSubstitutionMasking.AutoSize = true;
            this.chkSubstitutionMasking.Location = new System.Drawing.Point(29, 298);
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
            this.chkShufflingMasking.Location = new System.Drawing.Point(29, 268);
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
            this.lblCSVColumns.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCSVColumns.Location = new System.Drawing.Point(29, 24);
            this.lblCSVColumns.Name = "lblCSVColumns";
            this.lblCSVColumns.Size = new System.Drawing.Size(220, 18);
            this.lblCSVColumns.TabIndex = 3;
            this.lblCSVColumns.Text = "Select CSV columns to mask:";
            // 
            // chkListBoxCSVColumnTitles
            // 
            this.chkListBoxCSVColumnTitles.FormattingEnabled = true;
            this.chkListBoxCSVColumnTitles.Location = new System.Drawing.Point(29, 47);
            this.chkListBoxCSVColumnTitles.Name = "chkListBoxCSVColumnTitles";
            this.chkListBoxCSVColumnTitles.Size = new System.Drawing.Size(288, 172);
            this.chkListBoxCSVColumnTitles.TabIndex = 2;
            // 
            // DataMaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1301, 619);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataMaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Masking";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLblNewImport;
        private System.Windows.Forms.LinkLabel linkLblExit;
    }
}