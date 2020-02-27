using System;
using System.Collections.Generic;


namespace ConsoleApp7
{
    class Program
    {
        public enum WeekDays {
            
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            List<String> tasklist = new List<string>();
            
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task " + day);
                string task = day + " S " + Console.ReadLine();
                tasklist.Add (task);
            }

            foreach (string task in tasklist)
            {
                Console.WriteLine(task);
            }


        }
    }
}
