using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace DotNetTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating List for storing multiple employees at single place
            List < Employee > empList = new List<Employee>();
            empList.Add(new Employee(001, "Kamalesh Jikamade",5058900));
            empList.Add(new Employee(002, "Siddhesh Jikamade", 986700));
            empList.Add(new Employee(003, "Abhishek Jikamade", 8964100));
            empList.Add(new Employee(004, "Viraj Jikamade", 851100));
            empList.Add(new Employee(005, "Bhavana Jikamade", 985100));
            empList.Add(new Employee(006, "Ashwini Jikamade", 8964100));


            //printing the employee list 
            foreach (var item in empList)
            {
                Console.WriteLine("Employee Datails As Follows ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Employee Details :{0},{1},{2}",item.Id,item.Name,item.Salary);
            }


            //Linq query to sort employee salary in descending order
            List<int> orderBySalary2 = new List<int>();
            var orderBySalary = from sal in empList
                                orderby sal.Salary descending
                                select sal;
            
            Console.WriteLine("\n------------Descending Salary ---------------------");
            foreach (var descSalary in orderBySalary)
            {
                
                Console.WriteLine(descSalary.Salary);
                
            }

            //Linq query to fetch all employees  whose name starts with particular 
            var querySyntax1 = from employee in empList
                               where employee.Name.StartsWith("S")
                               select employee.Name;



            Console.WriteLine("------------Available String in Data----------------");
            foreach (var item in querySyntax1)
            {
                Console.WriteLine(item);
            }


            //Linq query to delete all employees  whose name starts with particular 
            var authors = empList.Where(a => a.Name.StartsWith("K"));
            empList = empList.Except(authors).ToList();
            empList = empList.Except(empList.Where(a => a.Name.StartsWith ("S"))).ToList();

            foreach (var item in empList)
            {
                Console.WriteLine("Emplloyee Reamains After Removing :");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Employee Details :{0},{1},{2}", item.Id, item.Name, item.Salary);
            }

        }
    }
}
