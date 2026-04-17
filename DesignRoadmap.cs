using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCENTRA
{
    public partial class DesignRoadmap : MetroFramework.Forms.MetroForm
    {
        public string UserInterest { get; set; }
        public Image ResultImage { get; set; }
        public DesignRoadmap()
        {
            InitializeComponent();
        }

        private void fundamentalsBtn_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Learn the basics of graphic design — color theory, typography, and composition.";
            youtubeLink.Text = "Watch Fundamentals Tutorial";
            youtubeLink.Tag = "https://youtu.be/GQS7wPujL2k?si=UQolf-xkSn94dJ42";
        }
         private void toolsBtn_Click_1(object sender, EventArgs e)
        {
            infoLabel.Text = "Master essential tools like Photoshop, Illustrator, and Figma.";
            youtubeLink.Text = "Watch Tools Tutorial";
            youtubeLink.Tag = "https://youtu.be/ACjRxe4Kujs?si=fJyx1Nj-aiVDFoQe";
        }

        private void specializationBtn_Click_1(object sender, EventArgs e)
        {
            infoLabel.Text = "Choose your focus area: Branding, UI/UX, or Motion Graphics.";
            youtubeLink.Text = "Watch Specialization Tutorial";
            youtubeLink.Tag = "https://youtu.be/NeUEctMZ6_g?si=CXA-kW-3zJ1YMHmH";
        }

        private void portfolioBtn_Click_1(object sender, EventArgs e)
        {
            infoLabel.Text = "Build a creative portfolio showcasing your best design projects.";
            youtubeLink.Text = "Watch Portfolio Guide";
            youtubeLink.Tag = "https://youtu.be/yexYDOLAxcY?si=4ukLCtIeAWYLvnU7";
        }

        private void youtubeLink_linkClick(object sender, EventArgs e)
        {
            string url = youtubeLink.Tag?.ToString();
            if (!string.IsNullOrEmpty(url))
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true });

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            UserInfoForm info = new UserInfoForm();
            info.ResultImage = ResultImage;      // image pass
            info.UserInterest = UserInterest;    // interest pass
            info.PreviousForm = "Design";        // roadmap identity pass
            info.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UserInfoForm info = new UserInfoForm();
            info.PreviousForm = "Design";  // or Design, or ML
            info.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void DesignRoadmap_Load(object sender, EventArgs e)
        {

        }
        private void youtubeLink_Click(object sender, EventArgs e)
        {

        }

    } 
}