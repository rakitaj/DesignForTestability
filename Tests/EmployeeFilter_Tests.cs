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

        public Employee Over40Salaried()
        {
            return new Employee(16, "Old man salary", 55, true);
        }

        public Employee Under40Salaried()
        {
            return new Employee(17, "Under 40 salaried", 39, true);
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

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameFilter_With_Null_StartsWith__Should_Throw()
        {
            EmployeeNameFilter filter = new EmployeeNameFilter(null);
        }

        [TestMethod()]
        public void Employee_Under_40_And_Salaried__Should_Not_Match()
        {
            EmployeeExemptOnlyFilter filter = new EmployeeExemptOnlyFilter();
            Assert.IsFalse(filter.EmployeeMatches(Under40Salaried()));
        }

        [TestMethod()]
        public void Employee_Over_40_And_Salaried__Should_Match()
        {
            EmployeeExemptOnlyFilter filter = new EmployeeExemptOnlyFilter();
            Assert.IsTrue(filter.EmployeeMatches(Over40Salaried()));
        }
    }
}
