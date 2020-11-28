using System;

namespace PersonStudentTeacher
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public void Hello()
        {
            Console.WriteLine("Hello!");
        }
        public virtual void Perform() { }
    }
}

