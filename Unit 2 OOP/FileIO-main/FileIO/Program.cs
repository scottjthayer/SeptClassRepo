using System;
using System.Collections.Generic;
using System.IO;//add this to use File class

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>
            {
                new Student("Stan", 8, 4),
                new Student("Kyle", 8, 4),
                new Student("Kenny", 8, 4),
                new Student("Cartman", 8, 4)
            };

            string filePath = @"..\..\..\Students.txt";
            if (File.Exists(filePath) == false)
            {
                Console.WriteLine("File does not exist. Creating now.");
                StreamWriter SW = new StreamWriter(filePath);//open stream
                foreach (Student student in Students)
                {
                    SW.WriteLine($"{student.Name},{student.Age},{student.Grade}");
                }
                SW.Close();//close stream
            }

            //create new student and add to file
            Console.WriteLine("Please enter the new students name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the new students age.");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What grade is the new student in?");
            int grade = int.Parse(Console.ReadLine());
            //append adds names instead of repalcing names on list
            StreamWriter writer = new StreamWriter(filePath, append: true);
            writer.WriteLine($"{name},{age},{grade}");
            writer.Close();

            //reading the file
            StreamReader reader = new StreamReader(filePath);
            while (true)
            {
                string line = reader.ReadLine();
                //if end of file
                if (line == null)
                {
                    //no more file to read
                    break;
                }
                else
                {
                    string[] values = line.Split(',');
                    string newName = values[0];
                    int newAge = int.Parse(values[1]);
                    int newGrade = int.Parse(values[2]);

                    Student newStudent = new Student(newName, newAge, newGrade);

                    Console.WriteLine($"{newStudent.Name} is {newStudent.Age} years old. They are in {newStudent.Grade} grade.");
                }
            }
            reader.Close();
        }

        //example code
        //writing to file
        static void Tester()
        {
            //Console.WriteLine("File Input/Output OR FileI/O");
            //stream of data
            //file: read/write using streams
            //C# has libraries that help deal with data in a file
            StreamWriter SW = new StreamWriter(@"..\..\..\File.txt", append: true);// use @ and ..\ to go back one file. this example goes back 3 folders.
            SW.WriteLine("Hello.");
            SW.WriteLine("Hello!");
            SW.Close();

            //reading the file
            StreamReader SR = new StreamReader(@"..\..\..\File.txt");
            //string result = SR.ReadLine();
            //Console.WriteLine(result);


            while (true)
            {
                string line = SR.ReadLine();
                //if end of file
                if (line == null)
                {
                    //no more file to read
                    break;
                }
                else
                {
                    Console.WriteLine(line);
                }
            }
            SR.Close();          
        }
        //string example
        static void StringTester()
        {
            List<string> Students = new List<string>
            {
                "Stan",
                "Kyle",
                "Kenny",
                "Cartman"
            };
            string filePath = @"..\..\..\File.txt";

            //set up the file            
            if (File.Exists(filePath) == false)
            {
                Console.WriteLine("File does not exist. Creating now.");
                StreamWriter SW = new StreamWriter(filePath);//open stream
                foreach (string student in Students)
                {
                    SW.WriteLine(student);
                }
                SW.Close();//close stream
            }

            //create new student and add to file
            Console.WriteLine("Please enter the new students name");
            string name = Console.ReadLine();
            //append adds names instead of repalcing names on list
            StreamWriter writer = new StreamWriter(filePath, append: true);
            writer.WriteLine(name);
            writer.Close();

            //reading the file
            StreamReader reader = new StreamReader(filePath);
            while (true)
            {
                string line = reader.ReadLine();
                //if end of file
                if (line == null)
                {
                    //no more file to read
                    break;
                }
                else
                {
                    Console.WriteLine(line);
                }
            }
            reader.Close();
        }
    }
}
