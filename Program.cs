using C_Sharp_refresh.Delegates.Solution_with_delegates;
using C_Sharp_refresh.Delegates.Solution_without_delegates;
using C_Sharp_refresh.Indexers;

Console.ForegroundColor = ConsoleColor.Green;

var emps = new Employee[]
{
    new Employee {Id=1,Name = "Waheb", Gender = "M", TotalSales = 65000m},
    new Employee {Id=2,Name = "Firas", Gender = "M", TotalSales = 50000m},
    new Employee {Id=2,Name = "Biba", Gender = "F", TotalSales = 15000m}
};

var empsWithDelegate = new EmployeeWithDelegate[]
{
    new EmployeeWithDelegate {Id=1,Name = "Waheb", Gender = "M", TotalSales = 65000m},
    new EmployeeWithDelegate {Id=2,Name = "Firas", Gender = "M", TotalSales = 50000m},
    new EmployeeWithDelegate {Id=2,Name = "Biba", Gender = "F", TotalSales = 15000m}
};

var report = new Report();

report.PrecessEmployeeWith60000PlusSales(emps);
report.PrecessEmployeeWithSalesBetween30000And59999(emps);
report.PrecessEmployeeWithSalesLessThan30000(emps);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("---------------------------------------------------------------------------------");
Console.WriteLine("Solution with Delegates");

var reportWithDelegate = new ReportWithDelegate();
reportWithDelegate.ProcessEmployee(empsWithDelegate, "Sales more than 60,000", delegate (EmployeeWithDelegate e) { return e.TotalSales > 60000m; });
reportWithDelegate.ProcessEmployee(empsWithDelegate, "Sales Between 30,000 and 59999", delegate (EmployeeWithDelegate e) { return e.TotalSales >= 30000m && e.TotalSales < 59999m; });
reportWithDelegate.ProcessEmployee(empsWithDelegate, "Sales less than 30,000", delegate (EmployeeWithDelegate e) { return e.TotalSales < 30000m; });

