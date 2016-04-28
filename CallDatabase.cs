using designIssueExample.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designIssueExample
{
    class CallDatabase
    {
        private const int EmployeeIdColumnIndex = 0;
        private const int EmployeeNameColumnIndex = 1;
        private const int EmployeeAgeColumnIndex = 2;
        private const int EmployeeIsSalariedColumnIndex = 3;

        public static List<Employee> GetAllEmployees(string query)
        {
            List<Employee> employees = new List<Employee>();
            FakeSqlConnection connection = new FakeSqlConnection();
            using (FakeSqlCommand sqlCommand = new FakeSqlCommand(query, connection))
            {
                FakeSqlDataReader reader;
                int retryCount = 5;

                while (true)
                {
                    try
                    {
                        reader = sqlCommand.ExecuteReader();
                        break;
                    }
                    catch (Exception)
                    {
                        if (retryCount-- == 0) throw;
                    }
                }

                while (reader.Read())
                {
                    int id = reader.GetInt32(EmployeeIdColumnIndex);
                    string name = reader.GetString(EmployeeNameColumnIndex);
                    int age = reader.GetInt32(EmployeeAgeColumnIndex);
                    bool isSalaried = reader.GetBoolean(EmployeeIsSalariedColumnIndex);

                    employees.Add(new Employee(id, name, age, isSalaried));
                }
            }
            return employees;
        }
    }
}
