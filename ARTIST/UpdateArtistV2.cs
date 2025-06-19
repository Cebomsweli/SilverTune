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
    public partial class UpdateArtistV2 : Form
    {
        //Fileds
        public int ArtistID { get; set; }
        public byte[] ArtistImage { get; set; }
        public UpdateArtistV2()
        {
            InitializeComponent();
        }

        private void UpdateArtistV2_Load(object sender, EventArgs e)
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

                var artID = row.Cells[0].Value;
                var artistStageName = row.Cells[3].Value;
                var artistName = row.Cells[1].Value;
                var artEmail = row.Cells[4].Value;
                var artIdNo = row.Cells[5].Value;
                var artPhoneNo = row.Cells[6].Value;
                var imageData = row.Cells[13].Value;

                // 🔽 New address fields
                var streetName = row.Cells[8].Value;
                var streetNumber = row.Cells[9].Value;
                var city = row.Cells[10].Value;
                var country = row.Cells[11].Value;
                var postCode = row.Cells[12].Value;

                if (artID != null && artistStageName != null)
                {
                    string artistId = artID.ToString();
                    string stageName = artistStageName.ToString();
                    string srname = artistName.ToString();
                    string email = artEmail.ToString();
                    string idNo = artIdNo.ToString();
                    string phoneNo = artPhoneNo.ToString();

                    string strName = streetName?.ToString() ?? "";
                    string strNumber = streetNumber?.ToString() ?? "";
                    string strCity = city?.ToString() ?? "";
                    string strCountry = country?.ToString() ?? "";
                    string strPostCode = postCode?.ToString() ?? "";

                    DialogResult result = MessageBox.Show(
                        $"You have selected \"{stageName}\". Do you want to confirm?",
                        "Confirm Selection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        int artistIdds = Convert.ToInt32(artistId);
                        //txtStageName.Text = stageName;
                        //txtName.Text = srname;
                        ArtistID = Convert.ToInt32(artistId);
                        txtEmail.Text = email;
                        //txtIdNo.Text = idNo;
                        txtPhone.Text = phoneNo;

                        // 🏠 Address fields
                        txtStreetName.Text = strName;
                        txtStreetNumber.Text = strNumber;
                        txtCity.Text = strCity;
                        txtCountry.Text = strCountry;
                        txtPostCode.Text = strPostCode;

                        // ✅ Load image
                        if (imageData != DBNull.Value && imageData is byte[] imageBytes)
                        {
                            try
                            {
                                pcArt.Image?.Dispose();
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    pcArt.Image = new Bitmap(ms);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Failed to load image: " + ex.Message);
                                pcArt.Image = null;
                            }
                        }
                        else
                        {
                            pcArt.Image = null;
                        }
                    }
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            aRTISTTableAdapter.FillByStageName(paseOneDS.ARTIST, textBox11.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Opens the file in files system.
            openFileDialog.Filter = "All Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                txtImg.Text = openFileDialog.FileName;
                pcArt.Image = Image.FromFile(txtImg.Text);
            }
        }

        //Method to convvert the photo to bytes
        public byte[] ConvertPhoto(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
                return null; // Or throw an exception if you prefer

            using (MemoryStream stream = new MemoryStream())
            {
                pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
                return stream.ToArray(); // Use ToArray() instead of GetBuffer()
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Please enter an City before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ArtistID == 0)
            {
                MessageBox.Show("Please select a valid artist before updating.", "Artist Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the artist's country?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    aRTISTTableAdapter.UpdateCountry(txtCountry.Text, ArtistID);
                    aRTISTTableAdapter.Fill(paseOneDS.ARTIST);

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

        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Please enter an City before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ArtistID == 0)
            {
                MessageBox.Show("Please select a valid artist before updating.", "Artist Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the artist's City?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    aRTISTTableAdapter.UpdateCityname(txtCity.Text, ArtistID);
                    aRTISTTableAdapter.Fill(paseOneDS.ARTIST);

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

        private void button9_Click(object sender, EventArgs e)
        {
            //update email
           
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Please enter an Email before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ArtistID == 0)
                {
                    MessageBox.Show("Please select a valid artist before updating.", "Artist Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ask for confirmation
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to update the artist's Email?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Perform the update
                        aRTISTTableAdapter.UpdateEmail(txtEmail.Text, ArtistID);
                        aRTISTTableAdapter.Fill(paseOneDS.ARTIST); 

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

        private void button8_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                MessageBox.Show("Please enter a cellphone number before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ArtistID == 0)
            {
                MessageBox.Show("Please select a valid artist before updating.", "Artist Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the artist's phone number?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    aRTISTTableAdapter.UpdatePhoneNumber(txtPhone.Text, ArtistID);
                    aRTISTTableAdapter.Fill(paseOneDS.ARTIST);

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStreetName.Text))
            {
                MessageBox.Show("Please enter a Street name before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ArtistID == 0)
            {
                MessageBox.Show("Please select a valid artist before updating.", "Artist Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the artist's Street name?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    aRTISTTableAdapter.UpdateStreetName(txtStreetName.Text, ArtistID);
                    aRTISTTableAdapter.Fill(paseOneDS.ARTIST);

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

            if (ArtistID == 0)
            {
                MessageBox.Show("Please select a valid artist before updating.", "Artist Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the artist's Street number?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    aRTISTTableAdapter.UpdateStreetNumber(Convert.ToInt32( txtStreetNumber.Text), ArtistID);
                    aRTISTTableAdapter.Fill(paseOneDS.ARTIST);

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

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPostCode.Text))
            {
                MessageBox.Show("Please enter a postal code before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ArtistID == 0)
            {
                MessageBox.Show("Please select a valid artist before updating.", "Artist Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the artist's postal code?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Perform the update
                    aRTISTTableAdapter.UpdatePostalCode(Convert.ToInt32( txtPostCode.Text), ArtistID);
                    aRTISTTableAdapter.Fill(paseOneDS.ARTIST);

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

        private void button3_Click(object sender, EventArgs e)
        {
            //Updates Artists image.
            ArtistImage = ConvertPhoto(pcArt);
            if (pcArt.Image == null)
            {
                MessageBox.Show("Please select or load an image before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ArtistID == 0)
            {
                MessageBox.Show("Please select a valid artist before updating.", "Artist Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to update the artist's image?",
                "Confirm Image Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Convert image to byte[]
                    byte[] imageData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                       
                        pcArt.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        pcArt.SizeMode = PictureBoxSizeMode.StretchImage;
                        imageData = ms.ToArray();
                    }

                    // Perform update
                    aRTISTTableAdapter.UpdateImage(imageData, ArtistID);
                    aRTISTTableAdapter.Fill(paseOneDS.ARTIST); // Refresh grid

                    MessageBox.Show("Image updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Image update canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
