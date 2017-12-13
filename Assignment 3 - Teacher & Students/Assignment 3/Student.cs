using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Student
    {
        private string FirstName;
        private int Grade;
        private Instructor Teacher; 

        public Student(string FirstName, Instructor Teacher)
        {

            this.FirstName = FirstName;
            this.Teacher = Teacher;
        }
        
        public void SetGrade(int GradeValue)
        {
            Grade = GradeValue; 
        }

        public string StudentInfo()
        {
            return "Student: " + FirstName + " / " + "Grade: " + Grade;
        }
        
        public void PrintInfo()
        {
            System.Console.WriteLine(StudentInfo() + " ; " + Teacher.TeacherInfo());  
        }
    }
}
