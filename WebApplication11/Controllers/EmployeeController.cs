using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers

{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _context;
        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }


        public ActionResult Index()
        {
            var list = _context.Employees.ToList();

            return View(list);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
           
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return View();
        }
        public ActionResult Delete(int id)
        {
            var emp = _context.Employees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }

            return View(emp);
        }

        [HttpPost]
        public ActionResult Delete(Employee emp)
        {
            var per = _context.Employees.Find(emp.Id);
            if (per != null)
            {
                _context.Employees.Remove(per);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(per);
        }
        public ActionResult Update(int id)
        {
            var edt = _context.Employees.Where(k => k.Id == id).FirstOrDefault();

            return View(edt);
        }
        [HttpPost]
        public ActionResult Update(Employee emp)
        {
            var per = _context.Employees.Find(emp.Id);
            if (per != null)
            {
                 per.Campus = emp.Campus;
                per.Code = emp.Code;
                per.Cnic = emp.Cnic;
                per.Accnumber = emp.Accnumber;
                per.Address = emp.Address;
                per.Bankname = emp.Bankname;
                per.Bloodgroup = emp.Bloodgroup;
                per.Branchcode = emp.Branchcode;
                per.Branchname = emp.Branchname;
                per.Dateofbirth = emp.Dateofbirth;
                per.Designation = emp.Designation;
                per.Email = emp.Email;
                per.EmpName = emp.EmpName;
                per.Esinumber = emp.Esinumber;
                per.FatherName = emp.FatherName;
                per.Gender = emp.Gender;
                per.Grade = emp.Grade;
                per.Labourcardexpirydate = emp.Labourcardexpirydate;
                per.Labourcardno = emp.Labourcardno;
                per.Maritalstatus = emp.Maritalstatus;
                per.Mobilenumber = emp.Mobilenumber;
                per.Naration = emp.Naration;
                per.Pannumber = emp.Pannumber;
                per.Passportexpirydate = emp.Passportexpirydate;
                per.Passportno = emp.Passportno;
                per.Pfnumber = emp.Pfnumber;
                per.Phonenumber = emp.Phonenumber;
                per.Qualification = emp.Qualification;
                per.Salarypackage = emp.Salarypackage;
                per.Salarytype = emp.Salarytype;
                per.Terminationdate = emp.Terminationdate;
                per.Joiningdate = emp.Joiningdate;
                per.University = emp.University;
                per.Visano = emp.Visano;
                per.Visaexpirydate = emp.Visaexpirydate;
              
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
       
        public ActionResult New()
        {

            return View();
        }


    }
}