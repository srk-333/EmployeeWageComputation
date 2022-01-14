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
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            CalculateEmpWage.WageCompute();    // calling static method using class name.
            SwitchCase.PerformSwitchUse();    // calling Switch case method.
            Console.ReadLine();
        }
    }
}
