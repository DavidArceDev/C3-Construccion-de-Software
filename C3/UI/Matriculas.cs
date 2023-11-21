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
    public partial class Matriculas : Form
    {
        private int alumnoIdSeleccionado;
        private MatriculaBLL matriculaBLL;
        private MatriculaDAL matriculaDAL;
        private AlumnoDAL alumnoDAL;

        public Matriculas(int alumnoIdSeleccionado)
        {
            InitializeComponent();
            this.alumnoIdSeleccionado = alumnoIdSeleccionado;
            this.matriculaBLL = new MatriculaBLL();
            this.matriculaDAL = new MatriculaDAL();
            this.alumnoDAL = new AlumnoDAL();
            CargarMatriculas();
        }

        private void CargarMatriculas()
        {
            try
            {
                var matriculas = matriculaBLL.ListarMatriculasPorAlumno(alumnoIdSeleccionado);

                var query = from matricula in matriculas
                            select new
                            {
                                MatriculaId = matricula.MatriculaId,
                                Codigo = matricula.Codigo,
                                Fecha = matricula.Fecha,
                                Carrera = matricula.Carrera,
                                AnioMatricula = matricula.AnioMatricula,
                                SegmentoAcademico = matricula.SegmentoAcademico
                            };

                dgvListadoMatriculas.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar matrículas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditarMatricula_Click(object sender, EventArgs e)
        {
            if (dgvListadoMatriculas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para editar una matricula",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgvListadoMatriculas.SelectedRows[0];
                    int matriculaId = (int)filaSeleccionada.Cells["MatriculaId"].Value;

                    EditarMatricula editarMatricula = new EditarMatricula(matriculaId);
                    editarMatricula.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el formulario de edición: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnAgregarMatricula_Click(object sender, EventArgs e)
        {
            AgregarMatricula agregarMatricula = new AgregarMatricula(alumnoIdSeleccionado);
            agregarMatricula.ShowDialog();

        }

        private void btnEliminarMatricula_Click(object sender, EventArgs e)
        {
            if (dgvListadoMatriculas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar una matricula",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgvListadoMatriculas.SelectedRows[0];
                    int matriculaId = (int)filaSeleccionada.Cells["MatriculaId"].Value;

                    if (matriculaDAL.Delete(matriculaId))
                    {
                        MessageBox.Show("Matricula eliminado con éxito");
                        CargarMatriculas();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar la matricula");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el alumno: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMatriculas();
        }
    }
}
