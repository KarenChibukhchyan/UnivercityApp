using System;
using System.Collections.Generic;
using System.Linq;
using Univercity.Models;

namespace Univercity.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student Get(int index);
        void Add(Student student);
    }
}
