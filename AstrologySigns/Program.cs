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
            string month;
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

            Console.Clear();
            Console.WriteLine("Nice to meet you {0}.",name);
            Console.WriteLine("What month were you born ?");

            Console.WriteLine("1. January \n2. February \n3. March \n4. April \n5. May \n6. June \n7. July \n8. August \n9. September \n10. October \n11. November \n12. December");
            month = Console.ReadLine();

            Console.WriteLine("Awesome, and what day in {0} were you born ?", month);
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Finally, in what year were you born ?");
            year = Convert.ToInt32(Console.ReadLine());

            //caculate their sign

            //check code
            Console.Clear();
            Console.WriteLine("Name:{0} \n Month:{1} \n Day:{2} \n Year:{3}", name, month, day, year);




        }
    }
}
