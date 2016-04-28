using System;
namespace designIssueExample
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool IsSalaried { get; private set; }

        public Employee(int id, string name, int age, bool isSalaried)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.IsSalaried = isSalaried;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Id, Name, Age, IsSalaried);
        }
    }
}
