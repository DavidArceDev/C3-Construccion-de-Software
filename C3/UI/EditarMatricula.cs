using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DAL;

namespace UI
{
    public partial class EditarMatricula : Form
    {
        private int matriculaId;
        private int? alumnoId;
        private MatriculaBLL matriculaBLL;

        public EditarMatricula(int matriculaId)
        {
            InitializeComponent();
            this.matriculaId = matriculaId;
            matriculaBLL = new MatriculaBLL();
            CargarDatosMatricula();
        }

        private void CargarDatosMatricula()
        {
            Matricula matricula = matriculaBLL.ObtenerMatriculaPorId(matriculaId);

            if (matricula != null)
            {
                txtCodigo.Text = matricula.Codigo;
                dtpFechaMatricula.Value = matricula.Fecha ?? DateTime.Now;
                txtCarrera.Text = matricula.Carrera;
                txtAnio.Text = matricula.AnioMatricula.ToString();
                txtSegmentoAcademico.Text = matricula.SegmentoAcademico;

                alumnoId = matricula.AlumnoId;

            }
            else
            {
                MessageBox.Show("No se encontraron datos para la matrícula seleccionada",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnGuadarCambios_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAnio.Text, out int anioMatricula))
            {
                Matricula matriculaActualizada = new Matricula
                {
                    MatriculaId = matriculaId,
                    AlumnoId = alumnoId,
                    Codigo = txtCodigo.Text,
                    Fecha = dtpFechaMatricula.Value,
                    Carrera = txtCarrera.Text,
                    AnioMatricula = anioMatricula,
                    SegmentoAcademico = txtSegmentoAcademico.Text
                };

                bool actualizacionExitosa = matriculaBLL.ActualizarMatricula(matriculaActualizada);

                if (actualizacionExitosa)
                {
                    MessageBox.Show("Cambios guardados exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar los cambios",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El año de matrícula debe ser un valor numérico",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
