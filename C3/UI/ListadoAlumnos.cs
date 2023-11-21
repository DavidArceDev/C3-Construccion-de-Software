using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UI
{
    public partial class ListadoAlumnos : Form
    {
        private AlumnoBLL alumnoBLL;
        private AlumnoDAL alumnoDAL;
        private PersonaDAL personaDAL;
        public ListadoAlumnos()
        {
            InitializeComponent();
            alumnoBLL = new AlumnoBLL();
            alumnoDAL = new AlumnoDAL();
            personaDAL= new PersonaDAL();
            CargarGrid();
        }

        public void CargarGrid()
        {
            try
            {
                var listaAlumnos = alumnoDAL.Read();
                var listaPersonas = personaDAL.Read();

                var query = from alumno in listaAlumnos
                            join persona in listaPersonas on alumno.PersonaId equals persona.PersonaId
                            select new
                            {
                                AlumnoId = alumno.AlumnoId,
                                Run = persona.Run,
                                Nombre = persona.Nombre,
                                Apellido = persona.Apellido,
                                FechaNacimiento = persona.FechaNacimiento,
                                Direccion = persona.Direccion,
                                EstadoCivil = persona.EstadoCivil,
                                FechaIngreso = alumno.FechaIngreso,
                                CarreraActual = alumno.CarreraActual,
                                EstadoAcademico = alumno.EstadoAcademico
                            };

                dgvListadoAlumnos.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnMostrarMatriculas_Click(object sender, EventArgs e)
        {
            if (dgvListadoAlumnos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvListadoAlumnos.SelectedRows[0];
                int alumnoIdSeleccionado = (int)filaSeleccionada.Cells["AlumnoId"].Value;

                Matriculas matriculas = new Matriculas(alumnoIdSeleccionado);
                matriculas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListadoAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            AgregarAlumno agregarAlumno = new AgregarAlumno();
            agregarAlumno.ShowDialog();
        }

        private void btnActualizarListado_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            if (dgvListadoAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para editar un alumno",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgvListadoAlumnos.SelectedRows[0];
                    int alumnoId = (int)filaSeleccionada.Cells["AlumnoId"].Value;

                    EditarAlumno editarAlumno = new EditarAlumno(alumnoId);
                    editarAlumno.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el formulario de edición: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (dgvListadoAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar un alumno",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgvListadoAlumnos.SelectedRows[0];
                    int alumnoId = (int)filaSeleccionada.Cells["AlumnoId"].Value;
                     
                    if (alumnoDAL.Delete(alumnoId) && (personaDAL.Delete(alumnoId)))
                    {
                        MessageBox.Show("Alumno eliminado con éxito");
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el alumno");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el alumno: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
