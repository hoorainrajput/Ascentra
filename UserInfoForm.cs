using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ASCENTRA
{
    public partial class UserInfoForm : MetroFramework.Forms.MetroForm
    {
        public string UserInterest { get; set; }
        public Image ResultImage { get; set; }
        public string PreviousForm { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserGender { get; set; }
        public string UserEducation { get; set; }

        string connectionString = "Data Source=HOOR-AIN\\SQLEXPRESS;Initial Catalog=AscentraDB;Integrated Security=True;";
        int selectedId = -1;

        public UserInfoForm()
        {
            InitializeComponent();

        }
        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            // Autofill from AppData if available
            txtName.Text = AppData.UserName;
            txtInterest.Text = AppData.UserInterest;
            combogender.Text = AppData.UserGender;
            if (AppData.UserAge > 8) numAge.Value = AppData.UserAge;

            if (!string.IsNullOrEmpty(AppData.UserEducation))
            {
                if (AppData.UserEducation == radiobtnedu1.Text) radiobtnedu1.Checked = true;
                else if (AppData.UserEducation == radiobtnedu2.Text) radiobtnedu2.Checked = true;
                else if (AppData.UserEducation == radiobtnedu3.Text) radiobtnedu3.Checked = true;
            }

            // Image logic
            string basePath = @"C:\Users\HP\source\repos\PathPilot\PathPilot\Resources\";
            string interestText = AppData.UserInterest ?? "";
            string imageFile = "";

            if (interestText.Contains("Web Development"))
                imageFile = "web.png";
            else if (interestText.Contains("Machine Learning"))
                imageFile = "ml.png";
            else if (interestText.Contains("Graphic Design"))
                imageFile = "design.png";
            else
                imageFile = "mix.png";

            string fullImagePath = Path.Combine(basePath, imageFile);

            if (!string.IsNullOrEmpty(imageFile) && File.Exists(fullImagePath))
            {
                try
                {
                    picResult.Image = Image.FromFile(fullImagePath);
                    picResult.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                }
            }

            txtInterest.Text = interestText;
        }
        private void LoadUserData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM UserInfo", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {

            {
                // Input validation
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a valid name.");
                    return;
                }


                string education = AppData.UserEducation;
                if (string.IsNullOrWhiteSpace(education))
                {
                    if (radiobtnedu1.Checked) education = radiobtnedu1.Text;
                    else if (radiobtnedu2.Checked) education = radiobtnedu2.Text;
                    else if (radiobtnedu3.Checked) education = radiobtnedu3.Text;
                }

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = @"INSERT INTO UserInfo 
                                (Name, Age, Gender, Education, Interest)
                             VALUES (@Name, @Age, @Gender, @Education, @Interest)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(numAge.Value));
                            cmd.Parameters.AddWithValue("@Gender", combogender.Text);
                            cmd.Parameters.AddWithValue("@Education", education);
                            cmd.Parameters.AddWithValue("@Interest", txtInterest.Text);

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }


                        MessageBox.Show("User data added successfully!");
                        LoadUserData();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
            }
        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (PreviousForm == "WebDev")
            {
                WebDevRoadmap web = new WebDevRoadmap();
                web.Show();
            }
            else if (PreviousForm == "Design")
            {
                DesignRoadmap design = new DesignRoadmap();
                design.Show();
            }
            else if (PreviousForm == "ML")
            {
                MLRoadmap ml = new MLRoadmap();
                ml.Show();
            }
            else
            {
                UserForm user = new UserForm();
                user.Show();
            }
        }
        private void btbdltdb_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM UserInfo WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", selectedId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record deleted successfully!");
                LoadUserData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtInterest.Clear();
            combogender.SelectedIndex = -1;
            numAge.Value = 0;
            radiobtnedu1.Checked = radiobtnedu2.Checked = radiobtnedu3.Checked = false;
            selectedId = -1;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            try
            {
                string education = "";
                if (radiobtnedu1.Checked)
                    education = radiobtnedu1.Text;
                else if (radiobtnedu2.Checked)
                    education = radiobtnedu2.Text;
                else if (radiobtnedu3.Checked)
                    education = radiobtnedu3.Text;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE UserInfo 
                                     SET Name=@Name, Age=@Age, Gender=@Gender, Education=@Education, Interest=@Interest 
                                     WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", selectedId);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", numAge.Value);
                    cmd.Parameters.AddWithValue("@Gender", combogender.Text);
                    cmd.Parameters.AddWithValue("@Education", education);
                    cmd.Parameters.AddWithValue("@Interest", txtInterest.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record updated successfully!");
                LoadUserData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                numAge.Value = Convert.ToInt32(row.Cells["Age"].Value);
                combogender.Text = row.Cells["Gender"].Value.ToString();

                string education = row.Cells["Education"].Value.ToString();
                if (education == radiobtnedu1.Text) radiobtnedu1.Checked = true;
                else if (education == radiobtnedu2.Text) radiobtnedu2.Checked = true;
                else if (education == radiobtnedu3.Text) radiobtnedu3.Checked = true;

                txtInterest.Text = row.Cells["Interest"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                this.Enabled = true;

              chatform chat= new chatform();
                chat.Enabled = true;

                chat.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblInterest_Click(object sender, EventArgs e)
        {

        }

        private void radiobtnedu3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            e.PaintBackground(e.CellBounds, true);
            using (Pen pen = new Pen(Color.Gray, 1))
            {
                Rectangle rect = e.CellBounds;
                rect.Width -= 1;
                rect.Height -= 1;
                e.Graphics.DrawRectangle(pen, rect);
            }

            e.PaintContent (e.CellBounds);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}