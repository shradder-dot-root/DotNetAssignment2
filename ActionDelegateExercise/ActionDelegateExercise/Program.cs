using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ActionDelegateExercise.SquareRoot;

namespace ActionDelegateExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action delegate with Anonymous function  

            Action<string> printString = delegate (string Uinput)
            {
                Console.WriteLine("Inside anonymous Function");
                Console.WriteLine(Uinput);
            };
            printString("Hello its a Action Delegate..");

        }
    }
}











