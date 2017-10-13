using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
    }
}
