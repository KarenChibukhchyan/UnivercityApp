using System;
using System.Windows.Forms;
using Univercity.Models;
using Univercity.Services.Interfaces;

namespace UnivercityApp
{
    internal interface IUnivercity
    {
    }

    public partial class Univercity : Form, IUnivercity
    {
        private readonly IStudentService _studentService;
        private readonly StudenDetails _studenDetails;

        public Univercity(IStudentService studentService, StudenDetails studenDetails)
        {
            _studentService = studentService;
            _studenDetails = studenDetails;
            InitializeComponent();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.Age = int.Parse(ageBox.Text);
            student.FirstName = firstNameBox.Text;
            student.LastName = lastNameBox.Text;

            _studentService.Add(student);
            studentGv.DataSource = null;
            studentGv.DataSource = _studentService.GetAll();
        }

        private void studentGv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _studenDetails.DrawStudent(e.RowIndex);
            _studenDetails.Show();
        }
    }
}