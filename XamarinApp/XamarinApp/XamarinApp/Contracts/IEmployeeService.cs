using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp.Contracts
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployeeByName(string name);

        List<Employee> GetEmployeesByReportTo(string reportTo);

        List<Employee> GetEmployeesByJobTitleType(string jobTitleType);
    }
}
