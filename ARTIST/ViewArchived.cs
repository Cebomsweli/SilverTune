using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverTune.ARTIST
{
    public partial class ViewArchived : Form
    {
        //Filds to hold data
        public string StageName { get; set; }
        public string Name { get; set; }
        public string IDNO { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }


        public ViewArchived()
        {
            InitializeComponent();
        }

        private void ViewArchived_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paseOneDS.ARTIST' table. You can move, or remove it, as needed.
            this.aRTISTTableAdapter.FillByArchived(this.paseOneDS.ARTIST);
            StyleDataGridView(dataGridView2);
        }
        private void StyleDataGridView(DataGridView dgv)
        {
            // Use full row selection
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Remove the ugly row headers
            dgv.RowHeadersVisible = false;

            // Set alternating row colors for readability
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Set background and grid colors
            // Set background and grid line colors
            dgv.BackgroundColor = Color.FromArgb(64, 64, 64); // Entire grid background
            dgv.GridColor = Color.LightGray;

            // Header style
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32); // Even darker for contrast
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Cell style
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);  // Cell background (ControlDarkDark)
            dgv.DefaultCellStyle.ForeColor = Color.White;                 // White text
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 96, 96); // Slightly lighter on selection
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Optional: Alternate row style (if needed)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(70, 70, 70); // Slight variation for readability
            // Set default row style
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 120, 180);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Polishing
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add a borderless feel
            dgv.BorderStyle = BorderStyle.None;

            // Remove cell borders
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Disable editing (if it's for viewing only)
            dgv.ReadOnly = true;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            aRTISTTableAdapter.SearchArchived(paseOneDS.ARTIST, textBox11.Text);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                var artID = row.Cells[0].Value;
                var artistStageName = row.Cells[3].Value;
                var artistName = row.Cells[1].Value;
                var artEmail = row.Cells[4].Value;
                var artIdNo = row.Cells[5].Value;
                var artPhoneNo = row.Cells[6].Value;
             
                // ⬇️ Get image data from cell 7
                var imageData = row.Cells[7].Value;

                if (artID != null && artistStageName != null)
                {
                    string artistId = artID.ToString();
                    string stageName = artistStageName.ToString();
                    string srname = artistName.ToString();
                    string email = artEmail.ToString();
                    string idNo = artIdNo.ToString();
                    string phoneNo = artPhoneNo.ToString();

                    DialogResult result = MessageBox.Show(
                        $"You have selected \"{stageName}\". Do you want to confirm?",
                        "Confirm Selection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        int artistIdds = Convert.ToInt32(artistId);
                        txtStageName.Text = stageName;
                        txtName.Text = srname;
                        txtEmail.Text = email;
                        txtIdNo.Text = idNo;
                        txtPhoneNo.Text = phoneNo;
                        StageName = stageName;

                        // ✅ Load image to pictureBox1
                        if (imageData != DBNull.Value && imageData is byte[] imageBytes)
                        {
                            try
                            {
                                // Clear previous image
                                pctArt.Image?.Dispose();

                                // Load new image safely
                                MemoryStream ms = new MemoryStream(imageBytes);
                                Bitmap bmp = new Bitmap(ms);
                                pctArt.Image = new Bitmap(bmp); // create a new Bitmap instance
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Failed to load image: " + ex.Message);
                                pctArt.Image = null;
                            }
                        }
                        else
                        {
                            pctArt.Image = null; // no image
                        }

                    }
                }
            }

        }
    }
}
