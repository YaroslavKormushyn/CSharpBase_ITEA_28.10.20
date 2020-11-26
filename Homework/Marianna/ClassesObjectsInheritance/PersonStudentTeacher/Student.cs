using System;
using System.Collections.Generic;
using System.Text;

namespace PersonStudentTeacher
{
    class Student : Person
    {
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Teacher Teacher { get; set; }

        public void GoToClasses()
        {
            Console.WriteLine(" I’m going to class.{0}", FirstName);
        }
        public void ShowAge(int n)
        {
            Console.WriteLine("Age is: " + n);
        }
        public override void Perform()
        {
        }
    }
}

