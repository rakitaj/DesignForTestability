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
        public Employee TommyBoy()
        {
            return new Employee(15, "Tommy Boy", 26, true);
        }

        [TestMethod()]
        public void TommyBoy__Should_Match_Starts_With_Tom()
        {
            
            EmployeeNameFilter filter = new EmployeeNameFilter("Tom");
            Assert.IsTrue(filter.EmployeeMatches(TommyBoy()));
        }

        [TestMethod()]
        public void Tommy_Boy__Should_Not_Match_Starts_With_A()
        {
            EmployeeNameFilter filter = new EmployeeNameFilter("A");
            Assert.IsFalse(filter.EmployeeMatches(TommyBoy()));
        }
    }
}
