using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Student
    {
        private char chGrade;
        private double score;

		// Constructor method
        public Student()
        {
            score = 0;
            chGrade = 'F';
        }
		
		// Overloading method
        public char ComputeGrade(double scoreTotal)
        {
            chGrade = getGrade(scoreTotal);
            return chGrade;
        }
		
		// Overloading method
        public char ComputeGrade(double scoreHomework, double scoreMidterm, double scoreFinal)
        {
            chGrade = getGrade(scoreHomework + scoreMidterm + scoreFinal);
            return chGrade;
        }

		// Overloading method
        public char ComputeGrade(double scoreHomework, double scoreTest, double scoreMidterm, double scoreFinal)
        {
            chGrade = getGrade(scoreHomework + scoreTest + scoreMidterm + scoreFinal);
            return chGrade;
        }

        private char getGrade(double score) 
        {
            if( score >= 80)
            {
                chGrade = 'A';
            }
            else if (score >= 70)
            {
                chGrade = 'B';
            }
            else if (score >= 60)
            {
                chGrade = 'C';
            }
            else if(score >= 50)
            {
                chGrade = 'D';
            }
            else
            {
                chGrade = 'F';
            }
            return chGrade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();

            Console.Write("Enter your score: ");
            double score = double.Parse(Console.ReadLine());
            char chGrade = std.ComputeGrade(score);
            Console.WriteLine("Your grade is {0}", chGrade);

            Console.ReadKey();
        }
    }
}
