using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = x + 3;

            Console.Write("What is your first name? ");
            string myFirstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Your complete name is " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
