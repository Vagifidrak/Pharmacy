namespace Pharmacy
{
    partial class AddMedicine
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
            this.lblMedName = new System.Windows.Forms.Label();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCounts = new System.Windows.Forms.Label();
            this.numCCounts = new System.Windows.Forms.NumericUpDown();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.dtpProDate = new System.Windows.Forms.DateTimePicker();
            this.lblProDate = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.dtgMedicine = new System.Windows.Forms.DataGridView();
            this.grpTagGroup = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCCounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedName
            // 
            this.lblMedName.AutoSize = true;
            this.lblMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMedName.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblMedName.Location = new System.Drawing.Point(31, 89);
            this.lblMedName.Name = "lblMedName";
            this.lblMedName.Size = new System.Drawing.Size(183, 29);
            this.lblMedName.TabIndex = 4;
            this.lblMedName.Text = "Medicine Name";
            // 
            // txtMedName
            // 
            this.txtMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMedName.Location = new System.Drawing.Point(36, 136);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(256, 35);
            this.txtMedName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrice.Location = new System.Drawing.Point(36, 242);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(256, 35);
            this.txtPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblPrice.Location = new System.Drawing.Point(31, 195);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 29);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 69);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pharmacy";
            // 
            // lblCounts
            // 
            this.lblCounts.AutoSize = true;
            this.lblCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCounts.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblCounts.Location = new System.Drawing.Point(31, 300);
            this.lblCounts.Name = "lblCounts";
            this.lblCounts.Size = new System.Drawing.Size(88, 29);
            this.lblCounts.TabIndex = 9;
            this.lblCounts.Text = "Counts";
            // 
            // numCCounts
            // 
            this.numCCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numCCounts.Location = new System.Drawing.Point(36, 346);
            this.numCCounts.Name = "numCCounts";
            this.numCCounts.Size = new System.Drawing.Size(256, 35);
            this.numCCounts.TabIndex = 10;
            this.numCCounts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(36, 431);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(256, 96);
            this.rtbDescription.TabIndex = 11;
            this.rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblDescription.Location = new System.Drawing.Point(31, 399);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 29);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // btnAddMed
            // 
            this.btnAddMed.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddMed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddMed.Location = new System.Drawing.Point(60, 541);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(197, 61);
            this.btnAddMed.TabIndex = 13;
            this.btnAddMed.Text = "Add Medicine";
            this.btnAddMed.UseVisualStyleBackColor = false;
            // 
            // dtpProDate
            // 
            this.dtpProDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpProDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpProDate.Location = new System.Drawing.Point(394, 251);
            this.dtpProDate.Name = "dtpProDate";
            this.dtpProDate.Size = new System.Drawing.Size(301, 26);
            this.dtpProDate.TabIndex = 15;
            // 
            // lblProDate
            // 
            this.lblProDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProDate.AutoSize = true;
            this.lblProDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProDate.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblProDate.Location = new System.Drawing.Point(389, 199);
            this.lblProDate.Name = "lblProDate";
            this.lblProDate.Size = new System.Drawing.Size(185, 29);
            this.lblProDate.TabIndex = 16;
            this.lblProDate.Text = "Production Date";
            // 
            // lblExpDate
            // 
            this.lblExpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExpDate.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblExpDate.Location = new System.Drawing.Point(389, 303);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(152, 29);
            this.lblExpDate.TabIndex = 18;
            this.lblExpDate.Text = "Expired Date";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpExpDate.Location = new System.Drawing.Point(394, 355);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(301, 26);
            this.dtpExpDate.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(389, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Firms";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(680, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tags";
            // 
            // cmbFirms
            // 
            this.cmbFirms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFirms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(394, 134);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(240, 37);
            this.cmbFirms.TabIndex = 21;
            // 
            // cmbTags
            // 
            this.cmbTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(669, 134);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(240, 37);
            this.cmbTags.TabIndex = 23;
            this.cmbTags.SelectedIndexChanged += new System.EventHandler(this.cmbTags_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.White;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(388, 447);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(268, 32);
            this.lblError.TabIndex = 24;
            this.lblError.Text = "Error cixacaq burda ";
            this.lblError.Visible = false;
            // 
            // dtgMedicine
            // 
            this.dtgMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicine.Location = new System.Drawing.Point(12, 568);
            this.dtgMedicine.Name = "dtgMedicine";
            this.dtgMedicine.RowHeadersWidth = 62;
            this.dtgMedicine.RowTemplate.Height = 28;
            this.dtgMedicine.Size = new System.Drawing.Size(964, 235);
            this.dtgMedicine.TabIndex = 25;
            // 
            // grpTagGroup
            // 
            this.grpTagGroup.Location = new System.Drawing.Point(701, 199);
            this.grpTagGroup.Name = "grpTagGroup";
            this.grpTagGroup.Size = new System.Drawing.Size(438, 336);
            this.grpTagGroup.TabIndex = 26;
            this.grpTagGroup.TabStop = false;
            this.grpTagGroup.Text = "Tag Group";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnExit.Location = new System.Drawing.Point(923, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 59);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(988, 808);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpTagGroup);
            this.Controls.Add(this.dtgMedicine);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.cmbFirms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.lblProDate);
            this.Controls.Add(this.dtpProDate);
            this.Controls.Add(this.btnAddMed);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.numCCounts);
            this.Controls.Add(this.lblCounts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtMedName);
            this.Controls.Add(this.lblMedName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCCounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedName;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCounts;
        private System.Windows.Forms.NumericUpDown numCCounts;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.DateTimePicker dtpProDate;
        private System.Windows.Forms.Label lblProDate;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFirms;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dtgMedicine;
        private System.Windows.Forms.GroupBox grpTagGroup;
        private System.Windows.Forms.Button btnExit;
    }
}