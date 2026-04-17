namespace ASCENTRA
{
    partial class UserForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnML = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.btnDesign = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.radiobtnedu1 = new System.Windows.Forms.RadioButton();
            this.radiobtnedu3 = new System.Windows.Forms.RadioButton();
            this.radiobtnedu2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(246, 261);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 26);
            this.txtName.TabIndex = 1;
            // 
            // numAge
            // 
            this.numAge.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.numAge.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.numAge.Location = new System.Drawing.Point(246, 319);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(286, 26);
            this.numAge.TabIndex = 2;
            // 
            // combogender
            // 
            this.combogender.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.combogender.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male ",
            "Female ",
            "Rather Not to say"});
            this.combogender.Location = new System.Drawing.Point(248, 377);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(286, 28);
            this.combogender.TabIndex = 4;
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuiz.Location = new System.Drawing.Point(136, 559);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(196, 39);
            this.btnQuiz.TabIndex = 5;
            this.btnQuiz.Text = "Play Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.button1_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Indigo;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.Location = new System.Drawing.Point(23, 619);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(131, 60);
            this.Backbtn.TabIndex = 6;
            this.Backbtn.Text = "Exit";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAge.Location = new System.Drawing.Point(164, 319);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(59, 24);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "  Age ";
            // 
            // txtInterest
            // 
            this.txtInterest.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtInterest.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtInterest.Location = new System.Drawing.Point(703, 251);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(297, 26);
            this.txtInterest.TabIndex = 12;
            this.txtInterest.TextChanged += new System.EventHandler(this.txtInterest_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ASCENTRA.Properties.Resources.Untitled_design;
            this.pictureBox1.Location = new System.Drawing.Point(18, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1114, 661);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnML
            // 
            this.btnML.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnML.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnML.Location = new System.Drawing.Point(592, 562);
            this.btnML.Name = "btnML";
            this.btnML.Size = new System.Drawing.Size(193, 42);
            this.btnML.TabIndex = 13;
            this.btnML.Text = "ML Roadmap";
            this.btnML.UseVisualStyleBackColor = false;
            this.btnML.Click += new System.EventHandler(this.btnML_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWeb.Location = new System.Drawing.Point(365, 559);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(194, 42);
            this.btnWeb.TabIndex = 14;
            this.btnWeb.Text = "Web Roadmap";
            this.btnWeb.UseVisualStyleBackColor = false;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // btnDesign
            // 
            this.btnDesign.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesign.Location = new System.Drawing.Point(818, 566);
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.Size = new System.Drawing.Size(194, 42);
            this.btnDesign.TabIndex = 15;
            this.btnDesign.Text = "Graphic Roadmap";
            this.btnDesign.UseVisualStyleBackColor = false;
            this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.Indigo;
            this.btnSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveToDB.Location = new System.Drawing.Point(994, 620);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(131, 60);
            this.btnSaveToDB.TabIndex = 16;
            this.btnSaveToDB.Text = "Save";
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // radiobtnedu1
            // 
            this.radiobtnedu1.AutoSize = true;
            this.radiobtnedu1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.radiobtnedu1.ForeColor = System.Drawing.Color.White;
            this.radiobtnedu1.Location = new System.Drawing.Point(5, 14);
            this.radiobtnedu1.Name = "radiobtnedu1";
            this.radiobtnedu1.Size = new System.Drawing.Size(171, 24);
            this.radiobtnedu1.TabIndex = 17;
            this.radiobtnedu1.TabStop = true;
            this.radiobtnedu1.Text = "Metric/Intermediate";
            this.radiobtnedu1.UseVisualStyleBackColor = false;
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
            // 
            // radiobtnedu2
            // 
            this.radiobtnedu2.AutoSize = true;
            this.radiobtnedu2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.radiobtnedu2.ForeColor = System.Drawing.Color.White;
            this.radiobtnedu2.Location = new System.Drawing.Point(5, 40);
            this.radiobtnedu2.Name = "radiobtnedu2";
            this.radiobtnedu2.Size = new System.Drawing.Size(182, 24);
            this.radiobtnedu2.TabIndex = 19;
            this.radiobtnedu2.TabStop = true;
            this.radiobtnedu2.Text = "Associate/Bachelor\'s";
            this.radiobtnedu2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Controls.Add(this.radiobtnedu3);
            this.groupBox1.Controls.Add(this.radiobtnedu1);
            this.groupBox1.Controls.Add(this.radiobtnedu2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(619, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 99);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(155, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "  Name  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(162, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = " Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(619, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Interest";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(619, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = " Eduaction Level ";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 724);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.btnDesign);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.btnML);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "UserForm";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Button btnML;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Button btnDesign;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.RadioButton radiobtnedu1;
        private System.Windows.Forms.RadioButton radiobtnedu3;
        private System.Windows.Forms.RadioButton radiobtnedu2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}