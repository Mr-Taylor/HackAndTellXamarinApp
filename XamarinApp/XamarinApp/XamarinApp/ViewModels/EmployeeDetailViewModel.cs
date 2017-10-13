using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Models;

namespace XamarinApp.ViewModels
{
    public class EmployeeDetailViewModel
    {
        public Employee Employee { get; set; }
        public List<Employee> TeamMembers { get; set; } = new List<Employee>();

        private readonly IEmployeeRepository employeeRepository;

        public EmployeeDetailViewModel(Employee employee)
        {
            employeeRepository = new EmployeeRepository();

            Employee = employee;
            TeamMembers = employeeRepository.GetAllEmployees().Where(x => x.ReportsTo == employee.Name).ToList();
        }
    }
}
