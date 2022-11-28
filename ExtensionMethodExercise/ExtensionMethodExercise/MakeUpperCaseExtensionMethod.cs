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
                return outputString;
            }
            return userString;
        }
    }
}



//Dictionary<Department, List<Employee>>()
//Dictionary<Department.Name, List<Employee>>()
