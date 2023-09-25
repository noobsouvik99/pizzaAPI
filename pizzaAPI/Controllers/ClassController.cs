using System;
using pizzaAPI.Services;
using Microsoft.AspNetCore.Mvc;
using pizzaAPI.Models;

namespace pizzaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassController : ControllerBase
    {

        ClassService classService = new ClassService();
        public ClassController()
        {

        }
        [HttpGet]
        public ActionResult<List<Class>> GetAllClasses()
        {

            return classService.GetClasses();
        }
        [HttpGet("{name}")]
        public ActionResult<Class> GetClassByName(string name)
        {
            return classService.GetClassByName(name);
        }
    }
}

