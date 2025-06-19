using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

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
            if (true)
            {

            }

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

            //Preventing double booking
           // DateTime timeValue = Convert.ToDateTime(time);
            TimeSpan BookingStartTime = TimeSpan.Parse(time);
            DateTime BookingEventDates = DateTime.Parse(BookingEventDate);
            int conflict = CheckBookingConflict(ArtistID, BookingEventDates, BookingStartTime, BookingDuration);
            ErrorHandler errorHandler = new ErrorHandler();
            if (conflict > 0)
            {
                MessageBox.Show("This artist already has a booking around this time. Please choose another time.", "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // stop saving
            }
            else if (locTxt.Text == null)
            {
                MessageBox.Show("Please enter the event location before proceeding!");
            }
            else if (ArtistID==0 )
            {
                MessageBox.Show("Please search and select the artist before proceeding!");
            }
            else if (ClientID == 0)
            {
                MessageBox.Show("Please search and select the client before proceeding!");
            }
            else if (BookingTotalAmount==0)
            {
                MessageBox.Show("Please go to the artist and record the artist's fees!");
            }
            else if (Convert.ToInt32(artistfeesTableAdapter.getFee(ArtistID, "Organisation"))<=0)
            {
                MessageBox.Show("Please go to the artist and record the artist's organisation fees!");
            }
            else if (Convert.ToInt32(artistfeesTableAdapter.getFee(ArtistID, "Individual")) <= 0)
            {
                MessageBox.Show("Please go to the artist and record the artist's individual fees!");
            }
            else
            {
                // proceed to save booking
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

        //Prevents booking conflics
        private int CheckBookingConflict(int artistId, DateTime eventDate, TimeSpan eventTime, int duration)
        {
            int conflictCount = 0;
            string connectionString = ConfigurationHelper.GetConnectionString(); // ✅ using from appsettings.json

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("CheckArtistBookingConflict", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ArtistID", artistId);
                    cmd.Parameters.AddWithValue("@BookingEventDate", eventDate.Date);
                    cmd.Parameters.AddWithValue("@NewStartTime", eventTime);
                    cmd.Parameters.AddWithValue("@NewDuration", duration);

                    conn.Open();
                    object result = cmd.ExecuteScalar();   

                    if (result != null && int.TryParse(result.ToString(), out int count))
                        conflictCount = count;
                }
            }

            return conflictCount;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void locTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            aRTISTTableAdapter.FillByStageName(paseOneDS.ARTIST, textBox2.Text);
        }

        private void txtTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventDateTxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void durCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void typeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void typeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clieSearchTxt_TextChanged(object sender, EventArgs e)
        {
            cLIENTTableAdapter.FillByClientName(paseOneDS.CLIENT, clieSearchTxt.Text);
        }
    }
}
