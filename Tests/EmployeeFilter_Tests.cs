using designIssueExample.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designIssueExample.Tests
{
    [TestClass()]
    public class EmployeeFilter_Tests
    {
        [TestMethod()]
        public void TommyBoy__Should_Match_Starts_With_Tom()
        {
            Employee employee1 = new Employee(15, "Tommy Boy", 26, true);
            EmployeeNameFilter filter = new EmployeeNameFilter("Tom");
            Assert.IsTrue(filter.MatchesFilter(employee1));
        }

        [TestMethod()]
        public void Tommy_Boy__Should_Not_Match_Starts_With_A()
        {
            Employee employee1 = new Employee(15, "Tommy Boy", 26, true);
            EmployeeNameFilter filter = new EmployeeNameFilter("A");
            Assert.IsFalse(filter.MatchesFilter(employee1));
        }
    }
}
