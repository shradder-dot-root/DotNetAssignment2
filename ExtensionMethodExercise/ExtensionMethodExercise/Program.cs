using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Enter a String to Reverse :  ");
            string user = Console.ReadLine();

            Console.WriteLine("-------------------------------\n");
           string reversedString  = user.ReverseExMethod();
            Console.WriteLine("Reversed String is :" + reversedString);

            Console.WriteLine("-------------------------------\n");


            string upperCase = user.ChangeToUpperCase();
            Console.WriteLine("Upper case String is :" + upperCase);
            Console.WriteLine("-------------------------------\n");
*/
            Action<string> printString = delegate (string i)
            {
                Console.WriteLine("Enter string");
                string j = Console.ReadLine();
                Console.WriteLine(j);
            };

            printString("hel");
        }
    }
}
