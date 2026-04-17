using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ASCENTRA
{
    public partial class UserForm : MetroFramework.Forms.MetroForm
    {
        public class UserData
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string Education { get; set; }
            public string Interest { get; set; }
        }
        public System.Drawing.Image ResultImage { get; set; }
        

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (ResultImage != null)
                pictureBox1.Image = ResultImage;
        }
        private bool ValidateUserData()
        {
            // 1. Name check
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 2. Age check (must be > 5)
            if (numAge.Value <= 5)
            {
                MessageBox.Show("Age must be greater than 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 3. Gender check
            if (string.IsNullOrWhiteSpace(combogender.Text))
            {
                MessageBox.Show("Please select your gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 4. Education check
            if (!radiobtnedu1.Checked && !radiobtnedu2.Checked && !radiobtnedu3.Checked)
            {
                MessageBox.Show("Please select your education level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // all good
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            if (!ValidateUserData()) return;

            string name = txtName.Text;
            int age = (int)numAge.Value;
            string gender = combogender.Text;
            string interest = txtInterest.Text;

            // Check which radio button is selected
            string education = "";
            if (radiobtnedu1.Checked)
                education = radiobtnedu1.Text;
            else if (radiobtnedu2.Checked)
                education = radiobtnedu2.Text;
            else if (radiobtnedu3.Checked)
                education = radiobtnedu3.Text;


            // Send data to UserInfoForm
            UserInfoForm infoForm = new UserInfoForm();
            infoForm.UserName = name;
            infoForm.UserAge = age;
            infoForm.UserGender = gender;
            infoForm.UserEducation = education;
            infoForm.UserInterest = interest;

            // optional: show or save the form
            MessageBox.Show("User data saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateUserData()) return;

            AppData.UserName = txtName.Text;
            AppData.UserAge = (int)numAge.Value;
            AppData.UserGender = combogender.Text;

            if (radiobtnedu1.Checked)
                AppData.UserEducation = radiobtnedu1.Text;
            else if (radiobtnedu2.Checked)
                AppData.UserEducation = radiobtnedu2.Text;
            else if (radiobtnedu3.Checked)
                AppData.UserEducation = radiobtnedu3.Text;

            AppData.UserInterest = txtInterest.Text;


            // Step 2: Go to quiz
            QuizForm quiz = new QuizForm ();
            quiz.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Do you want to exit?",
        "Confirm Exit",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }


        private void btnWeb_Click(object sender, EventArgs e)
        {
            // Validate first
            if (!ValidateUserData()) return;

            // AppData me save karo
            AppData.UserName = txtName.Text;
            AppData.UserAge = (int)numAge.Value;
            AppData.UserGender = combogender.Text;

            if (radiobtnedu1.Checked)
                AppData.UserEducation = radiobtnedu1.Text;
            else if (radiobtnedu2.Checked)
                AppData.UserEducation = radiobtnedu2.Text;
            else if (radiobtnedu3.Checked)
                AppData.UserEducation = radiobtnedu3.Text;

            AppData.UserInterest = txtInterest.Text;

            if (!ValidateUserData()) return;

            WebDevRoadmap web = new WebDevRoadmap();
            web.Show();
            this.Hide();
        }

        private void btnML_Click(object sender, EventArgs e)
        {
            // Validate first
            if (!ValidateUserData()) return;

            // AppData me save karo
            AppData.UserName = txtName.Text;
            AppData.UserAge = (int)numAge.Value;
            AppData.UserGender = combogender.Text;

            if (radiobtnedu1.Checked)
                AppData.UserEducation = radiobtnedu1.Text;
            else if (radiobtnedu2.Checked)
                AppData.UserEducation = radiobtnedu2.Text;
            else if (radiobtnedu3.Checked)
                AppData.UserEducation = radiobtnedu3.Text;

            AppData.UserInterest = txtInterest.Text;

            if (!ValidateUserData()) return;

            MLRoadmap ml = new MLRoadmap();
            ml.Show();
            this.Hide();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            // Validate first
            if (!ValidateUserData()) return;

            // AppData me save karo
            AppData.UserName = txtName.Text;
            AppData.UserAge = (int)numAge.Value;
            AppData.UserGender = combogender.Text;

            if (radiobtnedu1.Checked)
                AppData.UserEducation = radiobtnedu1.Text;
            else if (radiobtnedu2.Checked)
                AppData.UserEducation = radiobtnedu2.Text;
            else if (radiobtnedu3.Checked)
                AppData.UserEducation = radiobtnedu3.Text;

            AppData.UserInterest = txtInterest.Text;

            if (!ValidateUserData()) return;

            DesignRoadmap design = new DesignRoadmap();
            design.Show();
            this.Hide();
        }
        private void LoadUserData()
        { 
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtInterest_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
