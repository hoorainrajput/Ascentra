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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private string realPassword = "";
        private bool passwordVisible = false;

        public string UserName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }


        public LoginForm()
        {
            InitializeComponent();
          
            this.AutoScaleMode = AutoScaleMode.None;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PassBox.UseSystemPasswordChar = true;

            // set initial text on your eye button
            buttonEye.Text = "👁️";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel2.Parent = pictureBox1;
            
        }


        private void logbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameBox.Text))
            {
                MessageBox.Show("User Name is required!", "Validation ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserNameBox.Focus();
                return;
            }
            if (UserNameBox.Text == "Hoor" && realPassword == "1234")
            {
                UserForm f1 = new UserForm();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show(" username or password is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEye_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            passwordVisible = !passwordVisible;
 
            if (passwordVisible)
            {
                // Show actual password
                PassBox.UseSystemPasswordChar = false;
                PassBox.Text = realPassword;
                buttonEye.Text = "🙈"; // Change to "hide" icon
            }
            else
            {
                // Hide password with asterisks
                PassBox.UseSystemPasswordChar = true;
                PassBox.Text = new string('*', realPassword.Length);
                buttonEye.Text = "👁️"; // Change to "show" icon
            }

            // Restore cursor position and reattach event
            PassBox.SelectionStart = PassBox.Text.Length;
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            string aboutText =
           @"About Ascentra

At Ascentra, we believe every ambition deserves a clear direction.
Our mission is to guide students and professionals toward meaningful career paths through smart insights, intuitive tools, and personalized guidance.
With a focus on clarity, growth, and confidence, Ascentra helps you take the next step — not just with information, but with purpose.

Navigate your path. Shape your tomorrow.";

            MessageBox.Show(aboutText, "About Ascentra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
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


        private void PassBox_TextChanged_1(object sender, EventArgs e)
        {
            if (!passwordVisible)
            {
                // Track real password
                if (PassBox.Text.Length < realPassword.Length)
                {
                    realPassword = realPassword.Substring(0, PassBox.Text.Length);
                }
                else if (PassBox.Text.Length > realPassword.Length)
                {
                    realPassword += PassBox.Text.Substring(realPassword.Length);
                }

                PassBox.TextChanged -= PassBox_TextChanged_1;
                PassBox.Text = new string('*', realPassword.Length);
                PassBox.SelectionStart = realPassword.Length;
                PassBox.TextChanged += PassBox_TextChanged_1;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void UserNameBox_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}