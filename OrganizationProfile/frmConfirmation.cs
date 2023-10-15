using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
        StudentInformationClass studentInformationClass = new StudentInformationClass();
        frmRegistration frmRegistration = new frmRegistration();
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();

            DialogResult dialog = (MessageBox.Show(" do you want to submit , " + " \n " + " double check your information  ", "SUBMIT", MessageBoxButtons.OKCancel));
            if (dialog == DialogResult.OK)
            {

                frm.txtFirstName.ResetText();
                frm.txtLastName.Clear();
                frm.txtMiddleInitial.Clear();
                frm.txtStudentNo.Clear();
                frm.txtContactNo.Clear();
                frm.txtAge.Clear();
                frm.cbGender.ResetText();
                frm.cbPrograms.ResetText();
                frm.datePickerBirtday.ResetText();

           
                this.Hide();

            }
            else
            {

            }
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblBirthday.Text = StudentInformationClass.SetBirthday;
            lblGender.Text = StudentInformationClass.SetGender;
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();
        }
    }
}
