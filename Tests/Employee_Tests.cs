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
        [TestMethod()]
        public void Employee_ToString__Should_Be_Correctly_Formatted()
        {
            Employee e = new Employee(10, "Jake Doe", 25, false);
            string expected = "10 Jake Doe 25 False";
            Assert.AreEqual(expected, e.ToString());
        }
    }
}
