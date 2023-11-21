using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class MatriculaDAL
    {

        public void Create(Matricula matricula)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    db.Matricula.Add(matricula);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar matricula", ex);
            }
        }

        public List<Matricula> ListarMatriculasPorAlumno(int alumnoId)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    return db.Matricula.Where(m => m.AlumnoId == alumnoId).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Matricula ObtenerMatriculaPorId(int matriculaId)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    return db.Matricula.FirstOrDefault(m => m.MatriculaId == matriculaId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la matrícula: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public bool Update(Matricula matricula)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    Matricula matriculaExistente = db.Matricula.SingleOrDefault(m => m.MatriculaId == matricula.MatriculaId);

                    if(matriculaExistente != null)
                    {
                        matriculaExistente.Codigo = matricula.Codigo;
                        matriculaExistente.Fecha = matricula.Fecha;
                        matriculaExistente.Carrera = matricula.Carrera;
                        matriculaExistente.AnioMatricula = matricula.AnioMatricula;
                        matriculaExistente.SegmentoAcademico = matricula.SegmentoAcademico;

                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Matricula no encontrada en la base de datos");
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
                    db.Matricula.Remove(db.Matricula.Single(m => m.MatriculaId == id));
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

        public List<Matricula> buscarId(int id)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    return db.Matricula.Where(m => m.MatriculaId == id).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
