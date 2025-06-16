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
    public partial class UpdateClient : Form
    {
        //fields
        public int ClientID { get; set; }

        public UpdateClient()
        {
            InitializeComponent();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
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
            cLIENTTableAdapter.FillByClientName(paseOneDS.CLIENT,textBox11.Text);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                var vclieID = row.Cells[0].Value;
                var vmail = row.Cells[4].Value;
                var vphone = row.Cells[3].Value;
                var vname = row.Cells[1].Value;
                
                //  New address fields
                var streetName = row.Cells[5].Value;
                var streetNumber = row.Cells[6].Value;
                var city = row.Cells[7].Value;
                var country = row.Cells[8].Value;
                var postCode = row.Cells[9].Value;

                if (vclieID != null && vmail != null)
                {
                    string clieId = vclieID.ToString();
                    string name = vname.ToString();
                    string email = vmail.ToString();
                    string idNo = vclieID.ToString();
                    string phoneNo = vphone.ToString();

                    string strName = streetName?.ToString() ?? "";
                    string strNumber = streetNumber?.ToString() ?? "";
                    string strCity = city?.ToString() ?? "";
                    string strCountry = country?.ToString() ?? "";
                    string strPostCode = postCode?.ToString() ?? "";

                    DialogResult result = MessageBox.Show(
                        $"You have selected \"{name}\". Do you want to confirm?",
                        "Confirm Selection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        int artistIdds = Convert.ToInt32(clieId);
                        //txtStageName.Text = stageName;
                        //txtName.Text = srname;
                        ClientID = artistIdds;
                        txtEmail.Text = email;
                        //txtIdNo.Text = idNo;
                        txtPhonno.Text = phoneNo;

                        // 🏠 Address fields
                        txtStreetName.Text = strName;
                        txtStreetNumber.Text = strNumber;
                        txtCity.Text = strCity;
                        txtCountry.Text = strCountry;
                        txtPostCode.Text = strPostCode;

                        
                        
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //update email

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter an Email before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClientID == 0)
            {
                MessageBox.Show("Please select a valid Client before updating.", "Client Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the client's Email?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    cLIENTTableAdapter.UpdateEmail(txtEmail.Text, ClientID);
                    cLIENTTableAdapter.Fill(paseOneDS.CLIENT);

                    MessageBox.Show("Email updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Update canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhonno.Text))
            {
                MessageBox.Show("Please enter a cellphone number before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClientID == 0)
            {
                MessageBox.Show("Please select a valid client before updating.", "client Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the client's phone number?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    cLIENTTableAdapter.UpdatePhoneNumber(Convert.ToInt32( txtPhonno.Text), ClientID);
                    cLIENTTableAdapter.Fill(paseOneDS.CLIENT);

                    MessageBox.Show("Phone number updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Update canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStreetName.Text))
            {
                MessageBox.Show("Please enter a Street name before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClientID == 0)
            {
                MessageBox.Show("Please select a valid client before updating.", "client Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the client's Street name?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    cLIENTTableAdapter.UpdateStreetName(txtStreetName.Text, ClientID);
                    cLIENTTableAdapter.Fill(paseOneDS.CLIENT);

                    MessageBox.Show("Street name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Update canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStreetNumber.Text))
            {
                MessageBox.Show("Please enter a cellphone number before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClientID == 0)
            {
                MessageBox.Show("Please select a valid client before updating.", "client Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the client's Street number?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    cLIENTTableAdapter.UpdateStreetNumber(txtStreetNumber.Text, ClientID);
                    cLIENTTableAdapter.Fill(paseOneDS.CLIENT);

                    MessageBox.Show("Street number updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Update canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Please enter an City before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClientID == 0)
            {
                MessageBox.Show("Please select a valid client before updating.", "client Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the client's City?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    cLIENTTableAdapter.UpdateCityName(txtCity.Text, ClientID);
                    cLIENTTableAdapter.Fill(paseOneDS.CLIENT);

                    MessageBox.Show("City updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Update canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Please enter an City before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClientID == 0)
            {
                MessageBox.Show("Please select a valid client before updating.", "client Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the client's country?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    cLIENTTableAdapter.UpdateCountry(txtCountry.Text, ClientID);
                    cLIENTTableAdapter.Fill(paseOneDS.CLIENT);

                    MessageBox.Show("Country updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Update canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPostCode.Text))
            {
                MessageBox.Show("Please enter a postal code before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClientID == 0)
            {
                MessageBox.Show("Please select a valid client before updating.", "client Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the client's postal code?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    cLIENTTableAdapter.UpdatePostCode(Convert.ToInt32(txtPostCode.Text), ClientID);
                    cLIENTTableAdapter.Fill(paseOneDS.CLIENT);

                    MessageBox.Show("Postal code updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Update canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
