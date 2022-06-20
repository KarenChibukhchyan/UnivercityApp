using System.Windows.Forms;
using Univercity.Services.Interfaces;

namespace UnivercityApp
{
    public partial class StudenDetails : Form
    {
        private readonly IStudentService _studentService;

        public StudenDetails(IStudentService studentService)
        {
            _studentService = studentService;
            InitializeComponent();
        }

        public void DrawStudent(int eRowIndex)
        {
            var student = _studentService.Get(eRowIndex);
            ageLbl.Text = student.Age.ToString();
            firstNameLbl.Text = student.FirstName;
            lastNameLbl.Text = student.LastName;
            idLbl.Text = student.Id.ToString();
        }

        private void StudenDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}