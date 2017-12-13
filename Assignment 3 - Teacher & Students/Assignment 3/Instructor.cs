using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Instructor
    {
        private string FirstName;
        private string CourseName;
        
        public Instructor(string FirstName, string CourseName)
        {
            this.FirstName = FirstName;
            this.CourseName = CourseName;
        } 

        public void SetStudentGrade(Student Student, int grade)
        {
            Student.SetGrade(grade);
        }

        public string TeacherInfo()
        {
            return "Instructor: " + FirstName + " / " + "Course: " + CourseName;  
        }

        public void PrintTeacherInfo()
        {
            System.Console.WriteLine(TeacherInfo());
        }
    }

}
