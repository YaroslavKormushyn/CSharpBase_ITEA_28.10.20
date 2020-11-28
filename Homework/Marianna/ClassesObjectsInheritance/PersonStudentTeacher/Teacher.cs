using System;
using System.Linq;

namespace PersonStudentTeacher
{
    class Teacher : Person
    {
        public Teacher(Student[] students, string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            Students = students;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Student[] Students { get; set; }
        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
        public override void Perform()
        {
            Console.WriteLine("Teacher {0} {1} have the following students in his class: ", FirstName, LastName);
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("{0} {1} {2} years old.", Students[i].FirstName, Students[i].LastName, Students[i].Age);
            }
        }
    }
}
