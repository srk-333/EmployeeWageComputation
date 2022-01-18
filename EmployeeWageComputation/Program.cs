using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Program
    {
        // Main Method /Entry point
        static void Main(string[] args)
        {
            //printing message on console
            Console.WriteLine("Welcome To Employee Wage Computation Program \n");          
            CalculateEmpWage.WageCompute("Dmart", 30, 120, 25);    //calling static Method with parameters.
            CalculateEmpWage.WageCompute("Reliance", 25, 125, 24);
            CalculateEmpWage.WageCompute("Amazon", 40, 110, 22);
            Console.ReadLine();
        }
    }
}
