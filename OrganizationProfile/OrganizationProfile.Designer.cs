﻿namespace OrganizationProfile
{
    partial class frmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnRegister = new Button();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            cbPrograms = new ComboBox();
            cbGender = new ComboBox();
            datePickerBirtday = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 42);
            label1.Name = "label1";
            label1.Size = new Size(187, 33);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 193);
            label2.Name = "label2";
            label2.Size = new Size(82, 18);
            label2.TabIndex = 1;
            label2.Text = " Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(65, 150);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 2;
            label3.Text = "Student No. :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(115, 236);
            label4.Name = "label4";
            label4.Size = new Size(39, 18);
            label4.TabIndex = 3;
            label4.Text = "Age :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(87, 277);
            label5.Name = "label5";
            label5.Size = new Size(67, 18);
            label5.TabIndex = 4;
            label5.Text = "Birthday :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(413, 145);
            label6.Name = "label6";
            label6.Size = new Size(67, 18);
            label6.TabIndex = 5;
            label6.Text = "Program :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(398, 188);
            label7.Name = "label7";
            label7.Size = new Size(82, 18);
            label7.TabIndex = 6;
            label7.Text = "First Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(707, 195);
            label8.Name = "label8";
            label8.Size = new Size(40, 18);
            label8.TabIndex = 7;
            label8.Text = "M.I. :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(418, 236);
            label9.Name = "label9";
            label9.Size = new Size(62, 18);
            label9.TabIndex = 8;
            label9.Text = "Gender :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(528, 274);
            label10.Name = "label10";
            label10.Size = new Size(87, 18);
            label10.TabIndex = 9;
            label10.Text = "Contact No. :";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Tomato;
            btnRegister.ForeColor = SystemColors.ControlText;
            btnRegister.Location = new Point(610, 345);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 60);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(169, 150);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(196, 22);
            txtStudentNo.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(169, 195);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(196, 22);
            txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(499, 192);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(193, 22);
            txtFirstName.TabIndex = 13;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(753, 195);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(71, 22);
            txtMiddleInitial.TabIndex = 14;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(169, 239);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(196, 22);
            txtAge.TabIndex = 15;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(631, 272);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(193, 22);
            txtContactNo.TabIndex = 16;
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(499, 145);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(325, 24);
            cbPrograms.TabIndex = 17;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(499, 237);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(193, 24);
            cbGender.TabIndex = 18;
            // 
            // datePickerBirtday
            // 
            datePickerBirtday.Location = new Point(160, 277);
            datePickerBirtday.Name = "datePickerBirtday";
            datePickerBirtday.Size = new Size(288, 22);
            datePickerBirtday.TabIndex = 19;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(914, 430);
            Controls.Add(datePickerBirtday);
            Controls.Add(cbGender);
            Controls.Add(cbPrograms);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(btnRegister);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegistration";
            Text = "OrganizationProfile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnRegister;
        public TextBox txtStudentNo;
        public TextBox txtLastName;
        public TextBox txtFirstName;
        public TextBox txtMiddleInitial;
        public TextBox txtAge;
        public TextBox txtContactNo;
        public ComboBox cbPrograms;
        public ComboBox cbGender;
        public DateTimePicker datePickerBirtday;
    }
}