
namespace SilverTune.ARTIST
{
    partial class RecordArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordArtist));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.artGenTxt = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.imgBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.artistSelected = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.artPostCodeTxt = new System.Windows.Forms.TextBox();
            this.artCountTxt = new System.Windows.Forms.TextBox();
            this.artCityTxt = new System.Windows.Forms.TextBox();
            this.artStreetNoTxt = new System.Windows.Forms.TextBox();
            this.artStreetNameTxt = new System.Windows.Forms.TextBox();
            this.artIdNoTxt = new System.Windows.Forms.TextBox();
            this.ArtPhoneNoTxt = new System.Windows.Forms.TextBox();
            this.artEmailTxt = new System.Windows.Forms.TextBox();
            this.artStageNameTxt = new System.Windows.Forms.TextBox();
            this.artSurnTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.artistTableAdapter = new SilverTune.paseOneDSTableAdapters.ARTISTTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistSelected)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.artGenTxt);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtImg);
            this.groupBox1.Controls.Add(this.artIdNoTxt);
            this.groupBox1.Controls.Add(this.ArtPhoneNoTxt);
            this.groupBox1.Controls.Add(this.artEmailTxt);
            this.groupBox1.Controls.Add(this.artStageNameTxt);
            this.groupBox1.Controls.Add(this.artSurnTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.artNameTxt);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1366, 708);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Artist";
            // 
            // artGenTxt
            // 
            this.artGenTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artGenTxt.FormattingEnabled = true;
            this.artGenTxt.Items.AddRange(new object[] {
            "Pop  ",
            "Hip-Hop  ",
            "R&B  ",
            "Afrobeat  ",
            "Amapiano  ",
            "House  ",
            "Kwaito  ",
            "Jazz  ",
            "Gospel  ",
            "Reggae  ",
            "Dancehall  ",
            "Gqom  ",
            "EDM  ",
            "Trap  ",
            "Soul  ",
            "Rock  ",
            "Alternative  ",
            "Indie  ",
            "Classical  ",
            "Funk  ",
            "Techno  ",
            "Deep House  ",
            "Blues  ",
            "Traditional  ",
            "Spoken Word  ",
            "Opera  ",
            "Country  ",
            "Punk  ",
            "Metal  ",
            "Latin  ",
            "Folk  ",
            "Instrumental  "});
            this.artGenTxt.Location = new System.Drawing.Point(560, 300);
            this.artGenTxt.Name = "artGenTxt";
            this.artGenTxt.Size = new System.Drawing.Size(283, 34);
            this.artGenTxt.TabIndex = 93;
            this.artGenTxt.Text = "Amapiano";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(374, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 26);
            this.label16.TabIndex = 30;
            this.label16.Text = "Genre";
            // 
            // imgBtn
            // 
            this.imgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.imgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.imgBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imgBtn.Location = new System.Drawing.Point(613, 304);
            this.imgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.imgBtn.Name = "imgBtn";
            this.imgBtn.Size = new System.Drawing.Size(133, 36);
            this.imgBtn.TabIndex = 28;
            this.imgBtn.Text = "Browse";
            this.imgBtn.UseVisualStyleBackColor = false;
            this.imgBtn.Click += new System.EventHandler(this.imgBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.artistSelected);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(938, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 300);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artist Image ";
            // 
            // artistSelected
            // 
            this.artistSelected.Location = new System.Drawing.Point(55, 38);
            this.artistSelected.Name = "artistSelected";
            this.artistSelected.Size = new System.Drawing.Size(233, 246);
            this.artistSelected.TabIndex = 1;
            this.artistSelected.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 26);
            this.label14.TabIndex = 23;
            this.label14.Text = "Image";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(276, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 26);
            this.label13.TabIndex = 22;
            this.label13.Text = "Country Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 26);
            this.label12.TabIndex = 21;
            this.label12.Text = "Postal Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "City Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Street No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Street Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phone No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Identity No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stage Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Surname";
            // 
            // txtImg
            // 
            this.txtImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImg.Location = new System.Drawing.Point(560, 337);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(147, 32);
            this.txtImg.TabIndex = 12;
            // 
            // artPostCodeTxt
            // 
            this.artPostCodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artPostCodeTxt.Location = new System.Drawing.Point(462, 180);
            this.artPostCodeTxt.Name = "artPostCodeTxt";
            this.artPostCodeTxt.Size = new System.Drawing.Size(302, 32);
            this.artPostCodeTxt.TabIndex = 11;
            // 
            // artCountTxt
            // 
            this.artCountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artCountTxt.Location = new System.Drawing.Point(462, 142);
            this.artCountTxt.Name = "artCountTxt";
            this.artCountTxt.Size = new System.Drawing.Size(302, 32);
            this.artCountTxt.TabIndex = 10;
            // 
            // artCityTxt
            // 
            this.artCityTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artCityTxt.Location = new System.Drawing.Point(462, 104);
            this.artCityTxt.Name = "artCityTxt";
            this.artCityTxt.Size = new System.Drawing.Size(302, 32);
            this.artCityTxt.TabIndex = 9;
            // 
            // artStreetNoTxt
            // 
            this.artStreetNoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artStreetNoTxt.Location = new System.Drawing.Point(462, 66);
            this.artStreetNoTxt.Name = "artStreetNoTxt";
            this.artStreetNoTxt.Size = new System.Drawing.Size(302, 32);
            this.artStreetNoTxt.TabIndex = 8;
            // 
            // artStreetNameTxt
            // 
            this.artStreetNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artStreetNameTxt.Location = new System.Drawing.Point(462, 28);
            this.artStreetNameTxt.Name = "artStreetNameTxt";
            this.artStreetNameTxt.Size = new System.Drawing.Size(302, 32);
            this.artStreetNameTxt.TabIndex = 7;
            // 
            // artIdNoTxt
            // 
            this.artIdNoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artIdNoTxt.Location = new System.Drawing.Point(560, 259);
            this.artIdNoTxt.Name = "artIdNoTxt";
            this.artIdNoTxt.Size = new System.Drawing.Size(283, 32);
            this.artIdNoTxt.TabIndex = 6;
            // 
            // ArtPhoneNoTxt
            // 
            this.ArtPhoneNoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtPhoneNoTxt.Location = new System.Drawing.Point(560, 221);
            this.ArtPhoneNoTxt.Name = "ArtPhoneNoTxt";
            this.ArtPhoneNoTxt.Size = new System.Drawing.Size(283, 32);
            this.ArtPhoneNoTxt.TabIndex = 5;
            // 
            // artEmailTxt
            // 
            this.artEmailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artEmailTxt.Location = new System.Drawing.Point(560, 183);
            this.artEmailTxt.Name = "artEmailTxt";
            this.artEmailTxt.Size = new System.Drawing.Size(283, 32);
            this.artEmailTxt.TabIndex = 4;
            // 
            // artStageNameTxt
            // 
            this.artStageNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artStageNameTxt.Location = new System.Drawing.Point(560, 145);
            this.artStageNameTxt.Name = "artStageNameTxt";
            this.artStageNameTxt.Size = new System.Drawing.Size(283, 32);
            this.artStageNameTxt.TabIndex = 3;
            // 
            // artSurnTxt
            // 
            this.artSurnTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artSurnTxt.Location = new System.Drawing.Point(560, 107);
            this.artSurnTxt.Name = "artSurnTxt";
            this.artSurnTxt.Size = new System.Drawing.Size(283, 32);
            this.artSurnTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // artNameTxt
            // 
            this.artNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artNameTxt.Location = new System.Drawing.Point(560, 69);
            this.artNameTxt.Name = "artNameTxt";
            this.artNameTxt.Size = new System.Drawing.Size(283, 32);
            this.artNameTxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.artStreetNameTxt);
            this.groupBox3.Controls.Add(this.artStreetNoTxt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.artCityTxt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.artCountTxt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.artPostCodeTxt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(97, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1236, 283);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter Address Details";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(512, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 39);
            this.panel2.TabIndex = 112;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(401, 0);
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
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.imgBtn);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(97, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1236, 367);
            this.groupBox4.TabIndex = 94;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enter Personal Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 748);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 53);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(464, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(341, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "@ SilverTune All Rights Reserved";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // artistTableAdapter
            // 
            this.artistTableAdapter.ClearBeforeFill = true;
            // 
            // RecordArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 801);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RecordArtist";
            this.Text = "RecordArtist";
            this.Load += new System.EventHandler(this.RecordArtist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artistSelected)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox artNameTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.TextBox artPostCodeTxt;
        private System.Windows.Forms.TextBox artCountTxt;
        private System.Windows.Forms.TextBox artCityTxt;
        private System.Windows.Forms.TextBox artStreetNoTxt;
        private System.Windows.Forms.TextBox artStreetNameTxt;
        private System.Windows.Forms.TextBox artIdNoTxt;
        private System.Windows.Forms.TextBox ArtPhoneNoTxt;
        private System.Windows.Forms.TextBox artEmailTxt;
        private System.Windows.Forms.TextBox artStageNameTxt;
        private System.Windows.Forms.TextBox artSurnTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox artistSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button imgBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox artGenTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private paseOneDSTableAdapters.ARTISTTableAdapter artistTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
    }
}