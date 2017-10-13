using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Contracts;
using XamarinApp.Models;

namespace XamarinApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository employeeRepository;

        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }
        public List<Employee> GetAllEmployees()
        {
            var allEmployees = employeeRepository.GetAllEmployees().OrderBy(x => x.Surname).ToList();
            return allEmployees;
        }

        public Employee GetEmployeeByName(string name)
        {
            var employee = GetAllEmployees().FirstOrDefault(x => x.Name == name);
            return employee;
        }

        public List<Employee> GetEmployeesByJobTitleType(string jobTitleType)
        {
            var employees = GetAllEmployees().Where(x => x.JobTitle == jobTitleType).ToList();
            return employees;
        }

        public List<Employee> GetEmployeesByReportTo(string reportTo)
        {
            var employees = GetAllEmployees().Where(x => x.ReportsTo == reportTo).ToList();
            return employees;
        }
    }
}
