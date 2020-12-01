using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSITDemo.Models;
using CSITDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSITDemo.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherServices _services;
        public TeacherController(ITeacherServices services)
        {
            _services = services;
        }
        public IActionResult Index()
        {
            var model = _services.GetTeacherModelsDB();
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetTeacherById(int id)
        {
            var model = _services.GetTeacherById(id);
            return View(model);
        }
    }
}
