using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10
{
    public interface IStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string FullName(string firstName, string lastName);
        public string Email(string fullname);
    }
}
