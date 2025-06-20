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
    public partial class RecordClient : Form
    {
        ErrorHandler errorHandler = new ErrorHandler();
        //Fields to capture data
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }

        // Changed to string in case phone numbers start with 0 or include country codes
        public int ClientPhoneNumber { get; set; }

        public string ClientEmail { get; set; }
        public string ClientStreetName { get; set; }
        public string ClientStreetNumber { get; set; }  // varchar in SQL, so string here
        public string ClientCityName { get; set; }
        public string ClientCountryName { get; set; }
        public int ClientPostalCode { get; set; }

        public RecordClient()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Country "+ clieCountTxt.Text);
            //Verifying textBoxes
            //Verify the the textboxes
            if (!errorHandler.IsValidName(clieNameTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid Name!");
            }
            else if (!errorHandler.IsValidName(clieSurnTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid surname!");
            }
            
            else if (!errorHandler.ValidateEmail(clieEmailTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid email!");
            }
            else if (!errorHandler.IsValidPhoneNumber(cliePhonNoTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid phone number!");
            }

            //Address
            else if (clieStreetNameTxt.Text == null || !errorHandler.IsValidName(clieStreetNameTxt.Text))
            {
                MessageBox.Show("Please Enter The street name (e.g Dunstaple Height)!");

            }
            else if (clieSStreetNoTxt.Text == null || !errorHandler.isNumber(clieSStreetNoTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid street number (e.g 123)!");

            }
            else if (clieCityTxt.Text == null || !errorHandler.IsValidName(clieCityTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid city name (e.g Durban)!");
            }

            else if (clieCountTxt.Text == null || !errorHandler.IsValidCountryName(clieCountTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid Country (e.g South Africa)!");
            }

            else if (cliePostTxt.Text == null ||!errorHandler.isNumber(cliePostTxt.Text))
            {
                MessageBox.Show("Please Enter The Valid postal code (e.g 4000)!");
            }

            else if (clieSStreetNoTxt.Text == null)
            {
                MessageBox.Show("Enter the Valid Street number (e.g 123)");
            }else if (clientTableAdapter.countExistingClient(clieNameTxt.Text, clieEmailTxt.Text)>0)
            {
                MessageBox.Show("The client is already existing, you may procced to booking!");
            }
            else
            {
                //Assigning data to fields
                ClientFirstName = clieNameTxt.Text;
                ClientLastName = clieSurnTxt.Text;
                ClientPhoneNumber = Convert.ToInt32(cliePhonNoTxt.Text);
                ClientEmail = clieEmailTxt.Text;
                ClientStreetName = clieStreetNameTxt.Text;
                ClientStreetNumber = clieSStreetNoTxt.Text;
                ClientCityName = clieCityTxt.Text;
                ClientCountryName = clieCountTxt.Text;
                ClientPostalCode = Convert.ToInt32(cliePostTxt.Text);

                //Recording client
                DialogResult result = MessageBox.Show(
                                                "Are you sure you want to save this client information?",
                                                "Confirm Save",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question
                                            );

                if (result == DialogResult.Yes)
                {
                    clientTableAdapter.Insert(ClientFirstName, ClientLastName, ClientPhoneNumber, ClientEmail, ClientStreetName, ClientStreetNumber,
                       ClientCityName, ClientCountryName, ClientPostalCode, "Verified");

                    // Notify user
                    MessageBox.Show(
                        "Client saved successfully.\n\nYou can now continue to make bookings or view clients.",
                        "Client Added",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show("Client information was not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }






            
        }

        private void RecordClient_Load(object sender, EventArgs e)
        {

        }
    }
}
