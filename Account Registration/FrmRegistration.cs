using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        
        public FrmRegistration()
        {
            InitializeComponent();
            string[] programss = { "Bachelor of Science in Accountancy"
            ,"Bachelor of Science in Business Administration","Bachelor of Science in Computer Engineering"
            ,"Bachelor of Science in Computer Science","Bachelor of Science in Hospitality Management",
            "Bachelor of Science in Information Technology","Bachelor of Science in Tourism Management"};
            for(int i = 0;i < programss.Length; i++)
            {
                programs.Items.Add(programss[i]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nextbttn_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = firstname.Text.ToString();
            StudentInfoClass.LastName = lastname.Text.ToString();
            StudentInfoClass.MiddleName = middlename.Text.ToString();
            StudentInfoClass.Address = address.Text.ToString();
            StudentInfoClass.Program = programs.SelectedItem.ToString();
            StudentInfoClass.Age = long.Parse(age.Text);
            StudentInfoClass.ContactNo = long.Parse(contactno.Text);
            StudentInfoClass.StudentNo = long.Parse(studentno.Text);


            FrmConfirm frm = new FrmConfirm();
            
            
          
            if (frm.ShowDialog() == DialogResult.OK)
            {
                studentno.Text = ""; firstname.Text = ""; lastname.Text = "";
                middlename.Text = ""; address.Text = "";programs.Text = "";
                age.Text = "";contactno.Text = ""; studentno.Text = "";
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }   
}
public delegate long DelegateNumber(long number);
public delegate string DelegateText(string txt);

public class StudentInfoClass
{
    public static string FirstName = " "; public static string MiddleName = " ";
    public static string LastName = " "; public static string Address = " ";
    public static string Program = " "; public static long Age = 0;
    public static long ContactNo = 0; public static long StudentNo = 0;

    public static string GetFirstName(string FirstName)
    {
        return FirstName;
    }
    public static string GetLastName(string LastName)
    {
        return LastName;
    }
    public static string GetMiddleName(string MiddleName)
    {
        return MiddleName;
    }
    public static string GetAddress(string Address)
    {
        return Address;
    }
    public static string GetProgram(string Program)
    {
        return Program;
    }
    public static long GetAge(long Age)
    {
        return Age;
    }
    public static long GetContactNo(long ContactNo)
    {
        return ContactNo;
    }
    public static long GetStudentNo(long StudentNo)
    {
        return StudentNo;
    }


}
