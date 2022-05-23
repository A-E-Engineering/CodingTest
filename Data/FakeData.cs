using CodingTest.Models;

namespace CodingTest.Data
{
    public class FakeData
    {
        private List<Employee> Employees;
        public FakeData()
        {
            Employees = new List<Employee>();
            Employees.Add(new Employee { Name= "Calvin", EmployeeId = 1, Address="Stevens Point"});
            Employees.Add(new Employee { Name = "Lauren", EmployeeId = 2, Address = "Boise" });
            Employees.Add(new Employee { Name = "Chris", EmployeeId = 3, Address = "Greer" });
        }
        public List<Employee> GetEmployees()
        {
            return Employees;
        }

    }
}
