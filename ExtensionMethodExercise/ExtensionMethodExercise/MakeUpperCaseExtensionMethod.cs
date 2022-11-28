using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExercise
{
    public static class MakeUpperCaseExtensionMethod
    {
        public static string ChangeToUpperCase(this string userString)
        {
        if (userString.Length > 0)
            {
                string outputString = userString.ToUpper();
                //Console.WriteLine(outputString);
                return outputString;
            }
            return userString;
        }
    }
}
