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
            //Assigning data to fields
            ClientFirstName =clieNameTxt.Text;
            ClientLastName=clieSurnTxt.Text;
            ClientPhoneNumber= Convert.ToInt32(cliePhonNoTxt.Text);
            ClientEmail=clieEmailTxt.Text;
            ClientStreetName=clieStreetNameTxt.Text;
            ClientStreetNumber=clieSStreetNoTxt.Text;
            ClientCityName=clieCityTxt.Text;
            ClientCountryName=clieCountTxt.Text;
            ClientPostalCode= Convert.ToInt32(cliePostTxt.Text);

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
                   ClientCityName, ClientCountryName, ClientPostalCode,"Verified");

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
}
