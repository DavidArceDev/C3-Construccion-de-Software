using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AgregarAlumno : Form
    {

        public AgregarAlumno()
        {
            InitializeComponent();

        }

        ListadoAlumnos listadoAlumnos = new ListadoAlumnos();
        AlumnoDAL alumnoDAL = new AlumnoDAL();
        Alumno alumno = new Alumno();


        private void Limpiar()
        {
            txtRun.Focus();
            txtRun.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            dtpFechaNacimiento.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEstadoCivil.Text = string.Empty;
            dtpFechaIngreso.Text = string.Empty;
            txtCarreraActual.Text = string.Empty;
            txtSituacionAcademica.Text = string.Empty;

        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            string run = txtRun.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechaNacimiento = dtpFechaNacimiento.Text;
            string direccion = txtDireccion.Text;
            string estadoCivil = txtEstadoCivil.Text;
            string fechaIngreso = dtpFechaIngreso.Text;
            string carreraActual = txtCarreraActual.Text;
            string situacionAcademica = txtSituacionAcademica.Text;

            if (string.IsNullOrEmpty(run) || string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(fechaNacimiento) ||
                string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(estadoCivil) ||
                string.IsNullOrEmpty(fechaIngreso) || string.IsNullOrEmpty(carreraActual) ||
                string.IsNullOrEmpty(situacionAcademica))
            {
                MessageBox.Show("Los campos no deben estar vacíos");
            }
            else
            {
                DateTime fechaNacimientoDateTime;
                DateTime fechaIngresoDateTime;

                if (!DateTime.TryParseExact(fechaNacimiento, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNacimientoDateTime))
                {
                    MessageBox.Show("La fecha de nacimiento no tiene el formato correcto (dd-MM-yyyy).");
                    return;
                }

                if (!DateTime.TryParseExact(fechaIngreso, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaIngresoDateTime))
                {
                    MessageBox.Show("La fecha de ingreso no tiene el formato correcto (dd-MM-yyyy).");
                    return;
                }
                alumno.Persona = new Persona();
                alumno.Persona.Run = run;
                alumno.Persona.Nombre = nombre;
                alumno.Persona.Apellido = apellido;
                alumno.Persona.FechaNacimiento = fechaNacimientoDateTime;
                alumno.Persona.Direccion = direccion;
                alumno.Persona.EstadoCivil = estadoCivil;
                alumno.FechaIngreso = fechaIngresoDateTime;
                alumno.CarreraActual = carreraActual;
                alumno.EstadoAcademico = situacionAcademica;

                alumnoDAL.Create(alumno);


               
                MessageBox.Show("Alumno Creado con éxito");


                listadoAlumnos.CargarGrid();

                Limpiar();
                this.Close();
            }
        }

        private void AgregarAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
