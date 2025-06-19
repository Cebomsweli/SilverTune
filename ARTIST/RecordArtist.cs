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

        //Object 
        ErrorHandler errorHandler = new ErrorHandler();
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

            //Verify the the textboxes
            if (!errorHandler.IsValidName(artNameTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid Name!");
            }
            else if (!errorHandler.IsValidName(artSurnTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid surname!");
            }
            else if (!errorHandler.IsValidName(artStageNameTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid stage name!");
            }
            else if (!errorHandler.ValidateEmail(artEmailTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid email!");
            }
            else if (!errorHandler.IsValidPhoneNumber(ArtPhoneNoTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid phone number!");
            }
            else if (!errorHandler.IsValidIDNumber(artIdNoTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid id number!");
            }
            else if (txtImg.Text== null )
            {
                MessageBox.Show("Please select the image!");
            }
            else if (artStreetNameTxt.Text == null || !errorHandler.IsValidName(artStreetNameTxt.Text))
            {
                MessageBox.Show("Please Enter The street name (e.g Dunstaple Height)!");

            }
            else if (artStreetNoTxt.Text == null || !errorHandler.isNumber(artStreetNoTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid street number (e.g 123)!");

            }
            else if (artCityTxt.Text == null || !errorHandler.IsValidName(artCityTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid city name (e.g Durban)!");
            }

            else if (artCountTxt.Text == null || !errorHandler.IsValidName(artCountTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid Country (e.g South Africa)!");
            }

            

            else if (artPostCodeTxt.Text == null || !errorHandler.isNumber(artPostCodeTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid postal code (e.g 4000)!");
            }

            else if (artStreetNoTxt.Text ==null)
            {
                MessageBox.Show("Enter the Valid Street number (e.g 123)");
            }
            else if (artistTableAdapter.CountExistingArtist(artStageNameTxt.Text, artEmailTxt.Text) >0)
            {
                MessageBox.Show("The Artist is already existing, you may proceed to booking!");
            }
            else
            {
                //Assigning data to be stored to defined fields
                ArtistFirstName = artNameTxt.Text;
                ArtistLastName = artSurnTxt.Text;
                ArtistStageName = artStageNameTxt.Text;
                ArtistEmail = artEmailTxt.Text;
                ArtistIdentityNo = artIdNoTxt.Text;
                ArtistPhoneNumber = ArtPhoneNoTxt.Text;
                ArtistGenre = artGenTxt.Text;
                ArtistStreetName = artStreetNameTxt.Text;
                ArtistStreetNumber = Convert.ToInt32(artStreetNoTxt.Text);
                AristPostalCode = Convert.ToInt32(artPostCodeTxt.Text);
                ArtistCityName = artCityTxt.Text;
                ArtistCountryName = artCountTxt.Text;
                ArtistImage = ConvertPhoto();
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
}
