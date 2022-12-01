using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10
{
    internal class StudentManager : IStudent 
    {
        private List<IStudent> _students;

        public StudentManager()
        {
            _students = new List<IStudent>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email(string fullname)
        {
            return fullname + "@samsun.edu.tr";
        }

        public string FullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        public IEnumerator GetEnumerator()
        {
            return _students.GetEnumerator();
        }
    }
}
