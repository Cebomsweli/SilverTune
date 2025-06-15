using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverTune.BOOKING
{
    public partial class ArtistBooking : Form
    {
        //Fields to carry data
        public int ClientID { get; set; }
        public int ArtistID { get; set; }
        public string BookingEventDate { get; set; }
        public string BookingEventLocation { get; set; }
        public string time { get; set; }
        public string BookingVenueType { get; set; }
        public int BookingDuration { get; set; }
        public string BookingVenue { get; set; }
        public string BookingType { get; set; } 
        public decimal BookingTotalAmount { get; set; }
        public string BookingStatus { get; set; }
        public ArtistBooking()
        {
            InitializeComponent();
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeCombo.Text.Equals("Organisation"))
            {
                typeText.Visible = true;
                typeText.Visible = true;
            }
            else
            {
                typeText.Visible = false;
                typeText.Visible = false;
            }
        }

        private void ArtistBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paseOneDS.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.paseOneDS.CLIENT);
            // TODO: This line of code loads data into the 'paseOneDS.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.paseOneDS.CLIENT);
            // TODO: This line of code loads data into the 'paseOneDS.ARTIST' table. You can move, or remove it, as needed.
            this.aRTISTTableAdapter.Fill(this.paseOneDS.ARTIST);


            StyleDataGridView(dataGridView1);
            StyleDataGridView(dataGridView2);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void typeCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (typeCombo.Text.Equals("Organisation"))
            {
                typeText.Visible = true;
                
            }
            else
            {
                typeText.Visible = false;
               
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                var clientIdValue = row.Cells[0].Value;
                var clientNameValue = row.Cells[1].Value;
                var clientSurname = row.Cells[2].Value;
                var clientPhoneNo = row.Cells[3].Value;
                var clientEmail = row.Cells[4].Value;

                if (clientIdValue != null && clientNameValue != null )
                {
                    string clientId = clientIdValue.ToString();
                    string clientName = clientNameValue.ToString();
                    string srname = clientSurname.ToString();
                    string phoneNumber = clientPhoneNo.ToString();
                    string email = clientEmail.ToString();

                    DialogResult result = MessageBox.Show(
                        $"You have selected \"{clientName}\". Do you want to confirm?",
                        "Confirm Selection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Assign to class-level variable
                        int clientIdds = Convert.ToInt32(clientId);
                        clieNameTxt.Text = clientName;
                        clieEmailTxt.Text = email;
                        cliePhonTxt.Text = phoneNumber;
                        clieSurnTxt.Text = srname;
                        ClientID = clientIdds;
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
                        label4.Text = artistName;
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


            BookingEventDate = eventDateTxt.Text;
            BookingEventLocation = locTxt.Text;
            BookingVenueType = typeTxt.Text;
            BookingDuration =Convert.ToInt32( durCombo.Text);
            //BookingVenue =typeVenTxt.Text;
            BookingType = typeCombo.Text;
            BookingTotalAmount =0;
            time = txtTime.Text;
            TimeSpan timeSpan = TimeSpan.Parse(time);
            BookingStatus ="Successful";

            //assigning data tofields
            decimal total= Convert.ToDecimal( artistfeesTableAdapter.getFee(ArtistID,BookingType));
            BookingTotalAmount = total*BookingDuration;

           
            DialogResult result = MessageBox.Show(
                                                    "Are you sure you want to save this booking information?",
                                                    "Confirm Booking Save",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question
                                                );

            if (result == DialogResult.Yes)
            {
                // Insert the booking record
                bookingTableAdapter.Insert1(ClientID, ArtistID, BookingEventDate, BookingEventLocation, BookingEventLocation, BookingDuration, time, BookingType, BookingTotalAmount, BookingStatus);

                // Get Booking number
                int bookingNo = Convert.ToInt32(bookingTableAdapter.getBookingNumber(ArtistID, ClientID, BookingEventDate));

                // Prepare summary details (replace these variable names with your actual ones)
                string summary = $"Booking Number: {bookingNo}\n" +
                                 $"Event Date: {BookingEventDate}\n" +
                                 $"Event Location: {BookingEventLocation}\n" +
                                 $"Total Amount: {BookingTotalAmount:C}";

                MessageBox.Show(
                    $"Booking saved successfully!\n\nSummary:\n{summary}",
                    "Booking Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Booking was not saved.",
                    "Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

        }
    }
}
