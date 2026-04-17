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
    public partial class QuizForm : MetroFramework.Forms.MetroForm
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserGender { get; set; }
        public string UserEducation { get; set; }

        public string UserInterest { get; set; }
        public Image ResultImage { get; set; }


        // Properties to pass forward
       

        public QuizForm()
        {
            InitializeComponent();
        }


        private void btnViewResult_Click(object sender, EventArgs e)
        {

            int webDevScore = 0;
            int mlScore = 0;
            int designScore = 0;

            // Question 1
            if (rbtnQ1_Web.Checked) webDevScore++;
            else if (rbtnQ1_ML.Checked) mlScore++;
            else if (rbtnQ1_Design.Checked) designScore++;

            // Question 2
            if (rbtnQ2_Web.Checked) webDevScore++;
            else if (rbtnQ2_ML.Checked) mlScore++;
            else if (rbtnQ2_Design.Checked) designScore++;

            // Question 3
            if (rbtnQ3_Web.Checked) webDevScore++;
            else if (rbtnQ3_ML.Checked) mlScore++;
            else if (rbtnQ3_Design.Checked) designScore++;

            // Question 4
            if (rbtnQ4_Web.Checked) webDevScore++;
            else if (rbtnQ4_ML.Checked) mlScore++;
            else if (rbtnQ4_Design.Checked) designScore++;

            // Question 5
            if (rbtnQ5_Web.Checked) webDevScore++;
            else if (rbtnQ5_ML.Checked) mlScore++;
            else if (rbtnQ5_Design.Checked) designScore++;

            // Question 6
            if (rbtnQ6_Web.Checked) webDevScore++;
            else if (rbtnQ6_ML.Checked) mlScore++;
            else if (rbtnQ6_Design.Checked) designScore++;

            string basePath = @"C:\Users\HP\source\repos\PathPilot\PathPilot\Resources\";
            string imagePath = "";
            string resultText = "";

            // Decide result

            if (webDevScore > mlScore && webDevScore > designScore)
            {
                resultText = "Web Development!";
                imagePath = basePath + "web.png";
            }
            else if (mlScore > webDevScore && mlScore > designScore)
            {
                resultText = "Machine Learning!";
                imagePath = basePath + "ml.png";
            }
            else if (designScore > webDevScore && designScore > mlScore)
            {
                resultText = "Graphic Design!";
                imagePath = basePath + "design.png";
            }
            else
            {
                resultText = "You have a mix of interests!";
                imagePath = basePath + "mix.png";
               
            }
            // Show result text
            lblResult.Text = resultText;

            // Show result image
            if (System.IO.File.Exists(imagePath))
            {
                picResult.Image = Image.FromFile(imagePath);
                picResult.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                lblResult.Text += "\n(Image not found)";
            }

            AppData.UserInterest = lblResult.Text;
            AppData.ResultCategory = lblResult.Text;
            // Move to result tab
            tabControl1.SelectedIndex = 6;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Contains("Web Development"))
            {
                WD webForm = new WD();
                webForm.Show();
                this.Hide();

            }
            else if (lblResult.Text.Contains("Machine Learning"))
            {
                MLRoadmap mlForm = new MLRoadmap();
                mlForm.Show();
                this.Hide();
            }
            else if (lblResult.Text.Contains("Graphic Design"))
            {
                DesignRoadmap design = new DesignRoadmap();
                design.UserInterest = "Graphic Design";
             
                design.Show();
                this.Hide();
            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void rbtnQ6_Web_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex -= 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Contains("Web Development"))
            {
                WebDevRoadmap webForm = new WebDevRoadmap();
                webForm.Show();
                
            }
            else if (lblResult.Text.Contains("Machine Learning"))
            {
                MLRoadmap mlForm = new MLRoadmap();
                mlForm.Show();
                
            }
            else if (lblResult.Text.Contains("Graphic Design"))
            {
                DesignRoadmap designForm = new DesignRoadmap();
                designForm.Show();
                
            }
            else if (lblResult.Text.Contains("Mix"))
            {
                MessageBox.Show(
   "Feeling confused about your career?\nDon't worry! You can check out the YouTube channel 'CareerVibes' — \nit shares great guidance and real-world advice for students.",
   "Career Suggestion",
   MessageBoxButtons.OK,
   MessageBoxIcon.Information);

            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void QuizForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Q1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rbtnQ1_Web_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ1_ML_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbtnQ2_Web_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ2_ML_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ2_Design_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void rbtnQ3_Web_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ3_ML_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ3_Design_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void rbtnQ4_Web_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ4_ML_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ4_Design_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void rbtnQ5_Web_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ5_ML_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ5_Design_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q6_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void rbtnQ6_Web_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rbtnQ6_ML_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ6_Design_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void picResult_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

