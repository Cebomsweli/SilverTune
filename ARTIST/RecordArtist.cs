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
    public partial class RecordArtist : Form
    {
        //My fields
        public string ArtistFirstName { get; set; }
        public string ArtistLastName { get; set; }
        public string ArtistStageName { get; set; }
        public string ArtistEmail { get; set; }
        public string ArtistIdentityNo { get; set; }
        public string ArtistPhoneNumber { get; set; }
        public string ArtistGenre { get; set; }
        public string ArtistStreetName { get; set; }
        public int ArtistStreetNumber { get; set; }
        public string ArtistCityName { get; set; }
        public string ArtistCountryName { get; set; }
        public int AristPostalCode { get; set; }
        public byte[] ArtistImage { get; set; } 
        public string ArtistAvailabilityStatus { get; set; }
        public RecordArtist()
        {
            InitializeComponent();
        }

        private void RecordArtist_Load(object sender, EventArgs e)
        {

        }

        private void imgBtn_Click(object sender, EventArgs e)
        {
            //Opens the file in files system.
            openFileDialog1.Filter = "All Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                txtImg.Text = openFileDialog1.FileName;
                artistSelected.Image = Image.FromFile(txtImg.Text);
            }

        }

        //Method to convvert the photo to bytes
        public byte[] ConvertPhoto()
        {
            MemoryStream stream = new MemoryStream();
            artistSelected.Image.Save(stream, artistSelected.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Assigning data to be stored to defined fields
            ArtistFirstName = artNameTxt.Text;
            ArtistLastName =artSurnTxt.Text;
            ArtistStageName =artStageNameTxt.Text;
            ArtistEmail =artEmailTxt.Text;
            ArtistIdentityNo =artIdNoTxt.Text;
            ArtistPhoneNumber =ArtPhoneNoTxt.Text;
            ArtistGenre =artGenTxt.Text;
            ArtistStreetName =artStreetNameTxt.Text;
            ArtistStreetNumber = Convert.ToInt32(artStreetNoTxt.Text);
            ArtistCityName = artCityTxt.Text;
            ArtistCountryName =artCountTxt.Text;
            AristPostalCode = Convert.ToInt32(artPostCodeTxt.Text);
            ArtistImage =ConvertPhoto();
            ArtistAvailabilityStatus = "Verified";


            DialogResult result = MessageBox.Show(
                                                    "Are you sure you want to save this artist's information?",
                                                    "Confirm Save",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question
                                                );

            if (result == DialogResult.Yes)
            {
                artistTableAdapter.Insert(ArtistFirstName, ArtistLastName, ArtistStageName, ArtistEmail, ArtistIdentityNo, ArtistPhoneNumber, ArtistGenre,
                    ArtistStreetName, ArtistStreetNumber, ArtistCityName, ArtistCountryName, AristPostalCode, ArtistImage, ArtistAvailabilityStatus);
                MessageBox.Show(
                                    "Artist saved successfully.\n\nNext step: Please go to the 'Record Artist Fees' section to complete the artist profile.",
                                    "Next Step",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
            }
            else
            {
                // Optionally notify user that action was cancelled
                MessageBox.Show("Artist record was not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
