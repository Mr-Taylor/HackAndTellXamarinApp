using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp.ViewModels
{
    class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public string Title { get; set; }

        private readonly IEmployeeRepository employeeRepository;
        public EmployeeListViewModel(JobTitleType type)
        {
            employeeRepository = new EmployeeRepository();

            if (type == JobTitleType.All)
            {
                Employees = employeeRepository.GetAllEmployees().OrderBy(x => x.Surname).ToList();
                Title = "All";
            }
            if (type == JobTitleType.Lead)
            {
                Employees = employeeRepository.GetAllEmployees().Where(x => x.JobTitle == "Team Lead").OrderBy(x => x.Surname).ToList();
                Title = "Team Leads";
            }
            if (type == JobTitleType.Manager)
            {
                Employees = employeeRepository.GetAllEmployees().Where(x => x.JobTitle == "Software Development Manager").OrderBy(x => x.Surname).ToList();
                Title = "Captain";
            }
        }
    }
}
