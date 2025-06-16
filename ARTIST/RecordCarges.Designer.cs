
namespace SilverTune.ARTIST
{
    partial class RecordCarges
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistStageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistCountryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistAvailabilityStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paseOneDS = new SilverTune.paseOneDS();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.artChargeHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artName = new System.Windows.Forms.TextBox();
            this.aRTISTTableAdapter = new SilverTune.paseOneDSTableAdapters.ARTISTTableAdapter();
            this.artistfeesTableAdapter = new SilverTune.paseOneDSTableAdapters.ARTISTFEESTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.typeCombo);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.artChargeHour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.artName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 561);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Artist Charges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 26);
            this.label5.TabIndex = 92;
            this.label5.Text = "Amount Charged/Hour";
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Individual",
            "Organisation"});
            this.typeCombo.Location = new System.Drawing.Point(610, 328);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(283, 34);
            this.typeCombo.TabIndex = 91;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(610, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(358, 32);
            this.textBox3.TabIndex = 30;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Search Artist By Stage Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIDDataGridViewTextBoxColumn,
            this.artistStageNameDataGridViewTextBoxColumn,
            this.artistGenreDataGridViewTextBoxColumn,
            this.artistCountryNameDataGridViewTextBoxColumn,
            this.artistAvailabilityStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aRTISTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(177, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(931, 82);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            this.artistIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistStageNameDataGridViewTextBoxColumn
            // 
            this.artistStageNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistStageName";
            this.artistStageNameDataGridViewTextBoxColumn.HeaderText = "ArtistStageName";
            this.artistStageNameDataGridViewTextBoxColumn.Name = "artistStageNameDataGridViewTextBoxColumn";
            // 
            // artistGenreDataGridViewTextBoxColumn
            // 
            this.artistGenreDataGridViewTextBoxColumn.DataPropertyName = "ArtistGenre";
            this.artistGenreDataGridViewTextBoxColumn.HeaderText = "ArtistGenre";
            this.artistGenreDataGridViewTextBoxColumn.Name = "artistGenreDataGridViewTextBoxColumn";
            // 
            // artistCountryNameDataGridViewTextBoxColumn
            // 
            this.artistCountryNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistCountryName";
            this.artistCountryNameDataGridViewTextBoxColumn.HeaderText = "ArtistCountryName";
            this.artistCountryNameDataGridViewTextBoxColumn.Name = "artistCountryNameDataGridViewTextBoxColumn";
            // 
            // artistAvailabilityStatusDataGridViewTextBoxColumn
            // 
            this.artistAvailabilityStatusDataGridViewTextBoxColumn.DataPropertyName = "ArtistAvailabilityStatus";
            this.artistAvailabilityStatusDataGridViewTextBoxColumn.HeaderText = "ArtistAvailabilityStatus";
            this.artistAvailabilityStatusDataGridViewTextBoxColumn.Name = "artistAvailabilityStatusDataGridViewTextBoxColumn";
            // 
            // aRTISTBindingSource
            // 
            this.aRTISTBindingSource.DataMember = "ARTIST";
            this.aRTISTBindingSource.DataSource = this.paseOneDS;
            // 
            // paseOneDS
            // 
            this.paseOneDS.DataSetName = "paseOneDS";
            this.paseOneDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(383, 484);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 41);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(258, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Client Type";
            // 
            // artChargeHour
            // 
            this.artChargeHour.Location = new System.Drawing.Point(610, 379);
            this.artChargeHour.Name = "artChargeHour";
            this.artChargeHour.Size = new System.Drawing.Size(283, 32);
            this.artChargeHour.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Artist";
            // 
            // artName
            // 
            this.artName.Location = new System.Drawing.Point(610, 276);
            this.artName.Name = "artName";
            this.artName.Size = new System.Drawing.Size(283, 32);
            this.artName.TabIndex = 0;
            // 
            // aRTISTTableAdapter
            // 
            this.aRTISTTableAdapter.ClearBeforeFill = true;
            // 
            // artistfeesTableAdapter
            // 
            this.artistfeesTableAdapter.ClearBeforeFill = true;
            // 
            // RecordCarges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 585);
            this.Controls.Add(this.groupBox1);
            this.Name = "RecordCarges";
            this.Text = "RecordCarges";
            this.Load += new System.EventHandler(this.RecordCarges_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox artChargeHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox artName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typeCombo;
        private paseOneDS paseOneDS;
        private System.Windows.Forms.BindingSource aRTISTBindingSource;
        private paseOneDSTableAdapters.ARTISTTableAdapter aRTISTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistStageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistCountryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistAvailabilityStatusDataGridViewTextBoxColumn;
        private paseOneDSTableAdapters.ARTISTFEESTableAdapter artistfeesTableAdapter;
    }
}