
namespace SilverTune.ARTIST
{
    partial class ArchiveArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveArtist));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.upImgBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtNNStageName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistStageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIdentityNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistStreetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistStreetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistCityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistCountryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aristPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.artistAvailabilityStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paseOneDS = new SilverTune.paseOneDS();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.aRTISTTableAdapter = new SilverTune.paseOneDSTableAdapters.ARTISTTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1306, 663);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archive Artist";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtSurname);
            this.groupBox3.Controls.Add(this.txtNNStageName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(64, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1173, 259);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirm Artist";
            // 
            // upImgBtn
            // 
            this.upImgBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.upImgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.upImgBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upImgBtn.Location = new System.Drawing.Point(404, 3);
            this.upImgBtn.Name = "upImgBtn";
            this.upImgBtn.Size = new System.Drawing.Size(249, 35);
            this.upImgBtn.TabIndex = 110;
            this.upImgBtn.Text = "Archive Artist";
            this.upImgBtn.UseVisualStyleBackColor = false;
            this.upImgBtn.Click += new System.EventHandler(this.upImgBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(0, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 35);
            this.button3.TabIndex = 109;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(426, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(410, 32);
            this.txtEmail.TabIndex = 108;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurname.Location = new System.Drawing.Point(426, 76);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(410, 32);
            this.txtSurname.TabIndex = 107;
            // 
            // txtNNStageName
            // 
            this.txtNNStageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNNStageName.Location = new System.Drawing.Point(426, 31);
            this.txtNNStageName.Name = "txtNNStageName";
            this.txtNNStageName.Size = new System.Drawing.Size(410, 32);
            this.txtNNStageName.TabIndex = 106;
            this.txtNNStageName.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 26);
            this.label11.TabIndex = 105;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 26);
            this.label12.TabIndex = 104;
            this.label12.Text = "Surname";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 26);
            this.label13.TabIndex = 103;
            this.label13.Text = "Stage Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(64, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1173, 321);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Artist";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIDDataGridViewTextBoxColumn,
            this.artistFirstNameDataGridViewTextBoxColumn,
            this.artistLastNameDataGridViewTextBoxColumn,
            this.artistStageNameDataGridViewTextBoxColumn,
            this.artistEmailDataGridViewTextBoxColumn,
            this.artistIdentityNoDataGridViewTextBoxColumn,
            this.artistPhoneNumberDataGridViewTextBoxColumn,
            this.artistGenreDataGridViewTextBoxColumn,
            this.artistStreetNameDataGridViewTextBoxColumn,
            this.artistStreetNumberDataGridViewTextBoxColumn,
            this.artistCityNameDataGridViewTextBoxColumn,
            this.artistCountryNameDataGridViewTextBoxColumn,
            this.aristPostalCodeDataGridViewTextBoxColumn,
            this.artistImageDataGridViewImageColumn,
            this.artistAvailabilityStatusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.aRTISTBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(92, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1001, 190);
            this.dataGridView2.TabIndex = 90;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            this.artistIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistFirstNameDataGridViewTextBoxColumn
            // 
            this.artistFirstNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistFirstName";
            this.artistFirstNameDataGridViewTextBoxColumn.HeaderText = "ArtistFirstName";
            this.artistFirstNameDataGridViewTextBoxColumn.Name = "artistFirstNameDataGridViewTextBoxColumn";
            // 
            // artistLastNameDataGridViewTextBoxColumn
            // 
            this.artistLastNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistLastName";
            this.artistLastNameDataGridViewTextBoxColumn.HeaderText = "ArtistLastName";
            this.artistLastNameDataGridViewTextBoxColumn.Name = "artistLastNameDataGridViewTextBoxColumn";
            // 
            // artistStageNameDataGridViewTextBoxColumn
            // 
            this.artistStageNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistStageName";
            this.artistStageNameDataGridViewTextBoxColumn.HeaderText = "ArtistStageName";
            this.artistStageNameDataGridViewTextBoxColumn.Name = "artistStageNameDataGridViewTextBoxColumn";
            // 
            // artistEmailDataGridViewTextBoxColumn
            // 
            this.artistEmailDataGridViewTextBoxColumn.DataPropertyName = "ArtistEmail";
            this.artistEmailDataGridViewTextBoxColumn.HeaderText = "ArtistEmail";
            this.artistEmailDataGridViewTextBoxColumn.Name = "artistEmailDataGridViewTextBoxColumn";
            // 
            // artistIdentityNoDataGridViewTextBoxColumn
            // 
            this.artistIdentityNoDataGridViewTextBoxColumn.DataPropertyName = "ArtistIdentityNo";
            this.artistIdentityNoDataGridViewTextBoxColumn.HeaderText = "ArtistIdentityNo";
            this.artistIdentityNoDataGridViewTextBoxColumn.Name = "artistIdentityNoDataGridViewTextBoxColumn";
            // 
            // artistPhoneNumberDataGridViewTextBoxColumn
            // 
            this.artistPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "ArtistPhoneNumber";
            this.artistPhoneNumberDataGridViewTextBoxColumn.HeaderText = "ArtistPhoneNumber";
            this.artistPhoneNumberDataGridViewTextBoxColumn.Name = "artistPhoneNumberDataGridViewTextBoxColumn";
            // 
            // artistGenreDataGridViewTextBoxColumn
            // 
            this.artistGenreDataGridViewTextBoxColumn.DataPropertyName = "ArtistGenre";
            this.artistGenreDataGridViewTextBoxColumn.HeaderText = "ArtistGenre";
            this.artistGenreDataGridViewTextBoxColumn.Name = "artistGenreDataGridViewTextBoxColumn";
            // 
            // artistStreetNameDataGridViewTextBoxColumn
            // 
            this.artistStreetNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistStreetName";
            this.artistStreetNameDataGridViewTextBoxColumn.HeaderText = "ArtistStreetName";
            this.artistStreetNameDataGridViewTextBoxColumn.Name = "artistStreetNameDataGridViewTextBoxColumn";
            // 
            // artistStreetNumberDataGridViewTextBoxColumn
            // 
            this.artistStreetNumberDataGridViewTextBoxColumn.DataPropertyName = "ArtistStreetNumber";
            this.artistStreetNumberDataGridViewTextBoxColumn.HeaderText = "ArtistStreetNumber";
            this.artistStreetNumberDataGridViewTextBoxColumn.Name = "artistStreetNumberDataGridViewTextBoxColumn";
            // 
            // artistCityNameDataGridViewTextBoxColumn
            // 
            this.artistCityNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistCityName";
            this.artistCityNameDataGridViewTextBoxColumn.HeaderText = "ArtistCityName";
            this.artistCityNameDataGridViewTextBoxColumn.Name = "artistCityNameDataGridViewTextBoxColumn";
            // 
            // artistCountryNameDataGridViewTextBoxColumn
            // 
            this.artistCountryNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistCountryName";
            this.artistCountryNameDataGridViewTextBoxColumn.HeaderText = "ArtistCountryName";
            this.artistCountryNameDataGridViewTextBoxColumn.Name = "artistCountryNameDataGridViewTextBoxColumn";
            // 
            // aristPostalCodeDataGridViewTextBoxColumn
            // 
            this.aristPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "AristPostalCode";
            this.aristPostalCodeDataGridViewTextBoxColumn.HeaderText = "AristPostalCode";
            this.aristPostalCodeDataGridViewTextBoxColumn.Name = "aristPostalCodeDataGridViewTextBoxColumn";
            // 
            // artistImageDataGridViewImageColumn
            // 
            this.artistImageDataGridViewImageColumn.DataPropertyName = "ArtistImage";
            this.artistImageDataGridViewImageColumn.HeaderText = "ArtistImage";
            this.artistImageDataGridViewImageColumn.Name = "artistImageDataGridViewImageColumn";
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
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(490, 52);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(395, 32);
            this.textBox11.TabIndex = 88;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 26);
            this.label14.TabIndex = 89;
            this.label14.Text = "Search Artist By Stage Name";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // aRTISTTableAdapter
            // 
            this.aRTISTTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.upImgBtn);
            this.panel1.Location = new System.Drawing.Point(515, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 40);
            this.panel1.TabIndex = 112;
            // 
            // ArchiveArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 663);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "ArchiveArtist";
            this.Text = "ArchiveArtist";
            this.Load += new System.EventHandler(this.ArchiveArtist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button upImgBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtNNStageName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private paseOneDS paseOneDS;
        private System.Windows.Forms.BindingSource aRTISTBindingSource;
        private paseOneDSTableAdapters.ARTISTTableAdapter aRTISTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistStageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdentityNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistStreetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistStreetNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistCityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistCountryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aristPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn artistImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistAvailabilityStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}