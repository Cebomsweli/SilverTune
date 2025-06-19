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
        ErrorHandler errorHandler = new ErrorHandler();
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

        public string ArtistName = null;
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
                        ArtistName = artName.Text;
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
            //
            ClientType = typeCombo.Text;
            //Verify if the charges arlready exists or not.
            int countIndividual = Convert.ToInt32(artistfeesTableAdapter.CountIndividualFees(ArtistID));
            int countOrganisation = Convert.ToInt32(artistfeesTableAdapter.CountOrgFees(ArtistID));

            // Verify the the textboxes
            if (!errorHandler.IsValidName(artName.Text))
            {
                MessageBox.Show("Please Select the artist!");
            }
            else if (!errorHandler.isMoney(artChargeHour.Text))
            {
                MessageBox.Show("Please enter valid money/ digits!");
            }
            
           

            else if (countOrganisation > 0 && ClientType=="Organisation")
            {
                MessageBox.Show("Organisation fee for the artist is already recorded!");
            }

            else if (countIndividual > 0 && ClientType == "Individual")
            {
                MessageBox.Show("Individual fee for the artist is already recorded!");
            }
            

            else if(errorHandler.IsValidName(artName.Text) && errorHandler.isMoney(artChargeHour.Text) && countIndividual == 0 && countOrganisation == 0)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            aRTISTTableAdapter.FillByStageName(paseOneDS.ARTIST,textBox3.Text);
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientType = typeCombo.Text;
        }
    }
}
