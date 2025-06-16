
namespace SilverTune.ARTIST
{
    partial class UpdateArtistV2
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pcArt = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
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
            this.aRTISTTableAdapter = new SilverTune.paseOneDSTableAdapters.ARTISTTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcArt)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1368, 767);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Artist";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txtImg);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.txtPostCode);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.txtCountry);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCity);
            this.groupBox3.Controls.Add(this.txtStreetNumber);
            this.groupBox3.Controls.Add(this.txtStreetName);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.pcArt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(64, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1214, 399);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Artist Details";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(522, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(249, 35);
            this.button7.TabIndex = 132;
            this.button7.Text = "Update Postal Code";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(198, 300);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(300, 32);
            this.txtPostCode.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 130;
            this.label2.Text = "Postal Code";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(522, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(249, 35);
            this.button6.TabIndex = 129;
            this.button6.Text = "Update Country";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(198, 258);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(300, 32);
            this.txtCountry.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 127;
            this.label1.Text = "Country";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1049, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 126;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(519, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(249, 35);
            this.button5.TabIndex = 125;
            this.button5.Text = "Update City";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(519, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 35);
            this.button4.TabIndex = 124;
            this.button4.Text = "Update Street Number";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(519, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 35);
            this.button2.TabIndex = 123;
            this.button2.Text = "Update Street Name";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Green;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(519, 76);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(249, 35);
            this.button8.TabIndex = 122;
            this.button8.Text = "Update Phone Number";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Green;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(519, 31);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(249, 35);
            this.button9.TabIndex = 121;
            this.button9.Text = "Update Email";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(939, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 26);
            this.label8.TabIndex = 120;
            this.label8.Text = "Artist Image";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(198, 216);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(300, 32);
            this.txtCity.TabIndex = 119;
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(198, 171);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(300, 32);
            this.txtStreetNumber.TabIndex = 118;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(198, 121);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(300, 32);
            this.txtStreetName.TabIndex = 117;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(198, 79);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 32);
            this.txtPhone.TabIndex = 116;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(198, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 32);
            this.txtEmail.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 26);
            this.label9.TabIndex = 114;
            this.label9.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 26);
            this.label10.TabIndex = 113;
            this.label10.Text = "Street Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 26);
            this.label11.TabIndex = 112;
            this.label11.Text = "Street Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 26);
            this.label12.TabIndex = 111;
            this.label12.Text = "Phonenumber";
            // 
            // pcArt
            // 
            this.pcArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcArt.Location = new System.Drawing.Point(869, 51);
            this.pcArt.Name = "pcArt";
            this.pcArt.Size = new System.Drawing.Size(309, 200);
            this.pcArt.TabIndex = 110;
            this.pcArt.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 26);
            this.label13.TabIndex = 109;
            this.label13.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(64, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1214, 319);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Artist";
            // 
            // dataGridView2
            // 
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
            this.dataGridView2.Location = new System.Drawing.Point(95, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1004, 190);
            this.dataGridView2.TabIndex = 90;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(493, 31);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(395, 32);
            this.textBox11.TabIndex = 88;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 26);
            this.label14.TabIndex = 89;
            this.label14.Text = "Search Artist By Stage Name";
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(869, 270);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(174, 32);
            this.txtImg.TabIndex = 133;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(918, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 35);
            this.button3.TabIndex = 134;
            this.button3.Text = "Update Picture";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // aRTISTTableAdapter
            // 
            this.aRTISTTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateArtistV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 767);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateArtistV2";
            this.Text = "UpdateArtistV2";
            this.Load += new System.EventHandler(this.UpdateArtistV2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcArt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pcArt;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button3;
    }
}