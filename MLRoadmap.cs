using ASCENTRA;
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
    public partial class MLRoadmap : MetroFramework.Forms.MetroForm
    {
        public string UserInterest { get; set; }
        public Image ResultImage { get; set; }
        public MLRoadmap()
        {
            InitializeComponent();
        }

        private void btnmath_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Math is the foundation of ML \nfocus on linear algebra, calculus, and statistics.";
            youtubeLink.Text = "Watch Math for ML Tutorial";
            youtubeLink.Tag = "https://youtu.be/1VSZtNYMntM?si=IoAgU5r_xmP9uhLO";
        }

        private void btnpy_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Learn Python for Machine Learning —\n NumPy, Pandas, and Scikit-learn.";
            youtubeLink.Text = "Watch Python for ML Tutorial";
            youtubeLink.Tag = "https://youtu.be/7eh4d6sabA0?si=YToMDh3coM6v-4Zz";
        }

        private void btnDv_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Machine Learning teach computers to \nlearn patterns and make predictions from data.";
            youtubeLink.Text = "Watch Machine Learning Tutorial";
            youtubeLink.Tag = "https://youtu.be/JxgmHe2NyeY?si=OmdIXvdz91i6s_3b";

        }

        private void btnLR_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Deep Learning — neural networks \nthat learn hierarchical features from data.";
            youtubeLink.Text = "Watch Deep Learning Tutorial";
            youtubeLink.Tag = "https://youtu.be/d2kxUVwWWwU?si=JE8ihxmU_jZq4F36";

        }

        private void youtubeLink_Click(object sender, EventArgs e)
        {
            string url = youtubeLink.Tag?.ToString();
            if (!string.IsNullOrEmpty(url))
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("🎉 Congratulations! You’ve successfully completed the process.",
                   "Process Complete",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Show();
            this.Hide();

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
             
                UserInfoForm info = new UserInfoForm();
                info.ResultImage = ResultImage;      // image pass
                info.UserInterest = UserInterest;    // interest pass
                info.PreviousForm = "ML";        // roadmap identity pass
                info.Show();
                this.Hide();


        }
        private void MLRoadmap_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
