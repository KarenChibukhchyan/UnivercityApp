using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
namespace Univercity.Models
{
    public partial class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        [Browsable(false)]
        public string FirstName { get; set; }
        [Browsable(false)]
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public partial class Student
    {
        public string FullName { get => $"{FirstName} {LastName}"; }
    }
}
