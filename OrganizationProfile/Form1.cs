using System.Text.RegularExpressions;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
            _FullName = string.Empty;
        }

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information System",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateAndSetStudentInformation();
                OpenConfirmationForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            }
        }

        private void ValidateAndSetStudentInformation()
        {
            StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbPrograms.Text;
            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = ValidateBirthday(dateTimePicker1.Value);
        }
        private string ValidateBirthday(DateTime birthday)
        {
            if (birthday > DateTime.Now)
            {
                throw new ArgumentException("Birthday cannot be in the future");
            }

            // Optional: You might want to set a reasonable minimum date as well
            if (birthday < new DateTime(1900, 1, 1))
            {
                throw new ArgumentException("Birthday cannot be earlier than January 1, 1900");
            }

            return birthday.ToString("yyyy-MM-dd");
        }

        private void OpenConfirmationForm()
        {
            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();
        }

        public long StudentNumber(string studNum)
{
    try
    {
        if (!string.IsNullOrEmpty(studNum))
        {
            _StudentNo = long.Parse(studNum);
        }
        else
        {
            throw new ArgumentException(nameof(studNum), "Student number cannot be empty");
        }
    }
    catch (FormatException)
    {

        MessageBox.Show("Invalid student number format");
        throw;


    }
    catch (OverflowException)
    {
        MessageBox.Show("Student number cannot be empty");
        throw;

    }
    catch (ArithmeticException ex)
    {
        MessageBox.Show(ex.Message);
        throw;
    }
    return _StudentNo;

}

public long ContactNo(string Contact)
{
    try
    {
        if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
        {
            _ContactNo = long.Parse(Contact);
        }
        else
        {
            throw new FormatException("Contact number must be 10-11 digits");
        }
    }
    catch (FormatException ex)
    {
        MessageBox.Show(ex.Message);
        throw;
    }
    catch (OverflowException)
    {
        MessageBox.Show("Contact number is too large");
        throw;
    }
    return _ContactNo;
}

public string FullName(string LastName, string FirstName, string MiddleInitial)
{if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(FirstName))
            {
                throw new ArgumentException("Last name and first name are required");
            }

            if (!Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || 
                !Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || 
                (!string.IsNullOrEmpty(MiddleInitial) && !Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]$")))
            {
                throw new FormatException("Name contains invalid characters");
            }

            _FullName = $"{LastName}, {FirstName}, {MiddleInitial}".TrimEnd(' ', ',');
            return _FullName;
        }

public int Age(string age)
{
    try
    {
        if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
        {
            _Age = Int32.Parse(age);
        }
        else
        {
            throw new FormatException("Invalid age format");
        }
    }
    catch (FormatException ex)
    {
        MessageBox.Show(ex.Message);
        throw;
    }
    catch (OverflowException)
    {
        MessageBox.Show("Age value is too large");
        throw;
    }
    catch (IndexOutOfRangeException)
    {
        MessageBox.Show("Age field is empty");
        throw;
    }

    return _Age;
}

        }
    }



