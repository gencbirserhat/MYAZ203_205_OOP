namespace Week_3
{
	class Program
	{
		static void Main()
		{
            
            List<Student> students = new List<Student>()
            {
                new Student(0, "Ali", "Dag"),
                new Student(1, "Veli", "Dag"),
                new Student(2, "Ahmet", "Dag"),
                new Student(3, "Mehmet", "Dag"),
                new Student(4, "Melih", "Dag"),
            };

            Student std = new Student(students.Count, "Serhat", "Genç");
            var currentId = students.Count;
            StudentManager studentManager = new StudentManager(students);
            studentManager.ReadAll();
            studentManager.CreateStudent(std);
            Console.WriteLine("------------------\n" + studentManager.ReadStudent(currentId));
            studentManager.DeleteStudent(2);
            studentManager.UpdateStudent(1, null, "Veli");
            Console.WriteLine("------------------");
            studentManager.ReadAll();
            
        }
	}
}