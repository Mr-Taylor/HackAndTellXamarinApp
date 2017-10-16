using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> AllEmployees = new List<Employee>();

            Employee hadwin = new Employee
            {
                Name = "Hadwin",
                Surname = "Valentine",
                JobTitle = "Team Lead",
                Email = "hadwinv@mobile.co.za",
                Team = "Origination",
                ReportsTo = "Riaan",
                ImgSource = "hadwin_small.jpg",
                LargeImgSource = "hadwin.jpg"
            };

            AllEmployees.Add(hadwin);

            Employee bruce = new Employee
            {
                Name = "Bruce",
                Surname = "McLaren",
                JobTitle = "Team Lead",
                Email = "brucem@mobile.co.za",
                Team = "Credit",
                ReportsTo = "Riaan",
                ImgSource = "bruce_small.jpg",
                LargeImgSource = "bruce.jpg"
            };

            AllEmployees.Add(bruce);

            Employee johnnie = new Employee
            {
                Name = "Johnnie",
                Surname = "van Eeden",
                JobTitle = "Team Lead",
                Email = "johnnie@mobile.co.za",
                Team = "International",
                ReportsTo = "Riaan",
                ImgSource = "johnnie_small.jpg",
                LargeImgSource = "johnnie.jpg"
            };

            AllEmployees.Add(johnnie);

            Employee roelof = new Employee
            {
                Name = "Roelof",
                Surname = "Briers",
                JobTitle = "Team Lead",
                Email = "roloef@mobile.co.za",
                Team = "Digital",
                ReportsTo = "Riaan",
                ImgSource = "roelof_small.jpg",
                LargeImgSource = "roelof.jpg"
            };

            AllEmployees.Add(roelof);


            Employee lwando = new Employee
            {
                Name = "Lwando",
                Surname = "Faku",
                JobTitle = "Team Lead",
                Email = "lwando@mobile.co.za",
                Team = "Collections",
                ReportsTo = "Riaan",
                ImgSource = "lwando_small.jpg",
                LargeImgSource = "lwando.jpg"
            };

            AllEmployees.Add(lwando);

            Employee juan = new Employee
            {
                Name = "Juan",
                Surname = "Venter",
                JobTitle = "Team Lead",
                Email = "juanv@mobile.co.za",
                Team = "Contact Center",
                ReportsTo = "Riaan",
                ImgSource = "juan_small.jpg",
                LargeImgSource = "juan.jpg"
            };

            AllEmployees.Add(juan);

            Employee stephan = new Employee
            {
                Name = "Stephan",
                Surname = "Moolman",
                JobTitle = "Software Developer",
                Email = "stephanm@mobile.co.za",
                Team = "Contact Center",
                ReportsTo = "Juan",
                ImgSource = "stephan_small.jpg",
                LargeImgSource = "stephan.jpg"
            };

            AllEmployees.Add(stephan);

            Employee ruzeed = new Employee
            {
                Name = "Ruzeed",
                Surname = "Baartman",
                JobTitle = "Snr Software Developer",
                Email = "ruzeedb@mobile.co.za",
                Team = "Origination",
                ReportsTo = "Hadwin",
                ImgSource = "ruzeed_small.jpg",
                LargeImgSource = "ruzeed.jpg"
            };

            AllEmployees.Add(ruzeed);

            Employee nino = new Employee
            {
                Name = "Nino",
                Surname = "Smith",
                JobTitle = "Jnr Software developer",
                Email = "nino@mobile.co.za",
                Team = "Origination",
                ReportsTo = "Hadwin",
                ImgSource = "nino_small.jpg",
                LargeImgSource = "nino.jpg"
            };

            AllEmployees.Add(nino);

            Employee ncedo = new Employee
            {
                Name = "Ncedo",
                Surname = "Matseke",
                JobTitle = "Jnr Software Developer",
                Email = "ncedo@mobile.co.za",
                Team = "Origination",
                ReportsTo = "Hadwin",
                ImgSource = "ncedo_small.jpg",
                LargeImgSource = "ncedo.jpg"
            };

            AllEmployees.Add(ncedo);

            Employee stephanus = new Employee
            {
                Name = "Stephanus",
                Surname = "Du Plessis",
                JobTitle = "Snr Software Developer",
                Email = "stephanus@mobile.co.za",
                Team = "Finance",
                ReportsTo = "Riaan",
                ImgSource = "stephanus_small.jpg",
                LargeImgSource = "stephanus.jpg"
            };

            AllEmployees.Add(stephanus);

            Employee neil = new Employee
            {
                Name = "Neil",
                Surname = "Hattingh",
                JobTitle = "Snr Software Developer",
                Email = "neil@mobile.co.za",
                Team = "Credit",
                ReportsTo = "Bruce",
                ImgSource = "neil_small.jpg",
                LargeImgSource = "neil.jpg"
            };

            AllEmployees.Add(neil);

            Employee david = new Employee
            {
                Name = "David",
                Surname = "Tyler",
                JobTitle = "Software Developer",
                Email = "david@mobile.co.za",
                Team = "Credit",
                ReportsTo = "Bruce",
                ImgSource = "david_small.jpg",
                LargeImgSource = "david.jpg"
            };

            AllEmployees.Add(david);

            Employee zolisa = new Employee
            {
                Name = "Zolisa",
                Surname = "Welani",
                JobTitle = "Jnr Software Developer",
                Email = "hadwinv@mobile.co.za",
                Team = "Credit",
                ReportsTo = "Bruce",
                ImgSource = "zolisa_small.jpg",
                LargeImgSource = "zolisa.jpg"
            };

            AllEmployees.Add(zolisa);

            Employee kobus = new Employee
            {
                Name = "Kobus",
                Surname = "Smit",
                JobTitle = "Snr Software Developer",
                Email = "smit@mobile.co.za",
                Team = "International",
                ReportsTo = "Johnnie",
                ImgSource = "kobus_small.jpg",
                LargeImgSource = "kobus.jpg"
            };

            AllEmployees.Add(kobus);

            Employee vuyisa = new Employee
            {
                Name = "Vuyisa",
                Surname = "Mntabeko",
                JobTitle = "Software Developer",
                Email = "vuyisa@mobile.co.za",
                Team = "Digital",
                ReportsTo = "Roelof",
                ImgSource = "vuyisa_small.jpg",
                LargeImgSource = "vuyisa.jpg"
            };

            AllEmployees.Add(vuyisa);

            Employee fabio = new Employee
            {
                Name = "Fabio",
                Surname = "Piemontesi",
                JobTitle = "Snr Software Developer",
                Email = "fabio@mobile.co.za",
                Team = "Digital",
                ReportsTo = "Roelof",
                ImgSource = "fabio_small.jpg",
                LargeImgSource = "fabio.jpg"
            };

            AllEmployees.Add(fabio);

            Employee dono = new Employee
            {
                Name = "Donovan",
                Surname = "Meyers",
                JobTitle = "Snr Software Developer",
                Email = "donovan@mobile.co.za",
                Team = "Digital",
                ReportsTo = "Roelof",
                ImgSource = "donovan_small.jpg",
                LargeImgSource = "donovan.jpg"
            };

            AllEmployees.Add(dono);

            Employee francois = new Employee
            {
                Name = "Francois",
                Surname = "Sayster",
                JobTitle = "Software Developer",
                Email = "franscois@mobile.co.za",
                Team = "Digital",
                ReportsTo = "Roelof",
                ImgSource = "francois_small.jpg",
                LargeImgSource = "francois.jpg"
            };

            AllEmployees.Add(francois);

            Employee charl = new Employee
            {
                Name = "Charl",
                Surname = "Meyer",
                JobTitle = "Jnr Software Developer",
                Email = "charl@mobile.co.za",
                Team = "Collections",
                ReportsTo = "Lwando",
                ImgSource = "charl_small.jpg",
                LargeImgSource = "charl.jpg"
            };

            AllEmployees.Add(charl);

            Employee stefan = new Employee
            {
                Name = "Stefan",
                Surname = "Van Der Merwe",
                JobTitle = "Snr Software Developer",
                Email = "stefan@mobile.co.za",
                Team = "Collections",
                ReportsTo = "Riaan",
                ImgSource = "stefan_small.jpg",
                LargeImgSource = "stefan.jpg"
            };

            AllEmployees.Add(stefan);

            Employee riaan = new Employee
            {
                Name = "Riaan",
                Surname = "Koegelenberg",
                JobTitle = "Software Development Manager",
                Email = "riaan@mobile.co.za",
                Team = "Management",
                ReportsTo = "Rudy",
                ImgSource = "riaan_small.jpg",
                LargeImgSource = "riaan.jpg"
            };

            AllEmployees.Add(riaan);

            return AllEmployees;
        }
    }
}
