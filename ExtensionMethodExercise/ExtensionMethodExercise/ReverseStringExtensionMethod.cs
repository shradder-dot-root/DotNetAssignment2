using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExercise
{
    public static class ReverseStringExtensionMethod
    {
        public static string ReverseExMethod(this string inputString)
        {
            if (inputString.Length <= 1)
            {
                return inputString;
            }

            char[] chars = inputString.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
