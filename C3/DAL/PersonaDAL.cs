using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class PersonaDAL
    {
        public void Create(Persona persona)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    db.Persona.Add(persona);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Persona> Read()
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    return db.Persona.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool Update(Persona persona)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    db.Entry(persona).State = System.Data.Entity.EntityState.Modified;
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

        public bool Delete(int id)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    db.Persona.Remove(db.Persona.Single(p => p.PersonaId == id));
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



        public List<Persona> buscarId(int id)
        {
            try
            {
                using (MatriculasDbContext db = new MatriculasDbContext())
                {
                    return db.Persona.Where(a => a.PersonaId == id).ToList();
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
