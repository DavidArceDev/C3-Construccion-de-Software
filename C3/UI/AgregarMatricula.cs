using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace UI
{
    public partial class AgregarMatricula : Form
    {
        private int alumnoId;
        private MatriculaBLL matriculaBLL;
        private Alumno alumno;
        private MatriculaDAL matriculaDAL;

        public AgregarMatricula(int alumnoId)
        {
            InitializeComponent();

            matriculaBLL = new MatriculaBLL();
            matriculaDAL = new MatriculaDAL();

            this.alumnoId = alumnoId;


        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            //obtener la info actual del formulario
            string codigo = txtCodigo.Text;
            DateTime fechaMatricula = dtpFechaMatricula.Value;
            string carrera = txtCarrera.Text;
            string anio = txtAnio.Text;
            string segmentoAcademico = txtSegmentoAcademico.Text;

            Matricula nuevaMatricula = new Matricula
            {
                Codigo = txtCodigo.Text,
                Fecha = dtpFechaMatricula.Value,
                Carrera = txtCarrera.Text,
                AnioMatricula = int.Parse(txtAnio.Text),
                SegmentoAcademico = txtSegmentoAcademico.Text,
                AlumnoId = alumnoId

            };

            matriculaDAL.Create(nuevaMatricula);

            MessageBox.Show("Matricula Creado con éxito");


            this.Close();

        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
