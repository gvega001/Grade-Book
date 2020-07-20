using System;
namespace GradeBook
{
    public class ClassGradeBook
    {  //array of students grades
        private int[] grades;
        //getter-only auto-implemented property CourseName
        public string CourseName { get; }

        //two-parameter constructor initializes
        //auto-implemented property CourseName and grades array
        public ClassGradeBook(String name, int[] gradesArray)
        {
            CourseName = name;//set CorseName to name
            grades = gradesArray;// initialize grades array
        }
        //display a welcom message to the GradeBook user
        public void DisplayMessage()
        {
            //auto-implement property CourseName gets the name of course
            Console.WriteLine($"Welcom to the grade book for\n{CourseName}!\n");
        }
        public void ProcessGrades()
        {
            //output grades array
            OutputGrades();
            //call method Get Average to calculate the average grade
            Console.WriteLine($"\nClass average is {GetAverage():F}");
            //call methods GetMinimum and GetMaximum
            Console.WriteLine($"Lowest grade is {GetMinimum()}");
            Console.WriteLine($"Highest grade is {GetMaximum()}");

            //call OutputBarChart to display grade distribution chart
            OutputBarChart();
        }

        //find minimum grade
        public int GetMinimum()
        {
            var lowGrade = grades[0]; // assume grade[0] is smalles

            //loop through grades array
            foreach (var grade in grades)
            {
                //if grade lower than lowGrade, assign it to lowGrade
                if (grade < lowGrade)
                {
                    lowGrade = grade;// new lowest grade
                }
            }
            return lowGrade;// return the lowest grade
        }
        public int GetMaximum()
        {
            var highGrade = grades[0]; //assume grades[0] is largest

            //loop through grades array
            foreach (var grade in grades)
            {
                //if grade greater than highGrade, assignh it to highGrade
                if (grade > highGrade)
                {
                    highGrade = grade;// return highest grade
                }
            }
            return highGrade; // return the highest grades
        }
        public double GetAverage()
        {
            var total = 0.0f; // intitialize total as a double
                              //sum students' grades
            foreach (var grade in grades)
            {
                total += grade;
            }
            //return average of grades
            return total / grades.Length;
        }
        //output bar chart displaying grade distribution
        public void OutputBarChart()
        {
            Console.WriteLine("Grade Distribution:");

            //stores frequency of grades in each range of 10 grades
            var frequency = new int[11];

            //for each grade frequency, dispaly bar in chart
            for (int count = 0; count < frequency.Length; ++count)
            {
                //output bar label
                if (count == 0)
                {
                    Console.Write(" 100: ");
                }
                else
                {
                    Console.Write($"{count * 10:D2}-{count * 10 + 9:D2}: ");
                }
                //display bar of asterisks
                for (var stars = 0; stars < frequency[count]; ++stars)
                {
                    Console.Write("*");
                }
                Console.WriteLine();//start a new line of output
            }
        }
        public void OutputGrades()
        {
            Console.WriteLine("The grades are: \n");
            // output each student's grade
            for (var student = 0; student < grades.Length; ++student)
            {
                Console.WriteLine($"Student {student + 1,2}: {grades[student],3}");

            }
        }
    }
}