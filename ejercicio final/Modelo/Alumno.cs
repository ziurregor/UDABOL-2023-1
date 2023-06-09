using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class Alumno
    {
            [Key]
            [Column("id")]
            public int id { get; set; }
            public string? Nombre { get; set; }
            public string? PrimerRegistro { get; set; }
            public string? CorreoPersonal { get; set; }
            public string? CorreoUdabol { get; set; }
            public string? Codigo { get; set; }
            public string? Verificacion { get; set; }
            public bool IsActive { get; set; }
            public int Ex_GIT_6PTS { get; set; }
            public int Ex_ADOO_8PTS { get; set; }
            public int Ex_ScrumTra_41PTS { get; set; }
            public int Ex_SOLID_8PTS { get; set; }
            public int Ex_12FactApp_12PTS { get; set; }
            public int Ex_Docker_5PTS { get; set; }

        //public int Edad { get; set; }
        //public string? Contraseña { get; set; }

    }
}

