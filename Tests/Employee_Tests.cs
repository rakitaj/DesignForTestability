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
    public class Employee_Tests
    {
        public Employee JakeDoe()
        {
            Employee e = new Employee(10, "Jake Doe", 25, false);
            return e;
        }

        [TestMethod()]
        public void Employee_ToString__Should_Be_Correctly_Formatted()
        {
            string expected = "10 Jake Doe 25 False";
            Assert.AreEqual(expected, JakeDoe().ToString());
        }

        [TestMethod()]
        public void Jake_Doe_Applying_Name_Filter_Starts_With_Jak__Should_Be_True()
        {
            EmployeeNameFilter filter = new EmployeeNameFilter("Jak");
            Assert.IsTrue(JakeDoe().MatchesFilter(filter));
        }

        [TestMethod()]
        public void Jake_Doe_Applying_Name_Filter_Starts_With_Z__Should_Be_False()
        {
            EmployeeNameFilter filter = new EmployeeNameFilter("Z");
            Assert.IsFalse(JakeDoe().MatchesFilter(filter));
        }
    }
}
