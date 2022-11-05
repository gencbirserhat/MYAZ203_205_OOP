namespace Week_2_HomeWork
{
    public class Program
    {
        public static void Main()
        {
            var employee1 = new Employee()
            {
                Id = 1,
                FirstName = "Serhat",
                LastName = "Genç",
                Age = 20

            };
            var employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Anıl",
                LastName = "Yılmaz",
                Age = 22

            };
            var employee3 = new Employee()
            {
                Id = 3,
                FirstName = "Arda",
                LastName = "Yılmaz",
                Age = 25

            };
            var employee4 = new Employee()
            {
                Id = 4,
                FirstName = "Hünkar",
                LastName = "Acar",
                Age = 30

            };

            var generatedEmploye = new EmployeeMethods();

            generatedEmploye.Add(employee4);
            generatedEmploye.Add(employee3);
            generatedEmploye.Add(employee2);
            generatedEmploye.Add(employee1);
            generatedEmploye.ListWrite();
            Console.WriteLine(new string('-',25));
            generatedEmploye.Remove(2);
            generatedEmploye.ListWrite();
        }
    }
}