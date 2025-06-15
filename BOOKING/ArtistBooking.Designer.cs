
namespace SilverTune.BOOKING
{
    partial class ArtistBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistStageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistCountryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistAvailabilityStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paseOneDS = new SilverTune.paseOneDS();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.DateTimePicker();
            this.durCombo = new System.Windows.Forms.ComboBox();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.eventDateTxt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.typeText = new System.Windows.Forms.TextBox();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.locTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cliePhonTxt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clieSearchTxt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clieEmailTxt = new System.Windows.Forms.TextBox();
            this.clieSurnTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clieNameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.aRTISTTableAdapter = new SilverTune.paseOneDSTableAdapters.ARTISTTableAdapter();
            this.cLIENTTableAdapter = new SilverTune.paseOneDSTableAdapters.CLIENTTableAdapter();
            this.bookingTableAdapter = new SilverTune.paseOneDSTableAdapters.BOOKINGTableAdapter();
            this.artistfeesTableAdapter = new SilverTune.paseOneDSTableAdapters.ARTISTFEESTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 733);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 53);
            this.panel1.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(493, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(341, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "@ SilverTune All Rights Reserved";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1402, 720);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Booking";
            
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.durCombo);
            this.panel2.Controls.Add(this.typeCombo);
            this.panel2.Controls.Add(this.eventDateTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.typeText);
            this.panel2.Controls.Add(this.typeTxt);
            this.panel2.Controls.Add(this.locTxt);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(31, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1335, 349);
            this.panel2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(723, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 32);
            this.textBox2.TabIndex = 81;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(1216, 265);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 26);
            this.label19.TabIndex = 100;
            this.label19.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 26);
            this.label2.TabIndex = 82;
            this.label2.Text = "Search Artist By Stage Name";
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
            this.dataGridView1.Location = new System.Drawing.Point(241, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(923, 76);
            this.dataGridView1.TabIndex = 78;
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(626, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 26);
            this.label18.TabIndex = 99;
            this.label18.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(626, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 26);
            this.label14.TabIndex = 98;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1217, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 26);
            this.label13.TabIndex = 97;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1216, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 26);
            this.label12.TabIndex = 96;
            this.label12.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(626, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 26);
            this.label7.TabIndex = 95;
            this.label7.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 94;
            this.label1.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.CalendarFont = new System.Drawing.Font("Times New Roman", 16F);
            this.txtTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtTime.Location = new System.Drawing.Point(928, 179);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.Name = "txtTime";
            this.txtTime.ShowUpDown = true;
            this.txtTime.Size = new System.Drawing.Size(283, 26);
            this.txtTime.TabIndex = 93;
            this.txtTime.Value = new System.DateTime(2024, 6, 7, 3, 29, 0, 0);
            // 
            // durCombo
            // 
            this.durCombo.FormattingEnabled = true;
            this.durCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.durCombo.Location = new System.Drawing.Point(337, 257);
            this.durCombo.Name = "durCombo";
            this.durCombo.Size = new System.Drawing.Size(283, 34);
            this.durCombo.TabIndex = 92;
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Individual",
            "Organisation"});
            this.typeCombo.Location = new System.Drawing.Point(928, 257);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(283, 34);
            this.typeCombo.TabIndex = 90;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged_1);
            // 
            // eventDateTxt
            // 
            this.eventDateTxt.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateTxt.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight;
            this.eventDateTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateTxt.Location = new System.Drawing.Point(337, 179);
            this.eventDateTxt.Margin = new System.Windows.Forms.Padding(2);
            this.eventDateTxt.Name = "eventDateTxt";
            this.eventDateTxt.Size = new System.Drawing.Size(283, 26);
            this.eventDateTxt.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 26);
            this.label4.TabIndex = 89;
            this.label4.Text = "No Artist Is Selected";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(742, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 26);
            this.label8.TabIndex = 88;
            this.label8.Text = "Request From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 87;
            this.label6.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 26);
            this.label5.TabIndex = 86;
            this.label5.Text = "Venue Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(742, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 26);
            this.label16.TabIndex = 85;
            this.label16.Text = "Location";
            // 
            // typeText
            // 
            this.typeText.Location = new System.Drawing.Point(928, 307);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(283, 32);
            this.typeText.TabIndex = 84;
            this.typeText.Text = "Enter Org. name";
            this.typeText.Visible = false;
            // 
            // typeTxt
            // 
            this.typeTxt.Location = new System.Drawing.Point(337, 216);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(283, 32);
            this.typeTxt.TabIndex = 83;
            // 
            // locTxt
            // 
            this.locTxt.Location = new System.Drawing.Point(928, 216);
            this.locTxt.Name = "locTxt";
            this.locTxt.Size = new System.Drawing.Size(283, 32);
            this.locTxt.TabIndex = 80;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(151, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 26);
            this.label17.TabIndex = 79;
            this.label17.Text = "Date";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.cliePhonTxt);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Controls.Add(this.clieSearchTxt);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.clieEmailTxt);
            this.groupBox5.Controls.Add(this.clieSurnTxt);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.clieNameTxt);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox5.Location = new System.Drawing.Point(45, 386);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1357, 329);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Record Client";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(1222, 208);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 26);
            this.label25.TabIndex = 83;
            this.label25.Text = "*";
            // 
            // cliePhonTxt
            // 
            this.cliePhonTxt.Location = new System.Drawing.Point(930, 205);
            this.cliePhonTxt.Name = "cliePhonTxt";
            this.cliePhonTxt.Size = new System.Drawing.Size(283, 32);
            this.cliePhonTxt.TabIndex = 82;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(744, 208);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(115, 26);
            this.label24.TabIndex = 81;
            this.label24.Text = "Phone No.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(451, 276);
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
            // clieSearchTxt
            // 
            this.clieSearchTxt.Location = new System.Drawing.Point(712, 28);
            this.clieSearchTxt.Name = "clieSearchTxt";
            this.clieSearchTxt.Size = new System.Drawing.Size(358, 32);
            this.clieSearchTxt.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(1222, 167);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 26);
            this.label23.TabIndex = 80;
            this.label23.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Artist By Stage Name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientFirstNameDataGridViewTextBoxColumn,
            this.clientLastNameDataGridViewTextBoxColumn,
            this.clientPhoneNumberDataGridViewTextBoxColumn,
            this.clientEmailDataGridViewTextBoxColumn,
            this.clientStatusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cLIENTBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(243, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(936, 90);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientFirstNameDataGridViewTextBoxColumn
            // 
            this.clientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "ClientFirstName";
            this.clientFirstNameDataGridViewTextBoxColumn.HeaderText = "ClientFirstName";
            this.clientFirstNameDataGridViewTextBoxColumn.Name = "clientFirstNameDataGridViewTextBoxColumn";
            // 
            // clientLastNameDataGridViewTextBoxColumn
            // 
            this.clientLastNameDataGridViewTextBoxColumn.DataPropertyName = "ClientLastName";
            this.clientLastNameDataGridViewTextBoxColumn.HeaderText = "ClientLastName";
            this.clientLastNameDataGridViewTextBoxColumn.Name = "clientLastNameDataGridViewTextBoxColumn";
            // 
            // clientPhoneNumberDataGridViewTextBoxColumn
            // 
            this.clientPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "ClientPhoneNumber";
            this.clientPhoneNumberDataGridViewTextBoxColumn.HeaderText = "ClientPhoneNumber";
            this.clientPhoneNumberDataGridViewTextBoxColumn.Name = "clientPhoneNumberDataGridViewTextBoxColumn";
            // 
            // clientEmailDataGridViewTextBoxColumn
            // 
            this.clientEmailDataGridViewTextBoxColumn.DataPropertyName = "ClientEmail";
            this.clientEmailDataGridViewTextBoxColumn.HeaderText = "ClientEmail";
            this.clientEmailDataGridViewTextBoxColumn.Name = "clientEmailDataGridViewTextBoxColumn";
            // 
            // clientStatusDataGridViewTextBoxColumn
            // 
            this.clientStatusDataGridViewTextBoxColumn.DataPropertyName = "ClientStatus";
            this.clientStatusDataGridViewTextBoxColumn.HeaderText = "ClientStatus";
            this.clientStatusDataGridViewTextBoxColumn.Name = "clientStatusDataGridViewTextBoxColumn";
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.paseOneDS;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(628, 205);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 26);
            this.label22.TabIndex = 79;
            this.label22.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(628, 167);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 26);
            this.label21.TabIndex = 78;
            this.label21.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name";
            // 
            // clieEmailTxt
            // 
            this.clieEmailTxt.Location = new System.Drawing.Point(930, 167);
            this.clieEmailTxt.Name = "clieEmailTxt";
            this.clieEmailTxt.Size = new System.Drawing.Size(283, 32);
            this.clieEmailTxt.TabIndex = 9;
            // 
            // clieSurnTxt
            // 
            this.clieSurnTxt.Location = new System.Drawing.Point(339, 205);
            this.clieSurnTxt.Name = "clieSurnTxt";
            this.clieSurnTxt.Size = new System.Drawing.Size(283, 32);
            this.clieSurnTxt.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(744, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email";
            // 
            // clieNameTxt
            // 
            this.clieNameTxt.Location = new System.Drawing.Point(339, 164);
            this.clieNameTxt.Name = "clieNameTxt";
            this.clieNameTxt.Size = new System.Drawing.Size(283, 32);
            this.clieNameTxt.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Surname";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // aRTISTTableAdapter
            // 
            this.aRTISTTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // artistfeesTableAdapter
            // 
            this.artistfeesTableAdapter.ClearBeforeFill = true;
            // 
            // ArtistBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 786);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ArtistBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ArtistBooking";
            this.Load += new System.EventHandler(this.ArtistBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtTime;
        private System.Windows.Forms.ComboBox durCombo;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.DateTimePicker eventDateTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.TextBox typeTxt;
        private System.Windows.Forms.TextBox locTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox cliePhonTxt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox clieSearchTxt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox clieEmailTxt;
        private System.Windows.Forms.TextBox clieSurnTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox clieNameTxt;
        private System.Windows.Forms.Label label10;
        private paseOneDS paseOneDS;
        private System.Windows.Forms.BindingSource aRTISTBindingSource;
        private paseOneDSTableAdapters.ARTISTTableAdapter aRTISTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistStageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistCountryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistAvailabilityStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private paseOneDSTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientStatusDataGridViewTextBoxColumn;
        private paseOneDSTableAdapters.BOOKINGTableAdapter bookingTableAdapter;
        private paseOneDSTableAdapters.ARTISTFEESTableAdapter artistfeesTableAdapter;
    }
}