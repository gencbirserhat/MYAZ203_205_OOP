using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    public class Student
    {
        public Student(Int32 id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Int32 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email => FirstName.ToLower() + "." + LastName.ToLower()
            + "@samsun.edu.tr";

        public string FullName => $"{FirstName} {LastName}";

        public override string? ToString()
        {
            return $"{Id} {FullName} {Email}";
        }
    }
}
