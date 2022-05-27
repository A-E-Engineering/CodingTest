using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodingTest.Data;
using CodingTest.Models;

namespace CodingTest.Controllers
{
    public class EmployeeController : Controller
    {
        //private readonly CodingTestContext _context;

        private IEmployeeRepository employeeRepository;

        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository();
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            var employees = employeeRepository.GetEmployees();
            return View(employees);
        }

        //
        // GET: /Employee/Details/5

        public ViewResult Details(int id)
        {
            Employee employee = employeeRepository.GetEmployeeByID(id);
            return View(employee);
        }
    }
}
