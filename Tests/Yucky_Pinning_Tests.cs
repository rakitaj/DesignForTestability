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
    public class Yucky_Pinning_Tests
    {
        [TestMethod()]
        public void Program_Run_With_FilterType_Name_And_Filter_T()
        {
            string expected_1 = "35323 Ted theRed 16 False";
            string expected_2 = "35323 Tina Turnbull 18 False";
            EmployeeDAL employeeDAL = new EmployeeDAL();
            var employees = employeeDAL.GetEmployees(new EmployeeNameFilter("T"));
            List<Employee> actual = employees.ToList();
            Assert.IsTrue(actual.Count == 2);
            Assert.AreEqual(expected_1, actual[0].ToString());
            Assert.AreEqual(expected_2, actual[1].ToString());
        }

        [TestMethod()]
        public void Program_Run_With_FilterType_Exempt_Any_Filter()
        {
            string expected_1 = "35323 Fred Flintstone 42 True";
            EmployeeDAL employeeDAL = new EmployeeDAL();
            var employees = employeeDAL.GetEmployees(new EmployeeExemptOnlyFilter());
            List<Employee> actual = employees.ToList();
            Assert.IsTrue(actual.Count == 1);
            Assert.AreEqual(expected_1, actual[0].ToString());
        }
    }
}
