using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstrologySigns
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string name;
            int month;
            int day;
            int year;

            //greeting screen
            Console.WriteLine("\t \t Welcome To Sign Finder 3000!");
            Console.WriteLine("\t We will ask you a couple of questions to determine \n \t what your astrology sign is and what that means for you!");
            Console.WriteLine("\n\n\n \t Press any when ready!");
            Console.ReadLine();

            //gathering information
            Console.Clear();
            Console.WriteLine("Now to Find out a little bit about you.");
            Console.WriteLine("Please type in your name.");
            name = Console.ReadLine();
            Console.WriteLine("Birthday");
            month = Console.Read(); Console.Write("/"); day = Console.Read(); Console.Write("/"); year = Console.Read();

        }
    }
}
