using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class MatriculaBLL
    {
        private MatriculaDAL matriculaDAL;
        private AlumnoDAL alumnoDAL;

        public MatriculaBLL()
        {
            matriculaDAL = new MatriculaDAL();
            alumnoDAL = new AlumnoDAL();
        }

        public Matricula ObtenerMatriculaPorId(int matriculaId)
        {
            return matriculaDAL.ObtenerMatriculaPorId(matriculaId);
        }

        public bool AgregarMatricula(Matricula matricula)
        {
            try
            {

                if (alumnoDAL.ExisteAlumno(matricula.Alumno.AlumnoId))
                {

                    matriculaDAL.Create(matricula);
                    return true;
                }
                else
                {
                    MessageBox.Show("El alumno asociado a la matrícula no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la matrícula: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }

        public List<Matricula> ListarMatriculasPorAlumno(int alumnoId)
        {
            return matriculaDAL.ListarMatriculasPorAlumno(alumnoId);
        }

        public void EliminarMatricula(int matriculaId)
        {
            if(!matriculaDAL.Delete(matriculaId))
            {
                throw new Exception("No se ha podido eliminar la matricula");
            }
        }

        public bool ActualizarMatricula(Matricula matricula)
        {
            if (matriculaDAL.Update(matricula))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
