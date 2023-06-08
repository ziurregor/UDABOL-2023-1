using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public Alumno[] Alumnos { get; set; }

        public string ErrorMessage { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet([FromServices] AlumnoClient client)
        {
            Alumnos = await client.GetAlumnosAsync();

            if (Alumnos.Count() == 0)
                ErrorMessage = "No existen registros que mostrar.";
            else
                ErrorMessage = string.Empty;
        }
    }
}
