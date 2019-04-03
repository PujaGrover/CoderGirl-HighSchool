using System;
using System.Collections.Generic;

namespace HighSchool
{
    public static class Program
    {
        public static void Main()
        {
            //Create a List off 10 students and add their firstName, lastName, grade and GPA
            List<Student> student = new List<Student>(){

               new Student() {FirstName = "William", LastName = "Bowser", GPA = 3.5, Grade = 11},
               new Student() {FirstName = "John", LastName = "Smith", GPA = 3.25, Grade = 9 },
               new Student() {FirstName = "Anne", LastName = "Smithson", GPA = 4.1, Grade = 12},
               new Student() {FirstName = "Gerald", LastName = "Robertson", GPA = 3.9, Grade = 13},
               new Student() {FirstName = "Juliette", LastName = "Brewer", GPA = 4.0, Grade = 10},
               new Student() {FirstName = "Raphael", LastName = "Katinga", GPA = 2.74, Grade = 12},
               new Student() {FirstName = "Walter", LastName = "Oblonski", GPA = 2.58, Grade = 11},
               new Student() {FirstName = "Lucy", LastName = "Kreiger", GPA = 3.00, Grade = 9},
               new Student() {FirstName = "Ryan", LastName = "Sharp", GPA = 2.75, Grade = 10},
               new Student() {FirstName = "Laura", LastName = "Walter", GPA = 3.6, Grade = 5},

            };

            Console.Write("My total list has student count of : ");
            Console.WriteLine(student.Count);

            foreach (Student allstudent in student)
            {
                Console.WriteLine(allstudent.FirstName + "       "  + allstudent.GPA + "       " + allstudent.Grade);

            }

            List<Student> myStarStudents = Student.StarStudents(student);

            Console.Write("My star list has student count of : ");
            Console.WriteLine(myStarStudents.Count);

            foreach (Student starStudent in myStarStudents)
            {
                Console.WriteLine(starStudent.Grade + "       "+ starStudent.GPA + "       "+ starStudent.LastName + "       "+ starStudent.FirstName);
                
            }

            Console.ReadLine();
        }
    }
}
