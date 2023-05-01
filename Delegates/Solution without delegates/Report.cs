using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_refresh.Delegates.Solution_without_delegates
{
    public class Report
    {
        public void PrecessEmployeeWith60000PlusSales(Employee[] employees)
        {
            Console.WriteLine("Employee With $60,000+ sales");
            Console.WriteLine("-------------------------------");
            foreach (Employee employee in employees)
            {
                if (employee.TotalSales >= 60000m)
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name}| {employee.Gender}| {employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public void PrecessEmployeeWithSalesBetween30000And59999(Employee[] employees)
        {
            Console.WriteLine("Employee sales between 30000  and 59999");
            Console.WriteLine("---------------------------------------");
            foreach (Employee employee in employees)
            {
                if (employee.TotalSales < 60000m && employee.TotalSales >= 30000m)
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name}| {employee.Gender}| {employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public void PrecessEmployeeWithSalesLessThan30000(Employee[] employees)
        {
            Console.WriteLine("Employee With sales less than 30000");
            Console.WriteLine("-------------------------------");
            foreach (Employee employee in employees)
            {
                if (employee.TotalSales < 30000m)
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name}| {employee.Gender}| {employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
