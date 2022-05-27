using System;
using System.Collections.Generic;
using CodingTest.Models;

namespace CodingTest.Data
{
    public interface IEmployeeRepository : IDisposable
    {
        //Returns all employee entities from FakeData.cs
        IEnumerable<Employee> GetEmployees();
        //Finds a single employee by ID
        Employee GetEmployeeByID(int employeeId);
        void InsertEmployee(Employee employee);
        void DeleteEmployee(int employeeID);
        void UpdateEmployee(Employee employee);
        void Save();
    }
}