using System; // this is a dependency. All the dependencies are impored with the key word "using" in C#.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Console_App // if you remember in Java there was a keyword "package". In C# instead of keyword "package", we use namespace
{
    class Program
    {
        public static string title = "C# Essential Traning";
        public static int whichPart;
        static void Main(string[] args)
        {
            whichPart = 2;
            var message = string.Format("Welcome to {0} Part {1}", title, whichPart);
            Console.WriteLine(message); // WriteLine will write the text inside the console.
            Console.WriteLine("Press enter to continue");
            Console.ReadLine(); // ReadLine will wait for the responce text untill user press enter again.

        }
    }
}
