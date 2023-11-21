using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace DAL
{
    public class AlumnoDAL
    {
        public void Create (Alumno alumno)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    db.Alumno.Add(alumno);
                    db.SaveChanges();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Alumno> Read()
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    return db.Alumno.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool Update(Alumno alumno)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    Alumno alumnoExistente = db.Alumno.SingleOrDefault(a => a.AlumnoId == alumno.AlumnoId);

                    if(alumnoExistente != null)
                    {
                        alumnoExistente.FechaIngreso = alumno.FechaIngreso;
                        alumnoExistente.CarreraActual = alumno.CarreraActual;
                        alumnoExistente.EstadoAcademico = alumno.EstadoAcademico;

                        alumnoExistente.Persona.Run = alumno.Persona.Run;
                        alumnoExistente.Persona.Nombre = alumno.Persona.Nombre;
                        alumnoExistente.Persona.Apellido = alumno.Persona.Apellido;
                        alumnoExistente.Persona.FechaNacimiento = alumno.Persona.FechaNacimiento;
                        alumnoExistente.Persona.Direccion = alumno.Persona.Direccion;
                        alumnoExistente.Persona.EstadoCivil = alumno.Persona.EstadoCivil;

                        // Guardar los cambios en la base de datos
                        db.SaveChanges();

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Alumno no encontrado en la base de datos");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    db.Alumno.Remove(db.Alumno.Single(a => a.AlumnoId == id));
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<Alumno> buscarId(int id)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    return db.Alumno.Where(a => a.AlumnoId == id).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool ExisteAlumno(int alumnoId)
        {
            using (MatriculasDbContext db = new MatriculasDbContext())
            {
                return db.Alumno.Any(a => a.AlumnoId == alumnoId);
            }
        }

    }
}
