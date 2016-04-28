﻿using System;

namespace designIssueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Yucky yucky = new Yucky();
            //var employees = yucky.GetEmployees(EmployeeFilterType.ByName, "T", new FakeSqlConnection());
            var employees = yucky.GetEmployees(EmployeeFilterType.ExemptOnly, null, new FakeSqlConnection());

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
