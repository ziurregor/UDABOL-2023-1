using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ADO;
using Modelo;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnosController : ControllerBase
    {
        private readonly AlumnoRepository _alumnoRepository;

        public AlumnosController(AlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> GetAllAlumnos()
        {
            var alumnos = await _alumnoRepository.GetAllAlumno();
            return Ok(alumnos);
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Alumno>> GetAlumnoById(int id)
        //{
        //    var alumno = await _alumnoRepository.GetAlumnoById(id);
        //    if (alumno == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(alumno);
        //}

        [HttpGet("{codigo}")]
        public async Task<ActionResult<Alumno>> GetAlumnoByCodigo(string codigo)
        {
            var alumno = await _alumnoRepository.GetAlumnoByCodigo(codigo);
            if (alumno == null)
            {
                return NotFound();
            }
            return Ok(alumno);
        }

        [HttpPost]
        public async Task<IActionResult> AddAlumno(Alumno alumno)
        {
            await _alumnoRepository.AddAlumno(alumno);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAlumno(int id, Alumno alumno)
        {
            if (id != alumno.id)
            {
                return BadRequest();
            }
            await _alumnoRepository.UpdateAlumno(alumno);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumno(int id)
        {
            var alumno = await _alumnoRepository.GetAlumnoById(id);
            if (alumno == null)
            {
                return NotFound();
            }
            await _alumnoRepository.DeleteAlumno(alumno);
            return Ok();
        }
    }
}


