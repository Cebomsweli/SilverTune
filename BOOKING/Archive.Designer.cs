
namespace SilverTune.BOOKING
{
    partial class Archive
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
            this.upImgBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtBookNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEventLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingVenueTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTotalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paseOneDS = new SilverTune.paseOneDS();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.bOOKINGTableAdapter = new SilverTune.paseOneDSTableAdapters.BOOKINGTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1246, 629);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archive Booking";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.upImgBtn);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.txtBookNo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(64, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1063, 259);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirm Booking";
            // 
            // upImgBtn
            // 
            this.upImgBtn.BackColor = System.Drawing.Color.Green;
            this.upImgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.upImgBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upImgBtn.Location = new System.Drawing.Point(502, 183);
            this.upImgBtn.Name = "upImgBtn";
            this.upImgBtn.Size = new System.Drawing.Size(249, 35);
            this.upImgBtn.TabIndex = 110;
            this.upImgBtn.Text = "Archive Booking";
            this.upImgBtn.UseVisualStyleBackColor = false;
            this.upImgBtn.Click += new System.EventHandler(this.upImgBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(247, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 35);
            this.button3.TabIndex = 109;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(426, 118);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(300, 32);
            this.txtAmount.TabIndex = 108;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(426, 76);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(300, 32);
            this.txtDate.TabIndex = 107;
            // 
            // txtBookNo
            // 
            this.txtBookNo.Location = new System.Drawing.Point(426, 31);
            this.txtBookNo.Name = "txtBookNo";
            this.txtBookNo.Size = new System.Drawing.Size(300, 32);
            this.txtBookNo.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 26);
            this.label11.TabIndex = 105;
            this.label11.Text = "Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 26);
            this.label12.TabIndex = 104;
            this.label12.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 26);
            this.label13.TabIndex = 103;
            this.label13.Text = "Booking No.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Location = new System.Drawing.Point(64, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 321);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Booking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 91;
            this.label1.Text = "Search By Booking Number";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.artistIDDataGridViewTextBoxColumn,
            this.bookingEventDateDataGridViewTextBoxColumn,
            this.bookingEventLocationDataGridViewTextBoxColumn,
            this.bookingVenueTypeDataGridViewTextBoxColumn,
            this.bookingDurationDataGridViewTextBoxColumn,
            this.eventTimeDataGridViewTextBoxColumn,
            this.bookingTypeDataGridViewTextBoxColumn,
            this.bookingTotalAmountDataGridViewTextBoxColumn,
            this.bookingStatusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bOOKINGBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(70, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(910, 226);
            this.dataGridView2.TabIndex = 90;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            // 
            // bookingEventDateDataGridViewTextBoxColumn
            // 
            this.bookingEventDateDataGridViewTextBoxColumn.DataPropertyName = "BookingEventDate";
            this.bookingEventDateDataGridViewTextBoxColumn.HeaderText = "BookingEventDate";
            this.bookingEventDateDataGridViewTextBoxColumn.Name = "bookingEventDateDataGridViewTextBoxColumn";
            // 
            // bookingEventLocationDataGridViewTextBoxColumn
            // 
            this.bookingEventLocationDataGridViewTextBoxColumn.DataPropertyName = "BookingEventLocation";
            this.bookingEventLocationDataGridViewTextBoxColumn.HeaderText = "BookingEventLocation";
            this.bookingEventLocationDataGridViewTextBoxColumn.Name = "bookingEventLocationDataGridViewTextBoxColumn";
            // 
            // bookingVenueTypeDataGridViewTextBoxColumn
            // 
            this.bookingVenueTypeDataGridViewTextBoxColumn.DataPropertyName = "BookingVenueType";
            this.bookingVenueTypeDataGridViewTextBoxColumn.HeaderText = "BookingVenueType";
            this.bookingVenueTypeDataGridViewTextBoxColumn.Name = "bookingVenueTypeDataGridViewTextBoxColumn";
            // 
            // bookingDurationDataGridViewTextBoxColumn
            // 
            this.bookingDurationDataGridViewTextBoxColumn.DataPropertyName = "BookingDuration";
            this.bookingDurationDataGridViewTextBoxColumn.HeaderText = "BookingDuration";
            this.bookingDurationDataGridViewTextBoxColumn.Name = "bookingDurationDataGridViewTextBoxColumn";
            // 
            // eventTimeDataGridViewTextBoxColumn
            // 
            this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.HeaderText = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
            // 
            // bookingTypeDataGridViewTextBoxColumn
            // 
            this.bookingTypeDataGridViewTextBoxColumn.DataPropertyName = "BookingType";
            this.bookingTypeDataGridViewTextBoxColumn.HeaderText = "BookingType";
            this.bookingTypeDataGridViewTextBoxColumn.Name = "bookingTypeDataGridViewTextBoxColumn";
            // 
            // bookingTotalAmountDataGridViewTextBoxColumn
            // 
            this.bookingTotalAmountDataGridViewTextBoxColumn.DataPropertyName = "BookingTotalAmount";
            this.bookingTotalAmountDataGridViewTextBoxColumn.HeaderText = "BookingTotalAmount";
            this.bookingTotalAmountDataGridViewTextBoxColumn.Name = "bookingTotalAmountDataGridViewTextBoxColumn";
            // 
            // bookingStatusDataGridViewTextBoxColumn
            // 
            this.bookingStatusDataGridViewTextBoxColumn.DataPropertyName = "BookingStatus";
            this.bookingStatusDataGridViewTextBoxColumn.HeaderText = "BookingStatus";
            this.bookingStatusDataGridViewTextBoxColumn.Name = "bookingStatusDataGridViewTextBoxColumn";
            // 
            // bOOKINGBindingSource
            // 
            this.bOOKINGBindingSource.DataMember = "BOOKING";
            this.bOOKINGBindingSource.DataSource = this.paseOneDS;
            // 
            // paseOneDS
            // 
            this.paseOneDS.DataSetName = "paseOneDS";
            this.paseOneDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(483, 31);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(395, 32);
            this.textBox11.TabIndex = 88;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // bOOKINGTableAdapter
            // 
            this.bOOKINGTableAdapter.ClearBeforeFill = true;
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 629);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button upImgBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtBookNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label1;
        private paseOneDS paseOneDS;
        private System.Windows.Forms.BindingSource bOOKINGBindingSource;
        private paseOneDSTableAdapters.BOOKINGTableAdapter bOOKINGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEventLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingVenueTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingTotalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn;
    }
}