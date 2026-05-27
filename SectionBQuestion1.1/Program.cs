using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionBQuestion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Structure of a C# Program Demo!\n" +
                "Enter your name: ");
            //user enters their name
            string name = Console.ReadLine();

            //display the user's name on the console
            Console.Write("Hello " + name + "!\n\n" +
                "Program Structure Demonstrated:\n" +
                "1. using System : imports functionality\n" +
                "2. namespace : organizes code\n" +
                "3. class Program : container for code\n" +
                "4. Main() : entry poitn of program\n" +
                "5. Comments : explain logic and documentation\n\n" +
                "Program exectured successfully!\n");

        }
    }
}
