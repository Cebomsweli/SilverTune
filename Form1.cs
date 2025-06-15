using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverTune
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        //Enables the forms to be shown within parent form
        public void FormSetup(Form myForm)
        {
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Close();
            }

            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }
       

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOME.HomePage home = new HOME.HomePage();
            FormSetup(home);
        }

        private void aDDCLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLIENT.RecordClient recordClient = new CLIENT.RecordClient();
            FormSetup(recordClient);
        }

        private void rECORDARTISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ARTIST.RecordArtist recordArtist = new ARTIST.RecordArtist();
            FormSetup(recordArtist);
        }

        private void rECORDBOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BOOKING.ArtistBooking artistBooking = new BOOKING.ArtistBooking();
            FormSetup(artistBooking);
        }

        private void rECORDDJCHARGESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ARTIST.RecordCarges recordCarges = new ARTIST.RecordCarges();
            FormSetup(recordCarges);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            HOME.HomePage homePage = new HOME.HomePage();
            FormSetup(homePage);

        }
    }
}
