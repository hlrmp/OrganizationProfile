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

            if (Regex.IsMatch(studNum, @"^[0-9]{1,11}$"))
            {
                _StudentNo = long.Parse(studNum);
            }
            else if (Regex.IsMatch(studNum, @"^[a-zA-Z]+$"))
            {
                throw new FormatException("put student number correctly");
            }
            else
            {
                throw new ArgumentNullException("1");
            }
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {

            if (Regex.IsMatch(Contact, @"^0[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else if (Regex.IsMatch(Contact, @"^[a-zA-Z]+$"))
            {
                throw new FormatException("put contact number correctly");
            }
            else if (Regex.IsMatch(Contact, @"^[0-9]{1,10}$"))
            {
                throw new IndexOutOfRangeException("put contact number correctly");
            }
            else if (Regex.IsMatch(Contact, @"^[0-9]{12,20}$"))
            {
                throw new OverflowException("put contact number correctly");
            }

            else
            {
                throw new ArgumentNullException("2");
            }
            return _ContactNo; ;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") & Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") & Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                LastName = Char.ToUpper(LastName[0]) + LastName.Substring(1);
                FirstName = Char.ToUpper(FirstName[0]) + FirstName.Substring(1);
                MiddleInitial = Char.ToUpper(MiddleInitial[0]) + MiddleInitial.Substring(1);

                _FullName = LastName + ", " + FirstName + " " + MiddleInitial;

            }
            else if (Regex.IsMatch(LastName, @"^[0-9]{1,20}$") || Regex.IsMatch(MiddleInitial, @"^[0-9]{1,20}$") || Regex.IsMatch(FirstName, @"^[0-9]{1,20}$"))
            {
                throw new FormatException("please enter name corectly");
            }
            else
            {
                throw new ArgumentNullException("please enter your name");
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else if (Regex.IsMatch(age, @"^[0-9]{4,15}$"))
            {
                throw new OverflowException("put age correctly");

            }

            else if (Regex.IsMatch(age, @"^[a-zA-Z]+$"))
            {
                throw new FormatException("put age correctly");
            }
            else
            {
                throw new ArgumentNullException("3");
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

                //if (string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtContactNo.Text) || string.IsNullOrEmpty(txtFirstName.Text)
                //    || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtMiddleInitial.Text) || string.IsNullOrEmpty(txtStudentNo.Text))
                //{
                //    throw new ArgumentNullException();
                //}

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
