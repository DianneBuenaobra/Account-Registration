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
    public partial class FrmConfirm : Form
    {
        private DelegateText Delprogram, DelLastName, DelFirstName, DelMiddleName,
            DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration frm = new FrmRegistration();
            this.DialogResult = DialogResult.OK;
            
            this.Close();

        }

        
        public FrmConfirm()
        {
            InitializeComponent();
            Delprogram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentno.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblLastName.Text = DelLastName(StudentInfoClass.LastName).ToString();
            lblFirstname.Text = DelFirstName(StudentInfoClass.FirstName).ToString();
            lblMiddlename.Text = DelMiddleName(StudentInfoClass.MiddleName).ToString();
            lblAddress.Text = DelAddress(StudentInfoClass.Address).ToString();
            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContactno.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblProgram.Text = Delprogram(StudentInfoClass.Program).ToString();


        }
    }
}
