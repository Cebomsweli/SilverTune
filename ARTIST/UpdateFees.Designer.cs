
namespace SilverTune.ARTIST
{
    partial class UpdateFees
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFees));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.artName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.artChargeHour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paseOneDS = new SilverTune.paseOneDS();
            this.aRTISTFEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRTISTFEESTableAdapter = new SilverTune.paseOneDSTableAdapters.ARTISTFEESTableAdapter();
            this.feeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateAmountPerHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTFEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1410, 641);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Artist Fees";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.typeCombo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(112, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1245, 301);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Artist";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feeIDDataGridViewTextBoxColumn,
            this.artistIDDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.rateAmountPerHourDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aRTISTFEESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1116, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(358, 32);
            this.textBox3.TabIndex = 32;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter Artist ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.artName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.artChargeHour);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(112, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1245, 229);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Fees";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(908, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "Update Fee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // artName
            // 
            this.artName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artName.Location = new System.Drawing.Point(435, 46);
            this.artName.Name = "artName";
            this.artName.Size = new System.Drawing.Size(391, 32);
            this.artName.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 26);
            this.label5.TabIndex = 120;
            this.label5.Text = "Amount Charged/Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 114;
            this.label2.Text = "Selected ID";
            // 
            // typeCombo
            // 
            this.typeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Individual",
            "Organisation"});
            this.typeCombo.Location = new System.Drawing.Point(893, 38);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(292, 34);
            this.typeCombo.TabIndex = 119;
            this.typeCombo.Text = "Individual";
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            // 
            // artChargeHour
            // 
            this.artChargeHour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artChargeHour.Location = new System.Drawing.Point(435, 149);
            this.artChargeHour.Name = "artChargeHour";
            this.artChargeHour.Size = new System.Drawing.Size(391, 32);
            this.artChargeHour.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 26);
            this.label4.TabIndex = 116;
            this.label4.Text = "Select Client Type";
            // 
            // paseOneDS
            // 
            this.paseOneDS.DataSetName = "paseOneDS";
            this.paseOneDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRTISTFEESBindingSource
            // 
            this.aRTISTFEESBindingSource.DataMember = "ARTISTFEES";
            this.aRTISTFEESBindingSource.DataSource = this.paseOneDS;
            // 
            // aRTISTFEESTableAdapter
            // 
            this.aRTISTFEESTableAdapter.ClearBeforeFill = true;
            // 
            // feeIDDataGridViewTextBoxColumn
            // 
            this.feeIDDataGridViewTextBoxColumn.DataPropertyName = "FeeID";
            this.feeIDDataGridViewTextBoxColumn.HeaderText = "FeeID";
            this.feeIDDataGridViewTextBoxColumn.Name = "feeIDDataGridViewTextBoxColumn";
            this.feeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            // 
            // rateAmountPerHourDataGridViewTextBoxColumn
            // 
            this.rateAmountPerHourDataGridViewTextBoxColumn.DataPropertyName = "RateAmountPerHour";
            this.rateAmountPerHourDataGridViewTextBoxColumn.HeaderText = "RateAmountPerHour";
            this.rateAmountPerHourDataGridViewTextBoxColumn.Name = "rateAmountPerHourDataGridViewTextBoxColumn";
            // 
            // UpdateFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1434, 752);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateFees";
            this.Text = "UpdateFees";
            this.Load += new System.EventHandler(this.UpdateFees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTFEESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox artName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.TextBox artChargeHour;
        private System.Windows.Forms.Label label4;
        private paseOneDS paseOneDS;
        private System.Windows.Forms.BindingSource aRTISTFEESBindingSource;
        private paseOneDSTableAdapters.ARTISTFEESTableAdapter aRTISTFEESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateAmountPerHourDataGridViewTextBoxColumn;
    }
}