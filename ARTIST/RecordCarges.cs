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
    public partial class RecordCarges : Form
    {
        //Fields for capturing data
        public int ArtistID { get; set; }
        public string ClientType { get; set; }
        public decimal RateAmountPerHour { get; set; }

        public RecordCarges()
        {
            InitializeComponent();
        }

        private void RecordCarges_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paseOneDS.ARTIST' table. You can move, or remove it, as needed.
            this.aRTISTTableAdapter.Fill(this.paseOneDS.ARTIST);

            // Make the DataGridView fill the parent panel/form
            // dataGridView1.Dock = DockStyle.Fill;

            StyleDataGridView(dataGridView1);




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                var artistIdValue = row.Cells[0].Value;
                var artistNameValue = row.Cells[1].Value;

                if (artistIdValue != null && artistNameValue != null)
                {
                    string artistId = artistIdValue.ToString();
                    string artistName = artistNameValue.ToString();

                    DialogResult result = MessageBox.Show(
                        $"You have selected \"{artistName}\". Do you want to confirm?",
                        "Confirm Selection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Assign to class-level variable
                        ArtistID = Convert.ToInt32(artistId);
                        artName.Text = artistName;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClientType = typeCombo.Text;
            RateAmountPerHour = Convert.ToInt32(artChargeHour.Text);

                                DialogResult result = MessageBox.Show(
                        "Are you sure you want to save this artist's information?",
                        "Confirm Save",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

            if (result == DialogResult.Yes)
            {


                // Save artist fees (charges per hour)
                artistfeesTableAdapter.Insert(ArtistID, ClientType, RateAmountPerHour);

                // Confirmation message
                MessageBox.Show(
                    "Artist profile completed successfully.",
                    "Profile Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Artist record was not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           


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
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;

            // Customize column headers
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(54, 78, 114); // Deep blue
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

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
    }
}
