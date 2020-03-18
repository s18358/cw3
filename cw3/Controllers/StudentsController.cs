using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw3.Controllers
{
    
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        public string GetStudents()
        {
            return "Kowalski, Nowak";
        }
        [HttpGet("{id}")]
        public IActionResult GetStudenst(int id)
        {
            if(id == 1)
            {
                return Ok("Kowalski");
            } else if (id == 2)
            {
                return Ok("Nowak");
            }

            return NotFound("Nie ma studenta");
        }
    }
}