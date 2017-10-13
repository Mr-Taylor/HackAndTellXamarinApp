using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Contracts;
using XamarinApp.Models;
using XamarinApp.Services;

namespace XamarinApp.ViewModels
{
    public class EmployeeDetailViewModel
    {
        public Employee Employee { get; set; }
        public List<Employee> TeamMembers { get; set; } = new List<Employee>();

        private readonly IEmployeeService employeeService;

        public EmployeeDetailViewModel(Employee employee)
        {
            employeeService = new EmployeeService();

            Employee = employee;
            TeamMembers = employeeService.GetEmployeesByReportTo(employee.Name).ToList();
        }
    }
}
