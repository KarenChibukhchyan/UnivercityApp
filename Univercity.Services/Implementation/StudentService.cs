using System;
using System.Collections.Generic;
using System.Linq;
using Univercity.Models;
using Univercity.Services.Interfaces;
namespace Univercity.Services.Implementation
{
    internal class StudentService: IStudentService
    {
        private readonly List<Student> _students = new List<Student>();

        public void Add(Student student) => _students.Add(student);

        public Student Get(int index) => _students[index];

        public IEnumerable<Student> GetAll() => _students;
    }
}
