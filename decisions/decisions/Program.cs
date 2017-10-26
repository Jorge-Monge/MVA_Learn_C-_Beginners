using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Bob's Big Giveway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            /*
            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
            {
                message = "Sorry. You should have selected one of the 3 options! ";
                message += "You loose.";
            }
            Console.WriteLine(message);
            Console.ReadLine();
             */

            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You entered {0}, therefore you won a {1}.", userValue, message);
            Console.ReadLine();
        }
    }
}
