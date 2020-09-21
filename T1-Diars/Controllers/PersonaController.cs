using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T1_Diars.Models;
using Microsoft.AspNetCore.Mvc;

namespace T1_Diars.Controllers
{
    public class PersonaController : Controller
    {
        private PersonaContext _context;
        public PersonaController(PersonaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var products = _context.Personas.ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create", new Persona());
        }

        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Personas.Add(persona);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", persona);
        }
    }
}