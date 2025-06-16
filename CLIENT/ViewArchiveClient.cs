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
    public partial class ViewArchiveClient : Form
    {
        public ViewArchiveClient()
        {
            InitializeComponent();
        }

        private void ViewArchiveClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paseOneDS.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.FillByArchived(this.paseOneDS.CLIENT);
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

                var ClientID = row.Cells[0].Value;
                var vname = row.Cells[1].Value;
                var vsurname = row.Cells[2].Value;
                var vemail = row.Cells[4].Value;
                var vphone = row.Cells[3].Value;



                if (ClientID != null && vname != null)
                {
                    string clientID = ClientID.ToString();
                    string clientName = vname.ToString();
                    string clientSurname = vsurname.ToString();
                    string clientEmail = vemail.ToString();
                    string clientPhone = vphone.ToString();

                    DialogResult result = MessageBox.Show(
                        $"You have selected \"{clientName}\". Do you want to confirm?",
                        "Confirm Selection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        txtName.Text = clientName;
                        txtSurn.Text = clientSurname;
                        txtPhoneNo.Text = clientPhone;
                        txtIdEmail.Text = clientEmail;
                    }
                }
            }
        }

     

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            cLIENTTableAdapter.SearchArchived(paseOneDS.CLIENT,textBox11.Text);
        }
    }
}
