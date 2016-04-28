using System;
using System.Collections.Generic;

namespace designIssueExample
{
    class EmployeeDAL
    {

        public IEnumerable<Employee> GetEmployees(EmployeeFilterType employeeFilterType, string nameStartsWith)
        {
            if (employeeFilterType == EmployeeFilterType.ByName && nameStartsWith == null)
            {
                throw new ArgumentNullException("filter");
            }

            string query = "select * from employee, employee_role inner join employee.Id == employee_role.EmployeeId";

            List<Employee> result = CallDatabase.Execute(employeeFilterType, nameStartsWith, query);
            

            return result;
        }
    }
}
