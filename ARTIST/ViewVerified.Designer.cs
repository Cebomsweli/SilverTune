
namespace SilverTune.ARTIST
{
    partial class ViewVerified
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIdNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pctArt = new System.Windows.Forms.PictureBox();
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
            this.artistImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.artistAvailabilityStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paseOneDS = new SilverTune.paseOneDS();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.aRTISTTableAdapter = new SilverTune.paseOneDSTableAdapters.ARTISTTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctArt)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1217, 690);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Verified Artists";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPhoneNo);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtIdNo);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtStageName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.pctArt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(64, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1063, 272);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Artist Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(804, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 26);
            this.label8.TabIndex = 108;
            this.label8.Text = "Artist Image";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(239, 229);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(300, 32);
            this.txtPhoneNo.TabIndex = 107;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(239, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 32);
            this.txtEmail.TabIndex = 106;
            // 
            // txtIdNo
            // 
            this.txtIdNo.Location = new System.Drawing.Point(239, 131);
            this.txtIdNo.Name = "txtIdNo";
            this.txtIdNo.Size = new System.Drawing.Size(300, 32);
            this.txtIdNo.TabIndex = 105;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(239, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 32);
            this.txtName.TabIndex = 104;
            // 
            // txtStageName
            // 
            this.txtStageName.Location = new System.Drawing.Point(239, 44);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.Size = new System.Drawing.Size(300, 32);
            this.txtStageName.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 26);
            this.label9.TabIndex = 102;
            this.label9.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 26);
            this.label10.TabIndex = 101;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 26);
            this.label11.TabIndex = 100;
            this.label11.Text = "ID No.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 26);
            this.label12.TabIndex = 99;
            this.label12.Text = "Name";
            // 
            // pctArt
            // 
            this.pctArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctArt.Location = new System.Drawing.Point(701, 44);
            this.pctArt.Name = "pctArt";
            this.pctArt.Size = new System.Drawing.Size(309, 157);
            this.pctArt.TabIndex = 98;
            this.pctArt.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 26);
            this.label13.TabIndex = 97;
            this.label13.Text = "Stage Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(64, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 308);
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
            this.artistImageDataGridViewImageColumn,
            this.artistAvailabilityStatusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.aRTISTBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(105, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(823, 190);
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
            this.textBox11.Location = new System.Drawing.Point(491, 31);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(395, 32);
            this.textBox11.TabIndex = 88;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(132, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 26);
            this.label14.TabIndex = 89;
            this.label14.Text = "Search Artist By Stage Name";
            // 
            // aRTISTTableAdapter
            // 
            this.aRTISTTableAdapter.ClearBeforeFill = true;
            // 
            // ViewVerified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 690);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewVerified";
            this.Text = "ViewVerified";
            this.Load += new System.EventHandler(this.ViewVerified_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctArt)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIdNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStageName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pctArt;
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
        private System.Windows.Forms.DataGridViewImageColumn artistImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistAvailabilityStatusDataGridViewTextBoxColumn;
    }
}