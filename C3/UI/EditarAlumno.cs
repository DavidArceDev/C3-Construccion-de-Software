using BLL;
using DAL;
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class EditarAlumno : Form
    {
        private int alumnoId;
        private AlumnoDAL alumnoDAL;


        public EditarAlumno(int alumnoId)
        {
            InitializeComponent();
            this.alumnoId = alumnoId;
            this.alumnoDAL = new AlumnoDAL();


        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumnoActualizado = new Alumno
                {

                    AlumnoId = this.alumnoId,
                    FechaIngreso = dtpFechaIngreso.Value,
                    CarreraActual = txtCarreraActual.Text,
                    EstadoAcademico = txtSituacionAcademica.Text,
                    Persona = new Persona
                    {
                        Run = txtRun.Text,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        FechaNacimiento = dtpFechaNacimiento.Value,
                        Direccion = txtDireccion.Text,
                        EstadoCivil = txtEstadoCivil.Text
                    }
                };

                bool actualizacionExitosa = alumnoDAL.Update(alumnoActualizado);

                if (actualizacionExitosa)
                {
                    MessageBox.Show("Cambios guardados exitosamente");
                    (Owner as ListadoAlumnos)?.CargarGrid();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar los cambios",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
