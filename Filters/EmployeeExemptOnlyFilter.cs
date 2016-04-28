using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designIssueExample.Filters
{
    public class EmployeeExemptOnlyFilter : EmployeeFilter
    {
        public EmployeeExemptOnlyFilter()
        {

        }

        public override bool EmployeeMatches(Employee employee)
        {
            bool result = false;
            if(employee.IsSalaried && 40 < employee.Age)
            {
                result = true;
            }
            return result;
        }
    }
}
