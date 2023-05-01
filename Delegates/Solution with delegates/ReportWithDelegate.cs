using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_refresh.Delegates.Solution_with_delegates
{
    public class ReportWithDelegate
    {
        public delegate bool IllegibleSales(EmployeeWithDelegate e);
        public void ProcessEmployee(EmployeeWithDelegate[] employees, string title, IllegibleSales isIlligible)
        {
            Console.WriteLine(title);
            Console.WriteLine("-------------------------------");
            foreach (EmployeeWithDelegate employee in employees)
            {
                if (isIlligible(employee))
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | {employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
