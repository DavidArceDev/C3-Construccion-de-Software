using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AlumnoBLL
    {
        private AlumnoDAL alumnoDAL;

        public AlumnoBLL()
        {
            alumnoDAL = new AlumnoDAL();
        }

        public List<Alumno> ListarAlumnos()
        {
            return alumnoDAL.Read();
        }

        public void EliminarAlumno(int alumnoId)
        {
            if(!alumnoDAL.Delete(alumnoId))
            {
                throw new Exception("No se ha podido eliminar al alumno");

            }
        }

        public bool ActualizarAlumno(Alumno alumno)
        {
            if (alumnoDAL.Update(alumno))
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
