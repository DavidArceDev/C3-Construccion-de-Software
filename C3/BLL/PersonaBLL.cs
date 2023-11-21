using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PersonaBLL
    {
        private PersonaDAL personaDAL;

        public PersonaBLL()
        {
            personaDAL = new PersonaDAL();
        }

        public List<Persona> ListarAlumnos()
        {
            return personaDAL.Read();
        }

        public void EliminarPersona(int personaId)
        {
            if (!personaDAL.Delete(personaId))
            {
                throw new Exception("No se ha podido eliminar la persona");

            }
        }

        public bool ActualizarPersona(Persona persona)
        {
            if (personaDAL.Update(persona))
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
