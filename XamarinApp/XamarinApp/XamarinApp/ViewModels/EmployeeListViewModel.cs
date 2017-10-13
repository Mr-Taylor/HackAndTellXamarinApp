using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Contracts;
using XamarinApp.Models;
using XamarinApp.Services;

namespace XamarinApp.ViewModels
{
    class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public string Title { get; set; }

        private readonly IEmployeeService employeeService;
        public EmployeeListViewModel(JobTitleType type)
        {
            employeeService = new EmployeeService();

            if (type == JobTitleType.All)
            {
                Employees = employeeService.GetAllEmployees().OrderBy(x => x.Surname).ToList();
                Title = "All";
            }
            if (type == JobTitleType.Lead)
            {
                Employees = employeeService.GetEmployeesByJobTitleType("Team Lead").ToList();
                Title = "Team Leads";
            }
            if (type == JobTitleType.Manager)
            {
                Employees = employeeService.GetEmployeesByJobTitleType("Software Development Manager").ToList();
                Title = "Captain";
            }
        }
    }
}
