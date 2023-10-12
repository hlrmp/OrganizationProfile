using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;


        public frmRegistration()
        {
            InitializeComponent();



        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
            "BS Information Technology",
            "BS Computer Science",
            "BS Information Systems",
            "BS in Accountancy",
            "BS in Hospitality Management",
            "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }


            string[] genders = new string[]
          {
            "Female",
            "Male"

          };

            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(genders[i].ToString());
            }

        }



    
        public long StudentNumber(string studNum)
        {
           
            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {

            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else if (Regex.IsMatch(Contact,@"^[0]"))
            {
                throw new ArgumentNullException();
            }
            else
            {
                throw new FormatException();
            }
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new FormatException();
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
             else
            {
                throw new FormatException();
            }

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirtday.Value.ToString("yyyy-MM-dd");

                frmConfirmation frm = new frmConfirmation();
                frm.Show();

                if (string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtContactNo.Text) || string.IsNullOrEmpty(txtFirstName.Text)
                    || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtMiddleInitial.Text) || string.IsNullOrEmpty(txtStudentNo.Text))
                {
                    throw new ArgumentNullException();
                }

            }
            catch (FormatException e1)
            {
                MessageBox.Show("Invalid Format - " + e1.Message);
            }
            catch (ArgumentNullException e2)
            {
                MessageBox.Show("ArgumentNullException - " + e2.Message);
            }
            catch (OverflowException e3)
            {
                MessageBox.Show("OverFlowException - " + e3.Message);
            }
            catch (IndexOutOfRangeException e4)
            {
                MessageBox.Show("IndexOutOfRangeException - " + e4.Message);
            }
            

        }
    }
}
