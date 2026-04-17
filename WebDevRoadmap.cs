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
    public partial class WebDevRoadmap : MetroFramework.Forms.MetroForm
    {
        public string UserInterest { get; set; }
        public Image ResultImage { get; set; }
        public WebDevRoadmap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInfoForm info = new UserInfoForm();
            info.PreviousForm = "WebDev";
            info.Show();
            this.Hide();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            MessageBox.Show("🎉 Congratulations! You’ve successfully completed the process.",
                   "Process Complete",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            UserInfoForm info = new UserInfoForm();
            info.ResultImage = ResultImage;      // image pass
            info.UserInterest = UserInterest;    // interest pass
            info.PreviousForm = "WebDev";        // roadmap identity pass
            info.Show();
            this.Hide();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Deployment is the final step —\n learn how to host, manage, and update your web applications efficiently.";
            youtubeLink.Text = "Watch Deployment Tutorial";
            youtubeLink.Tag = "https://youtu.be/gViEtIJ1DCw?si=fKiIJ3MPLihJuVXK";

        }

        private void btnBE_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Backend development handles logic and data —\n learn Node.js, databases, and APIs to power your web apps.";
            youtubeLink.Text = "Watch Backend Development Tutorial";
            youtubeLink.Tag = "https://youtu.be/7fjOw8ApZ1I?si=3H4PVHx0LYkxisC7";

        }

        private void btnFF_Click(object sender, EventArgs e)
        {

            infoLabel.Text = "Frontend development connects design with code —\n learn frameworks like React or Angular to build powerful UIs.";
            youtubeLink.Text = "Watch Frontend Development Tutorial";
            youtubeLink.Tag = "https://youtu.be/jgfq8OybWZQ?si=mTUDi6HwXh6hatim";
        }

        private void btnJS_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "JavaScript brings interactivity —\n DOM manipulation, events, and dynamic behavior.";
            youtubeLink.Text = "Watch JavaScript Tutorial";
            youtubeLink.Tag = "https://youtu.be/VlPiVmYuoqw?si=DhNwakwEMBYK7J5w";
        }

        private void btnCSS_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "CSS adds style to your websites — colors, layouts, and animations.";
            youtubeLink.Text = "Watch CSS Tutorial";
            youtubeLink.Tag = "https://youtu.be/ESnrn1kAD4E?si=z-cOUCIlK1MRxOBg";
        }

        private void btnhtml_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "HTML defines the structure of web pages.\n Learn about elements, tags, and semantic layout.";
            youtubeLink.Text = "Watch HTML Tutorial";
            youtubeLink.Tag = "https://youtu.be/HcOc7P5BMi4?si=meHjh5otqFdMBqdB";
        }

        private void youtubeLink_Click(object sender, EventArgs e)
        {

            string url = youtubeLink.Tag?.ToString();
            if (!string.IsNullOrEmpty(url))
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true });
        }
        private void WebDevRoadmap_Load(object sender, EventArgs e)
        {

        }

    }
}
