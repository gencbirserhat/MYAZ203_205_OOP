namespace Week_3
{
    public class StudentManager
    {
        List<Student> stdList;

        public StudentManager()
        {
            stdList = new List<Student>();
        }

        public StudentManager(List<Student> std)
        {
            stdList = std;
        }

        public StudentManager(Student std)
        {
            stdList = new List<Student>();
            CreateStudent(std);
        }

        // Create
        public void CreateStudent(Student std)
        {
            stdList.Add(std);
        }

        // Read
        public Student ReadStudent(Int32 id) => stdList[id];

        // Update
        public void UpdateStudent(Int32 id, string? firstName, string? lastName)
        {
            if (firstName != null)
                stdList[id].FirstName = firstName;
            if (lastName != null)
                stdList[id].LastName = lastName;
        }

        // Delete
        public Student DeleteStudent(Int32 id)
        {
            var std = ReadStudent(id);
            stdList.Remove(std);
            
            return std;
        }

        public void ReadAll()
        {
            foreach (var item in stdList)
                Console.WriteLine(item);
        }
    }
}
