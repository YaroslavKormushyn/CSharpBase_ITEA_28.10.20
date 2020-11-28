using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonStudentTeacher
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            Student[] class1 = new Student[3];
            class1[0] = new Student("Ann", "Parker", 20);
            class1[1] = new Student("Mary", "Parker", 21);
            Teacher teacher1 = new Teacher(class1, "Jack", "Hudson", 40);
            teacher1.Perform();
        }
    }
}
