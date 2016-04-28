using designIssueExample.Filters;
using System;
using System.Collections.Generic;

namespace designIssueExample
{
    class EmployeeDAL
    {

        public IEnumerable<Employee> GetEmployees(EmployeeFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException("filter");
            }

            string query = "select * from employee, employee_role inner join employee.Id == employee_role.EmployeeId";

            List<Employee> employees = CallDatabase.GetAllEmployees(query);
            List<Employee> result = new List<Employee>();
            foreach(var employee in employees)
            {
                if(employee.MatchesFilter(filter))
                {
                    result.Add(employee);
                }
            }

            return result;
        }
    }
}
