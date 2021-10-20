using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    class Student
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        //construictor
        public Student(string name, int age, int grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
    }
}
