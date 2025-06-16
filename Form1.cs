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

        private void vIEWARTISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void uPDATEARTISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ARTIST.UpdateArtistV2 updateArtist = new ARTIST.UpdateArtistV2();
            FormSetup(updateArtist);
        }

        private void aRCHIVEARTISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ARTIST.ArchiveArtist archiveStatus = new ARTIST.ArchiveArtist();
            FormSetup(archiveStatus);
        }

        private void aRCHIVECLIENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLIENT.ARchiveClient aRchiveClient = new CLIENT.ARchiveClient();
            FormSetup(aRchiveClient);
        }

        private void uPDATECLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLIENT.UpdateClient updateClient = new CLIENT.UpdateClient();
            FormSetup(updateClient);
        }

        private void vIEWCLIENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vIEWBOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aRCHIVEBOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BOOKING.Archive archive = new BOOKING.Archive();
            FormSetup(archive);
        }

        private void sTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vIEWARCHIVEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BOOKING.ViewArchived viewArchived = new BOOKING.ViewArchived();
            FormSetup(viewArchived);
        }

        private void vIEWEXISTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BOOKING.ViewBookings viewBookings = new BOOKING.ViewBookings();
            FormSetup(viewBookings);
        }

        private void vIEWVERIFIEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ARTIST.ViewVerified viewVerified = new ARTIST.ViewVerified();
            FormSetup(viewVerified);
        }

        private void vIEWARCHIVEDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ARTIST.ViewArchived viewArchived = new ARTIST.ViewArchived();
            FormSetup(viewArchived);
        }

        private void vIEWARCHIVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLIENT.ViewArchiveClient viewArchiveClient = new CLIENT.ViewArchiveClient();
            FormSetup(viewArchiveClient);
        }

        private void vIEWEXISTINGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CLIENT.ViewClient viewClient = new CLIENT.ViewClient();
            FormSetup(viewClient);
        }
    }
}
