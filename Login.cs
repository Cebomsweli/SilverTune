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

namespace SilverTune
{
    public partial class Login : Form
    {
        private int imageIndex = 0;
        private List<Image> backgroundImages = new List<Image>();
        private Timer imageTimer = new Timer();

        public Login()
        {
            InitializeComponent();
            this.Load += Login_Load; // Attach the Load event
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Get the Downloads folder path
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";

            // Add image filenames from your Downloads folder
            string[] files = { "welcome.PNG","offer.PNG" }; 

            // Load images from Downloads
            foreach (string file in files)
            {
                string fullPath = Path.Combine(downloadsPath, file);
                if (File.Exists(fullPath))
                {
                    backgroundImages.Add(Image.FromFile(fullPath));
                }
            }

            // Start the timer only if we have images
            if (backgroundImages.Count > 0)
            {
                imageTimer.Interval = 4000; // 2 seconds
                imageTimer.Tick += ImageTimer_Tick;
                imageTimer.Start();
            }
            else
            {
                MessageBox.Show("No images found in Downloads folder.");
            }
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            // Set background image to the FlowLayoutPanel
            flowLayoutPanel1.BackgroundImage = backgroundImages[imageIndex];
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;

            // Move to next image
            imageIndex = (imageIndex + 1) % backgroundImages.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void label1_Click(object sender, EventArgs e)
        //{
        //    // Optional: any label click logic
        //}
    }
}
