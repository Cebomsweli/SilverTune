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
    public partial class Archive : Form
    {

        //Booking number field
        public int BookingNo { get; set; }
        public Archive()
        {
            InitializeComponent();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paseOneDS.BOOKING' table. You can move, or remove it, as needed.
            this.bOOKINGTableAdapter.Fill(this.paseOneDS.BOOKING);
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

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bOOKINGTableAdapter.SearchBooking(paseOneDS.BOOKING, Convert.ToInt32(textBox11.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Enter a valid Booking Number!");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                var vbookId = row.Cells[0].Value;
           
                var vdate = row.Cells[3].Value;
                var vamount = row.Cells[9].Value;
                var vstatus = row.Cells[10].Value;


                if (vbookId != null && vamount != null)
                {
                    string bookid = vbookId.ToString();
                    string date = vdate.ToString();
                    string status = vstatus.ToString();
                    string amount = vamount.ToString();

                    DialogResult result = MessageBox.Show(
                        $"You have selected booking number\"{bookid}\". Do you want to confirm?",
                        "Confirm Selection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        BookingNo = Convert.ToInt32(bookid);
                        txtDate.Text = date;
                        txtAmount.Text = "R" + amount;
                        txtBookNo.Text = bookid;
                    }
                }
            }
        }

        private void upImgBtn_Click(object sender, EventArgs e)
        {
            // 1. Check if BookingNo is valid
            if (BookingNo == 0)
            {
                MessageBox.Show("Please select a valid booking before archiving.", "Invalid Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to archive this booking?",
                "Confirm Archive",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // 3. Proceed if confirmed
            if (result == DialogResult.Yes)
            {
                try
                {
                    bOOKINGTableAdapter.ArchiveBooking("Archived", BookingNo);
                    bOOKINGTableAdapter.Fill(paseOneDS.BOOKING);

                    MessageBox.Show("Booking archived successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while archiving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Archiving canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
