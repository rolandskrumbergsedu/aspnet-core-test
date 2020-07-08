using AspNetCoreTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTest.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person();
            person.Name = "Rolands";
            person.Surname = "Krumbergs";
            person.Email = "rolands.krumbergs@outlook.com";
            person.Age = 28;
            person.Address = "GDPR";
            person.IsMale = true;

            return View(person);
        }
    }
}
