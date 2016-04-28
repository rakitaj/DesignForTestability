﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designIssueExample.Filters
{
    public class EmployeeNameFilter : EmployeeFilter
    {
        public String NameStartsWith { get; private set; }

        public EmployeeNameFilter(string nameStartsWith)
        {
            if(nameStartsWith == null)
            {
                throw new ArgumentNullException("filter");
            } else
            {
                this.NameStartsWith = nameStartsWith;
            }
        }

        public override bool EmployeeMatches(Employee employee)
        {
            bool result = false;
            if(employee.Name.StartsWith(this.NameStartsWith))
            {
                result = true;
            }
            return result;
        }
    }
}
