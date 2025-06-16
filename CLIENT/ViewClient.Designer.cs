
namespace SilverTune.CLIENT
{
    partial class ViewClient
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
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtIdEmail = new System.Windows.Forms.TextBox();
            this.txtSurn = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientStreetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientStreetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCountryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paseOneDS = new SilverTune.paseOneDS();
            this.cLIENTTableAdapter = new SilverTune.paseOneDSTableAdapters.CLIENTTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1260, 653);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Verified Clients";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPhoneNo);
            this.groupBox3.Controls.Add(this.txtIdEmail);
            this.groupBox3.Controls.Add(this.txtSurn);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(64, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1063, 272);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Client Details";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(465, 191);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(300, 32);
            this.txtPhoneNo.TabIndex = 105;
            // 
            // txtIdEmail
            // 
            this.txtIdEmail.Location = new System.Drawing.Point(465, 153);
            this.txtIdEmail.Name = "txtIdEmail";
            this.txtIdEmail.Size = new System.Drawing.Size(300, 32);
            this.txtIdEmail.TabIndex = 103;
            // 
            // txtSurn
            // 
            this.txtSurn.Location = new System.Drawing.Point(465, 111);
            this.txtSurn.Name = "txtSurn";
            this.txtSurn.Size = new System.Drawing.Size(300, 32);
            this.txtSurn.TabIndex = 102;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(465, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 32);
            this.txtName.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 26);
            this.label9.TabIndex = 100;
            this.label9.Text = "Phone Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 26);
            this.label11.TabIndex = 98;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 26);
            this.label12.TabIndex = 97;
            this.label12.Text = "Surname";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 26);
            this.label13.TabIndex = 96;
            this.label13.Text = "Name";
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
            this.groupBox2.Text = "Search Client";
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
            this.clientStreetNameDataGridViewTextBoxColumn,
            this.clientStreetNumberDataGridViewTextBoxColumn,
            this.clientCityNameDataGridViewTextBoxColumn,
            this.clientCountryNameDataGridViewTextBoxColumn,
            this.clientPostalCodeDataGridViewTextBoxColumn,
            this.clientStatusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cLIENTBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(105, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(823, 190);
            this.dataGridView2.TabIndex = 90;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
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
            this.label14.Size = new System.Drawing.Size(240, 26);
            this.label14.TabIndex = 89;
            this.label14.Text = "Search Client By Name";
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
            // clientStreetNameDataGridViewTextBoxColumn
            // 
            this.clientStreetNameDataGridViewTextBoxColumn.DataPropertyName = "ClientStreetName";
            this.clientStreetNameDataGridViewTextBoxColumn.HeaderText = "ClientStreetName";
            this.clientStreetNameDataGridViewTextBoxColumn.Name = "clientStreetNameDataGridViewTextBoxColumn";
            // 
            // clientStreetNumberDataGridViewTextBoxColumn
            // 
            this.clientStreetNumberDataGridViewTextBoxColumn.DataPropertyName = "ClientStreetNumber";
            this.clientStreetNumberDataGridViewTextBoxColumn.HeaderText = "ClientStreetNumber";
            this.clientStreetNumberDataGridViewTextBoxColumn.Name = "clientStreetNumberDataGridViewTextBoxColumn";
            // 
            // clientCityNameDataGridViewTextBoxColumn
            // 
            this.clientCityNameDataGridViewTextBoxColumn.DataPropertyName = "ClientCityName";
            this.clientCityNameDataGridViewTextBoxColumn.HeaderText = "ClientCityName";
            this.clientCityNameDataGridViewTextBoxColumn.Name = "clientCityNameDataGridViewTextBoxColumn";
            // 
            // clientCountryNameDataGridViewTextBoxColumn
            // 
            this.clientCountryNameDataGridViewTextBoxColumn.DataPropertyName = "ClientCountryName";
            this.clientCountryNameDataGridViewTextBoxColumn.HeaderText = "ClientCountryName";
            this.clientCountryNameDataGridViewTextBoxColumn.Name = "clientCountryNameDataGridViewTextBoxColumn";
            // 
            // clientPostalCodeDataGridViewTextBoxColumn
            // 
            this.clientPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ClientPostalCode";
            this.clientPostalCodeDataGridViewTextBoxColumn.HeaderText = "ClientPostalCode";
            this.clientPostalCodeDataGridViewTextBoxColumn.Name = "clientPostalCodeDataGridViewTextBoxColumn";
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
            // paseOneDS
            // 
            this.paseOneDS.DataSetName = "paseOneDS";
            this.paseOneDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // ViewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 653);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewClient";
            this.Text = "ViewClient";
            this.Load += new System.EventHandler(this.ViewClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtIdEmail;
        private System.Windows.Forms.TextBox txtSurn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private paseOneDS paseOneDS;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private paseOneDSTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientStreetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientStreetNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCountryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientStatusDataGridViewTextBoxColumn;
    }
}