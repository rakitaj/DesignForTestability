using designIssueExample.Filters;
using System;

namespace designIssueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            //var employees = employeeDAL.GetEmployees(new EmployeeNameFilter("T"));
            var employees = employeeDAL.GetEmployees(new EmployeeExemptOnlyFilter());

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
