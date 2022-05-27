using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using CodingTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingTest.Data
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        //use FakeData as our current context
        private FakeData _context;

        public EmployeeRepository()
        {
            _context = new FakeData();
        }

        public EmployeeRepository(FakeData context)
        {
            this._context = context;
        }

        //Calls GetEmployees from FakeData to display all items in the list
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.GetEmployees();
        }


        public Employee GetEmployeeByID(int id)
        {
            //Lambda expression to get employee ID
            return _context.GetEmployees().FirstOrDefault(x => x.EmployeeId == id);
            //throw new NotImplementedException();
        }

        public void InsertEmployee(Employee employee)
        {
            //Currently unused
            //_context.Employees.Add(employee);
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int employeeID)
        {
            //Currently unused
            //Employee employee = _context.Employees.Find(employeeID);
            //_context.Employees.Remove(employee);
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            //Currently unused
            //_context.Entry(employee).State = EntityState.Modified;
            throw new NotImplementedException();
        }

        public void Save()
        {
            //Currently unused
            //_context.SaveChanges();
            throw new NotImplementedException();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            /*if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;*/
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
