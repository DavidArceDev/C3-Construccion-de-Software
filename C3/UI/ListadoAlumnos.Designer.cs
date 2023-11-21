namespace UI
{
    partial class ListadoAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.btnMostrarMatriculas = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnEditarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.AlumnoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Run = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarreraActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoAcademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoAlumnos
            // 
            this.dgvListadoAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvListadoAlumnos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlumnoId,
            this.Run,
            this.Nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.Direccion,
            this.EstadoCivil,
            this.FechaIngreso,
            this.CarreraActual,
            this.EstadoAcademico});
            this.dgvListadoAlumnos.Location = new System.Drawing.Point(173, 30);
            this.dgvListadoAlumnos.Name = "dgvListadoAlumnos";
            this.dgvListadoAlumnos.RowHeadersWidth = 51;
            this.dgvListadoAlumnos.RowTemplate.Height = 24;
            this.dgvListadoAlumnos.Size = new System.Drawing.Size(1131, 601);
            this.dgvListadoAlumnos.TabIndex = 0;
            this.dgvListadoAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoAlumnos_CellContentClick);
            // 
            // btnMostrarMatriculas
            // 
            this.btnMostrarMatriculas.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMostrarMatriculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMatriculas.Location = new System.Drawing.Point(0, 542);
            this.btnMostrarMatriculas.Name = "btnMostrarMatriculas";
            this.btnMostrarMatriculas.Size = new System.Drawing.Size(176, 89);
            this.btnMostrarMatriculas.TabIndex = 1;
            this.btnMostrarMatriculas.Text = "Mostrar Matriculas";
            this.btnMostrarMatriculas.UseVisualStyleBackColor = false;
            this.btnMostrarMatriculas.Click += new System.EventHandler(this.btnMostrarMatriculas_Click);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(0, 30);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(176, 89);
            this.btnAgregarAlumno.TabIndex = 2;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = false;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnEditarAlumno
            // 
            this.btnEditarAlumno.BackColor = System.Drawing.Color.Gold;
            this.btnEditarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAlumno.Location = new System.Drawing.Point(0, 114);
            this.btnEditarAlumno.Name = "btnEditarAlumno";
            this.btnEditarAlumno.Size = new System.Drawing.Size(176, 89);
            this.btnEditarAlumno.TabIndex = 3;
            this.btnEditarAlumno.Text = "Editar Alumno";
            this.btnEditarAlumno.UseVisualStyleBackColor = false;
            this.btnEditarAlumno.Click += new System.EventHandler(this.btnEditarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(0, 196);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(176, 89);
            this.btnEliminarAlumno.TabIndex = 4;
            this.btnEliminarAlumno.Text = "Eliminar Alumno";
            this.btnEliminarAlumno.UseVisualStyleBackColor = false;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(0, 351);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(176, 89);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // AlumnoId
            // 
            this.AlumnoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AlumnoId.DataPropertyName = "AlumnoId";
            this.AlumnoId.HeaderText = "Id";
            this.AlumnoId.MinimumWidth = 6;
            this.AlumnoId.Name = "AlumnoId";
            this.AlumnoId.Width = 47;
            // 
            // Run
            // 
            this.Run.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Run.DataPropertyName = "Run";
            this.Run.HeaderText = "Run";
            this.Run.MinimumWidth = 6;
            this.Run.Name = "Run";
            this.Run.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 85;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 86;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.MinimumWidth = 6;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Width = 133;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 93;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EstadoCivil.DataPropertyName = "EstadoCivil";
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.MinimumWidth = 6;
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Width = 99;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.MinimumWidth = 6;
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 112;
            // 
            // CarreraActual
            // 
            this.CarreraActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CarreraActual.DataPropertyName = "CarreraActual";
            this.CarreraActual.HeaderText = "Carrera Actual";
            this.CarreraActual.MinimumWidth = 6;
            this.CarreraActual.Name = "CarreraActual";
            this.CarreraActual.Width = 111;
            // 
            // EstadoAcademico
            // 
            this.EstadoAcademico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EstadoAcademico.DataPropertyName = "EstadoAcademico";
            this.EstadoAcademico.HeaderText = "Estado Academico";
            this.EstadoAcademico.MinimumWidth = 6;
            this.EstadoAcademico.Name = "EstadoAcademico";
            this.EstadoAcademico.Width = 138;
            // 
            // ListadoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1305, 666);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnEditarAlumno);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.btnMostrarMatriculas);
            this.Controls.Add(this.dgvListadoAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListadoAlumnos";
            this.Text = "Listado Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoAlumnos;
        private System.Windows.Forms.Button btnMostrarMatriculas;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnEditarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Run;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarreraActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoAcademico;
    }
}