
namespace SilverTune.CLIENT
{
    partial class RecordClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clieStreetNameTxt = new System.Windows.Forms.TextBox();
            this.clieSStreetNoTxt = new System.Windows.Forms.TextBox();
            this.clieCityTxt = new System.Windows.Forms.TextBox();
            this.clieCountTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cliePostTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clieNameTxt = new System.Windows.Forms.TextBox();
            this.clieSurnTxt = new System.Windows.Forms.TextBox();
            this.cliePhonNoTxt = new System.Windows.Forms.TextBox();
            this.clieEmailTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clientTableAdapter = new SilverTune.paseOneDSTableAdapters.CLIENTTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1345, 695);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Client";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.clieStreetNameTxt);
            this.groupBox3.Controls.Add(this.clieSStreetNoTxt);
            this.groupBox3.Controls.Add(this.clieCityTxt);
            this.groupBox3.Controls.Add(this.clieCountTxt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cliePostTxt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(110, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1117, 330);
            this.groupBox3.TabIndex = 30;
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
            this.panel2.Location = new System.Drawing.Point(458, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 41);
            this.panel2.TabIndex = 112;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(404, 2);
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
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // clieStreetNameTxt
            // 
            this.clieStreetNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clieStreetNameTxt.Location = new System.Drawing.Point(474, 55);
            this.clieStreetNameTxt.Name = "clieStreetNameTxt";
            this.clieStreetNameTxt.Size = new System.Drawing.Size(283, 32);
            this.clieStreetNameTxt.TabIndex = 7;
            // 
            // clieSStreetNoTxt
            // 
            this.clieSStreetNoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clieSStreetNoTxt.Location = new System.Drawing.Point(474, 93);
            this.clieSStreetNoTxt.Name = "clieSStreetNoTxt";
            this.clieSStreetNoTxt.Size = new System.Drawing.Size(283, 32);
            this.clieSStreetNoTxt.TabIndex = 8;
            // 
            // clieCityTxt
            // 
            this.clieCityTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clieCityTxt.Location = new System.Drawing.Point(474, 131);
            this.clieCityTxt.Name = "clieCityTxt";
            this.clieCityTxt.Size = new System.Drawing.Size(283, 32);
            this.clieCityTxt.TabIndex = 9;
            // 
            // clieCountTxt
            // 
            this.clieCountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clieCountTxt.Location = new System.Drawing.Point(474, 169);
            this.clieCountTxt.Name = "clieCountTxt";
            this.clieCountTxt.Size = new System.Drawing.Size(283, 32);
            this.clieCountTxt.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 26);
            this.label13.TabIndex = 22;
            this.label13.Text = "Country Name";
            // 
            // cliePostTxt
            // 
            this.cliePostTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cliePostTxt.Location = new System.Drawing.Point(474, 207);
            this.cliePostTxt.Name = "cliePostTxt";
            this.cliePostTxt.Size = new System.Drawing.Size(283, 32);
            this.cliePostTxt.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 26);
            this.label12.TabIndex = 21;
            this.label12.Text = "Postal Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Street Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "City Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Street No.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.clieNameTxt);
            this.groupBox2.Controls.Add(this.clieSurnTxt);
            this.groupBox2.Controls.Add(this.cliePhonNoTxt);
            this.groupBox2.Controls.Add(this.clieEmailTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(104, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1117, 203);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Personal Details";
            // 
            // clieNameTxt
            // 
            this.clieNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clieNameTxt.Location = new System.Drawing.Point(474, 41);
            this.clieNameTxt.Name = "clieNameTxt";
            this.clieNameTxt.Size = new System.Drawing.Size(283, 32);
            this.clieNameTxt.TabIndex = 0;
            // 
            // clieSurnTxt
            // 
            this.clieSurnTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clieSurnTxt.Location = new System.Drawing.Point(474, 79);
            this.clieSurnTxt.Name = "clieSurnTxt";
            this.clieSurnTxt.Size = new System.Drawing.Size(283, 32);
            this.clieSurnTxt.TabIndex = 2;
            // 
            // cliePhonNoTxt
            // 
            this.cliePhonNoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cliePhonNoTxt.Location = new System.Drawing.Point(474, 117);
            this.cliePhonNoTxt.Name = "cliePhonNoTxt";
            this.cliePhonNoTxt.Size = new System.Drawing.Size(283, 32);
            this.cliePhonNoTxt.TabIndex = 4;
            // 
            // clieEmailTxt
            // 
            this.clieEmailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clieEmailTxt.Location = new System.Drawing.Point(474, 155);
            this.clieEmailTxt.Name = "clieEmailTxt";
            this.clieEmailTxt.Size = new System.Drawing.Size(283, 32);
            this.clieEmailTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phone No.";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // RecordClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 719);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RecordClient";
            this.Text = "RecordClient";
            this.Load += new System.EventHandler(this.RecordClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cliePostTxt;
        private System.Windows.Forms.TextBox clieCountTxt;
        private System.Windows.Forms.TextBox clieCityTxt;
        private System.Windows.Forms.TextBox clieSStreetNoTxt;
        private System.Windows.Forms.TextBox clieStreetNameTxt;
        private System.Windows.Forms.TextBox clieEmailTxt;
        private System.Windows.Forms.TextBox cliePhonNoTxt;
        private System.Windows.Forms.TextBox clieSurnTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clieNameTxt;
        private paseOneDSTableAdapters.CLIENTTableAdapter clientTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
    }
}