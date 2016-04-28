using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designIssueExample.Filters
{
    public abstract class EmployeeFilter
    {
        public abstract bool MatchesFilter(Employee employee);
    }
}
