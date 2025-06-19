using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverTune.ARTIST
{
    public partial class ArchiveArtist : Form
    {
        //Fields to hold data
        public int ArtistID { get; set; }
        public string StageName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public ArchiveArtist()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ArchiveArtist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paseOneDS.ARTIST' table. You can move, or remove it, as needed.
            this.aRTISTTableAdapter.Fill(this.paseOneDS.ARTIST);
            StyleDataGridView(dataGridView2);
        }
        //Method that designs the gridview
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
            dgv.BackgroundColor = Color.FromArgb(100, 149, 237); // Entire grid background
            dgv.GridColor = Color.FromArgb(100, 149, 237);

            // Header style
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32); // Even darker for contrast
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Cell style
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(100, 149, 237);  // Cell background (ControlDarkDark)
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
            aRTISTTableAdapter.FillByStageName(paseOneDS.ARTIST, textBox11.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        //Add to textboxes
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                var artID = row.Cells[0].Value;
                var artistStageName = row.Cells[3].Value;
                var artistSurname = row.Cells[2].Value;
                var artEmail = row.Cells[4].Value;

                if (artID != null && artistStageName != null)
                {
                    string artistId = artID.ToString();
                    string stageName = artistStageName.ToString();
                    string srname = artistSurname.ToString();
                    string email = artEmail.ToString();

                    DialogResult result = MessageBox.Show(
                        $"You have selected \"{stageName}\". Do you want to confirm?",
                        "Confirm Selection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Assign to class-level variable
                        
                        int artistIdds = Convert.ToInt32(artistId);
                        txtNNStageName.Text = stageName;
                        txtSurname.Text = srname;
                        txtEmail.Text = email;

                        ArtistID = artistIdds;
                        StageName = stageName;
                        // Testing ID
                        //MessageBox.Show($"Artist ID {ArtistID} confirmed.");
                    }
                    else
                    {
                        // User declined, do nothing or reset ArtistID if needed
                        // ArtistID = null; // optional
                    }
                }
            }
        }

        private void upImgBtn_Click(object sender, EventArgs e)
        {
            //Archiving artist

            if (ArtistID == 0)
            {
                MessageBox.Show("Please select the artist!");
            }
            else 
            {
                // Confirm archiving
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to archive artist '{StageName}'?",
                    "Confirm Archive",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Archive the artist (e.g., set status to "Archived")
                    aRTISTTableAdapter.ArchiveArtist("Archived", ArtistID, ArtistID);

                    // Show success summary
                    string summary = $"Artist '{StageName}' has been successfully archived.\n" +
                                     $"Archived Date: {DateTime.Now:d}";

                    MessageBox.Show(
                        $"Archive Complete!\n\n{summary}",
                        "Artist Archived",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    aRTISTTableAdapter.Fill(paseOneDS.ARTIST);
                }
                else
                {
                    MessageBox.Show(
                        "Archiving was cancelled.",
                        "Cancelled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            

        }
    }
}
