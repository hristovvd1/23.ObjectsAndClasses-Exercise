namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:f2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < countStudents; i++)
            {
                string[] grades = Console.ReadLine()
                    .Split()
                    .ToArray();

                Student student = new Student();

                student.FirstName = grades[0];
                student.SecondName = grades[1];
                student.Grade = float.Parse(grades[2]);

                students.Add(student);
            }

            List<Student> orderedStudents = students
            .OrderByDescending(student => student.Grade)
            .ToList();

            Console.WriteLine(string.Join("\n", orderedStudents));
        }
    }
}
