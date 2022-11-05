namespace Week_2_HomeWork
{
    public class EmployeeMethods 
    {
        private List<Employee> _employees;

        public EmployeeMethods()
        {
            _employees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
           _employees.Add(employee);
        }

        public void Remove(int id)
        {
            var employee = _employees.FirstOrDefault(employee => employee.Id == id);
            if (employee == null)
            {
                throw new Exception("Employee Not Found!");
            }
            else
            {
                _employees.Remove(employee);
            }
        }
        public void ListWrite()
        {
            foreach (var emp in _employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}