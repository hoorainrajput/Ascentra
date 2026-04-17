namespace ASCENTRA
{
    partial class UserInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            this.Backbtn = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnedu3 = new System.Windows.Forms.RadioButton();
            this.radiobtnedu1 = new System.Windows.Forms.RadioButton();
            this.radiobtnedu2 = new System.Windows.Forms.RadioButton();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.btbdltdb = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnchat = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(24, 26);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(161, 36);
            this.Backbtn.TabIndex = 5;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDB.Location = new System.Drawing.Point(669, 433);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(198, 39);
            this.btnSaveToDB.TabIndex = 6;
            this.btnSaveToDB.Text = "Save to DataBase";
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 494);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(991, 139);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(312, 116);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(353, 31);
            this.txtName.TabIndex = 10;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // numAge
            // 
            this.numAge.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.numAge.ForeColor = System.Drawing.Color.White;
            this.numAge.Location = new System.Drawing.Point(311, 162);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(354, 26);
            this.numAge.TabIndex = 11;
            // 
            // combogender
            // 
            this.combogender.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.combogender.ForeColor = System.Drawing.Color.White;
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male ",
            "Female ",
            "Rather Not to say"});
            this.combogender.Location = new System.Drawing.Point(310, 214);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(361, 28);
            this.combogender.TabIndex = 12;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInterest.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInterest.Location = new System.Drawing.Point(751, 310);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(125, 35);
            this.lblInterest.TabIndex = 13;
            this.lblInterest.Text = "Interest";
            this.lblInterest.Click += new System.EventHandler(this.lblInterest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Controls.Add(this.radiobtnedu3);
            this.groupBox1.Controls.Add(this.radiobtnedu1);
            this.groupBox1.Controls.Add(this.radiobtnedu2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(185, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 96);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radiobtnedu3
            // 
            this.radiobtnedu3.AutoSize = true;
            this.radiobtnedu3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.radiobtnedu3.ForeColor = System.Drawing.Color.White;
            this.radiobtnedu3.Location = new System.Drawing.Point(6, 68);
            this.radiobtnedu3.Name = "radiobtnedu3";
            this.radiobtnedu3.Size = new System.Drawing.Size(129, 24);
            this.radiobtnedu3.TabIndex = 18;
            this.radiobtnedu3.TabStop = true;
            this.radiobtnedu3.Text = "Master/PH.D.";
            this.radiobtnedu3.UseVisualStyleBackColor = false;
            this.radiobtnedu3.CheckedChanged += new System.EventHandler(this.radiobtnedu3_CheckedChanged);
            // 
            // radiobtnedu1
            // 
            this.radiobtnedu1.AutoSize = true;
            this.radiobtnedu1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.radiobtnedu1.ForeColor = System.Drawing.Color.White;
            this.radiobtnedu1.Location = new System.Drawing.Point(5, 9);
            this.radiobtnedu1.Name = "radiobtnedu1";
            this.radiobtnedu1.Size = new System.Drawing.Size(171, 24);
            this.radiobtnedu1.TabIndex = 17;
            this.radiobtnedu1.TabStop = true;
            this.radiobtnedu1.Text = "Metric/Intermediate";
            this.radiobtnedu1.UseVisualStyleBackColor = false;
            // 
            // radiobtnedu2
            // 
            this.radiobtnedu2.AutoSize = true;
            this.radiobtnedu2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.radiobtnedu2.ForeColor = System.Drawing.Color.White;
            this.radiobtnedu2.Location = new System.Drawing.Point(6, 38);
            this.radiobtnedu2.Name = "radiobtnedu2";
            this.radiobtnedu2.Size = new System.Drawing.Size(182, 24);
            this.radiobtnedu2.TabIndex = 19;
            this.radiobtnedu2.TabStop = true;
            this.radiobtnedu2.Text = "Associate/Bachelor\'s";
            this.radiobtnedu2.UseVisualStyleBackColor = false;
            // 
            // txtInterest
            // 
            this.txtInterest.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtInterest.ForeColor = System.Drawing.Color.White;
            this.txtInterest.Location = new System.Drawing.Point(880, 308);
            this.txtInterest.Multiline = true;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(304, 40);
            this.txtInterest.TabIndex = 22;
            // 
            // btbdltdb
            // 
            this.btbdltdb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btbdltdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbdltdb.Location = new System.Drawing.Point(442, 434);
            this.btbdltdb.Name = "btbdltdb";
            this.btbdltdb.Size = new System.Drawing.Size(193, 39);
            this.btbdltdb.TabIndex = 24;
            this.btbdltdb.Text = "Delete Row";
            this.btbdltdb.UseVisualStyleBackColor = false;
            this.btbdltdb.Click += new System.EventHandler(this.btbdltdb_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(900, 433);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(161, 39);
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnchat
            // 
            this.btnchat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnchat.ForeColor = System.Drawing.Color.Black;
            this.btnchat.Location = new System.Drawing.Point(218, 433);
            this.btnchat.Name = "btnchat";
            this.btnchat.Size = new System.Drawing.Size(173, 40);
            this.btnchat.TabIndex = 30;
            this.btnchat.Text = "Ascentra Bot 🤖";
            this.btnchat.UseVisualStyleBackColor = false;
            this.btnchat.Click += new System.EventHandler(this.button1_Click);
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(815, 49);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(369, 239);
            this.picResult.TabIndex = 7;
            this.picResult.TabStop = false;
            this.picResult.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(23, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1190, 639);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(183, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "  Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(183, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "   Age    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(183, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 33;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(195, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "  Education  ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 682);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnchat);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btbdltdb);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.Name = "UserInfoForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "UserInfoForm";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UserInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtnedu3;
        private System.Windows.Forms.RadioButton radiobtnedu1;
        private System.Windows.Forms.RadioButton radiobtnedu2;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Button btbdltdb;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnchat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}