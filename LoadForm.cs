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
   
    public partial class LoadForm : MetroFramework.Forms.MetroForm

    {
        int startPoint = 0;
        public LoadForm()
        {
            InitializeComponent();
        }

        private void strtbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Interval = 50; // adjust speed
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            progressBar1.Value = startPoint;

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
