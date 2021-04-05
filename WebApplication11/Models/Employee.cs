using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {

    }

        public DbSet<Employee> Employees { get; set; }

}
    public class Employee

    {
        public int Id { get; set; }
       
        public string Campus { get; set; }
       
        public string  Code { get; set; }
        public string Gender{ get; set; }
        public string EmpName { get; set; }
        public string FatherName { get; set; }
        public string Cnic { get; set; }
        public string Designation { get; set; }
        public string Qualification { get; set; }
        public string Bloodgroup{ get; set; }
        public string Maritalstatus { get; set; }
        public DateTime Joiningdate{ get; set; }
        public DateTime Terminationdate { get; set; }
        public string Salarytype { get; set; }
        public string Salarypackage{ get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Naration { get; set; }
        public string Pannumber { get; set; }
        public int Esinumber { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Accnumber{ get; set; }
        public string Branchcode { get; set; }
        public DateTime Passportexpirydate  { get; set; }
        public DateTime Visaexpirydate { get; set; }
        public DateTime Labourcardexpirydate { get; set; }
        public string Pfnumber { get; set; }
        public string Address{ get; set; }
        public string Mobilenumber { get; set; }
        public string Bankname{ get; set; }
        public string Branchname { get; set; }
        public string Passportno { get; set; }
        public string Visano { get; set; }
        public string Labourcardno { get; set; }
        public string University { get; set; }
        public string Grade { get; set; }
        public string Subjectexpert { get; set; }



    }
}
