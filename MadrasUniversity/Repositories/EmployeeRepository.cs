using MadrasUniversity.DAO;
using MadrasUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MadrasUniversity.Repositories
{
    
    public class EmployeeRepository
    {
        private EmployeeContext db;
        public List<Employee> GetEmployees()
        {
            db = new EmployeeContext();
            return db.Employees.ToList();
        }

        public List<Department> GetDepartments()
        {
            db = new EmployeeContext();
            return db.Departments.Include("Employees").ToList();
        }

    }
}