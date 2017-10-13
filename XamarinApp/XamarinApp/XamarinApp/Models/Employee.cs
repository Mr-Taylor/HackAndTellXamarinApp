using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Team { get; set; }
        public string ReportsTo { get; set; }
        public string ImgSource { get; set; }
        public string LargeImgSource { get; set; }

        public string FullName => Name + " " + Surname;

    }
}
