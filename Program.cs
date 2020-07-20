using System;

namespace GradeBook
{
    class Program
    {
      

        static void Main(string[] args)
        {
            // one-dimensional array of student grades
            int[] gradesArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            ClassGradeBook myGradeBook = new ClassGradeBook("CIS1A Intro to Computer Applications", gradesArray);
            Console.WriteLine(myGradeBook.CourseName);
            myGradeBook.ProcessGrades();
        }
    }
}
