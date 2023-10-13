namespace OrganizationProfile
{
    partial class frmConfirmation
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnSubmit = new Button();
            lblStudentNo = new Label();
            lblName = new Label();
            lblProgram = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblGender = new Label();
            lblContactNo = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(155, 111);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 38;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(118, 72);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 39;
            label3.Text = "Student No. :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(168, 198);
            label4.Name = "label4";
            label4.Size = new Size(39, 18);
            label4.TabIndex = 40;
            label4.Text = "Age :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(140, 240);
            label5.Name = "label5";
            label5.Size = new Size(67, 18);
            label5.TabIndex = 41;
            label5.Text = "Birthday :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(140, 154);
            label6.Name = "label6";
            label6.Size = new Size(67, 18);
            label6.TabIndex = 42;
            label6.Text = "Program :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(145, 284);
            label9.Name = "label9";
            label9.Size = new Size(62, 18);
            label9.TabIndex = 44;
            label9.Text = "Gender :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(120, 327);
            label10.Name = "label10";
            label10.Size = new Size(87, 18);
            label10.TabIndex = 45;
            label10.Text = "Contact No. :";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Tomato;
            btnSubmit.ForeColor = SystemColors.ControlText;
            btnSubmit.Location = new Point(202, 358);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(135, 44);
            btnSubmit.TabIndex = 46;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(231, 75);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(38, 15);
            lblStudentNo.TabIndex = 47;
            lblStudentNo.Text = "label1";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(231, 111);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 48;
            lblName.Text = "label1";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(231, 157);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(38, 15);
            lblProgram.TabIndex = 49;
            lblProgram.Text = "label1";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(231, 200);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(38, 15);
            lblAge.TabIndex = 50;
            lblAge.Text = "label1";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(230, 240);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(38, 15);
            lblBirthday.TabIndex = 51;
            lblBirthday.Text = "label1";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(230, 281);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(38, 15);
            lblGender.TabIndex = 52;
            lblGender.Text = "label1";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(230, 330);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(38, 15);
            lblContactNo.TabIndex = 53;
            lblContactNo.Text = "label1";
            // 
            // frmConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(lblContactNo);
            Controls.Add(lblGender);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblProgram);
            Controls.Add(lblName);
            Controls.Add(lblStudentNo);
            Controls.Add(btnSubmit);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmConfirmation";
            Text = "g";
            Load += frmConfirmation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private Button btnSubmit;
        private Label lblStudentNo;
        private Label lblName;
        private Label lblProgram;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblGender;
        private Label lblContactNo;
    }
}