using System;

namespace designIssueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            var employees = employeeDAL.GetEmployees(EmployeeFilterType.ByName, "T");
            //var employees = yucky.GetEmployees(EmployeeFilterType.ExemptOnly, null);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
