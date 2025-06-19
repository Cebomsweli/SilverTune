using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverTune.CLIENT
{
    public partial class ARchiveClient : Form
    {

        //Fields
        public int ClientIDF { get; set; }
        public string ClientName { get; set; }
        public ARchiveClient()
        {
            InitializeComponent();
        }

        private void ARchiveClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paseOneDS.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.paseOneDS.CLIENT);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                var ClientID = row.Cells[0].Value;
                var vname = row.Cells[1].Value;
                var vsurname = row.Cells[2].Value;
                var vemail = row.Cells[4].Value;
               
                if (ClientID != null && vname != null)
                {
                    string clientID = ClientID.ToString();
                    string clientName = vname.ToString();
                    string clientSurname = vsurname.ToString();
                    string clientEmail = vemail.ToString();
                   

                    DialogResult result = MessageBox.Show(
                        $"You have selected \"{clientName}\". Do you want to confirm?",
                        "Confirm Selection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        ClientIDF =Convert.ToInt32( clientID);
                        ClientName = clientName;
                        txtName.Text = clientName;
                        txtSurn.Text = clientSurname;
                        txtEmail.Text = clientEmail;
                    }
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            cLIENTTableAdapter.FillByClientName(paseOneDS.CLIENT,textBox11.Text);
        }

        private void upImgBtn_Click(object sender, EventArgs e)
        {
            if (ClientIDF==0)
            {
                MessageBox.Show("Please Select the client before proceeding!");
            }
            else
            {
                // Confirm archiving
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to archive client '{ClientName}'?",
                    "Confirm Archive",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Archive the artist (e.g., set status to "Archived")
                    cLIENTTableAdapter.ArchiveClient("Archived", ClientIDF, ClientIDF);

                    // Show success summary
                    string summary = $"Client '{ClientName}' has been successfully archived.\n" +
                                     $"Archived Date: {DateTime.Now:d}";

                    MessageBox.Show(
                        $"Archive Complete!\n\n{summary}",
                        "Artist Archived",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    cLIENTTableAdapter.Fill(paseOneDS.CLIENT);
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
