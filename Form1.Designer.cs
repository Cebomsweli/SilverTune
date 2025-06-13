
namespace SilverTune
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sTAFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDCLIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWCLIENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATECLIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRCHIVECLIENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hOMEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.hOMEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hOMEToolStripMenuItem.Image")));
            this.hOMEToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(115, 34);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.sTAFFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(128, 638);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(128, 585);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 53);
            this.panel1.TabIndex = 2;
            // 
            // sTAFFToolStripMenuItem
            // 
            this.sTAFFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDCLIENTToolStripMenuItem,
            this.aRCHIVECLIENTSToolStripMenuItem,
            this.vIEWCLIENTSToolStripMenuItem,
            this.uPDATECLIENTToolStripMenuItem});
            this.sTAFFToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.sTAFFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sTAFFToolStripMenuItem.Image")));
            this.sTAFFToolStripMenuItem.Name = "sTAFFToolStripMenuItem";
            this.sTAFFToolStripMenuItem.Size = new System.Drawing.Size(115, 34);
            this.sTAFFToolStripMenuItem.Text = "CLIENTS";
            // 
            // aDDCLIENTToolStripMenuItem
            // 
            this.aDDCLIENTToolStripMenuItem.Name = "aDDCLIENTToolStripMenuItem";
            this.aDDCLIENTToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.aDDCLIENTToolStripMenuItem.Text = "ADD CLIENT";
            // 
            // vIEWCLIENTSToolStripMenuItem
            // 
            this.vIEWCLIENTSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vIEWCLIENTSToolStripMenuItem.Image")));
            this.vIEWCLIENTSToolStripMenuItem.Name = "vIEWCLIENTSToolStripMenuItem";
            this.vIEWCLIENTSToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.vIEWCLIENTSToolStripMenuItem.Text = "VIEW CLIENTS";
            // 
            // uPDATECLIENTToolStripMenuItem
            // 
            this.uPDATECLIENTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uPDATECLIENTToolStripMenuItem.Image")));
            this.uPDATECLIENTToolStripMenuItem.Name = "uPDATECLIENTToolStripMenuItem";
            this.uPDATECLIENTToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.uPDATECLIENTToolStripMenuItem.Text = "UPDATE CLIENTS";
            // 
            // aRCHIVECLIENTSToolStripMenuItem
            // 
            this.aRCHIVECLIENTSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aRCHIVECLIENTSToolStripMenuItem.Image")));
            this.aRCHIVECLIENTSToolStripMenuItem.Name = "aRCHIVECLIENTSToolStripMenuItem";
            this.aRCHIVECLIENTSToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.aRCHIVECLIENTSToolStripMenuItem.Text = "ARCHIVE CLIENTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(340, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "@ SilverTune All Rights Reserved";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTAFFToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem aDDCLIENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVECLIENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWCLIENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATECLIENTToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

