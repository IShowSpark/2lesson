using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What name second person?");
            string name2 = Console.ReadLine();
            if (name=="Artjom" && name2 == "Timofei" || name=="Timofei" && name2=="Artjom")
            {
                Console.WriteLine($"{name} and {name2} sit together");
            }
            else if (name == "German" && name2 == "Kevin" || name=="Kevin" && name2 == "German")
            {
                Console.WriteLine($"{name} and {name2} sit together");
            }
            else if (name == "Ilya" && name2 == "Anton" || name == "Anton" && name2 == "Ilya")
            {
                Console.WriteLine($"{name} and {name2} sit together");
            }
            else if (name == "Denis" && name2 == "Artjom" || name == "Artjom" && name2 == "Denis")
            {
                Console.WriteLine($"{name} and {name2} sit together");
            }
            else
            {
                Console.WriteLine("Neighbors is out");
            }





        }
    }
}
