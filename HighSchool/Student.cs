using System.Collections.Generic;
using System.Linq;

namespace HighSchool
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private double studentGPA;
        private int studentGrade;
       

        public string FirstName
        {
            get { return $"{firstName}"; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return $"{lastName}"; }
            set { lastName = value; }
        }

        public double GPA
        {
            get { return studentGPA; }
            set
            {
                //studentGPA = value;
                if (value < 0.0)
                {
                    studentGPA = 0;
                }
                else if (value > 4)
                {
                    studentGPA = 4.0;
                }
                else
                {
                    studentGPA = value;
                }
            }
        }

        public int Grade
        {
            get { return studentGrade; }
            set
            {
                if (value < 1)
                {
                    studentGrade = 1;
                }
                else if (value > 12)
                {
                    studentGrade = 12;
                }
                else
                {
                    studentGrade = value;
                }
            }
        }




        public static List<Student> StarStudents(List<Student> students)
        {
            var starStudents = students.Where(student => student.studentGPA >= 3 && (student.studentGrade >= 9 && student.studentGrade <= 12));
            var starStudentsOrdered = starStudents.OrderByDescending(student => student.Grade).ThenByDescending(student => student.GPA).ThenBy(student => student.LastName).ThenBy(student => student.FirstName);
            


            return starStudentsOrdered.ToList();
            
        }
    }
}
