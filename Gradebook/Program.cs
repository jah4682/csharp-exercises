﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gradebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");
            StringBuilder MyStringBuilder = new StringBuilder("");
            for (int i = 0; i < students.Count; i++)
            {
                MyStringBuilder.Append(students[i] + " (" + grades[i] + ")");
            }
            Console.WriteLine(MyStringBuilder);



            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
