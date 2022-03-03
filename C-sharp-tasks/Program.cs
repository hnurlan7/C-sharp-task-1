using System;

namespace C_sharp_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month: ");
            string month = Console.ReadLine();
            Console.WriteLine("Season: ");
            if (month == "December" || month == "January" || month == "February")
            {
                Console.WriteLine("Winter");
            }
            else if (month == "March" || month == "April" || month == "May")
            {
                Console.WriteLine("Spring");
            }
            else if (month == "June" || month == "July" || month == "August")
            {
                Console.WriteLine("Summer");
            }
            else if (month == "September" || month == "October" || month == "November")
            {
                Console.WriteLine("Autumn");
            }
        }
    }
}
