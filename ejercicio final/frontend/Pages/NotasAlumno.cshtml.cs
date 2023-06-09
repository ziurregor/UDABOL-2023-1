using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace frontend.Pages
{
    public class NotasAlumnoModel : PageModel
    {
        private readonly AlumnoClient _alumnoClient;

        public Alumno Alumno { get; private set; }

        public NotasAlumnoModel(AlumnoClient alumnoClient)
        {
            _alumnoClient = alumnoClient;
        }

        public async Task OnGetAsync(string codigo)
        {
            Alumno = await _alumnoClient.GetAlumnoPorCodigoAsync(codigo);
        }

        //public async Task OnGetAsync()
        //{
        //    Alumno = await _alumnoClient.GetAlumnoPorCodigoAsync("38330");
        //}
    }
}
