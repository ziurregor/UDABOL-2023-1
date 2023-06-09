using System;
using ADO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo;


//ADO using TuProyecto.Data;

namespace ADO
{
    public class AlumnoRepository
    {
        //private readonly ApplicationDbContext _context;
        private readonly ApplicationDbContext _context;
        

        public AlumnoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Alumno>> GetAllAlumno()
        {
            return await _context.Alumnos.ToListAsync();
        }

        public async Task<Alumno> GetAlumnoById(int id)
        {
            return await _context.Alumnos.FindAsync(id);
        }

        public async Task<Alumno> GetAlumnoByCodigo(string codigo)
        {
            Alumno alumno = await _context.Alumnos.FirstOrDefaultAsync(a => a.Codigo == codigo);
            if (alumno == null)
            {
                throw new Exception("Alumno no encontrado");
            }
            return alumno;
        }


        public async Task AddAlumno(Alumno alumno)
        {
            _context.Alumnos.Add(alumno);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAlumno(Alumno alumno)
        {
            _context.Entry(alumno).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAlumno(Alumno alumno)
        {
            _context.Alumnos.Remove(alumno);
            await _context.SaveChangesAsync();
        }
    }
}

