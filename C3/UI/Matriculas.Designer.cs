namespace UI
{
    partial class Matriculas
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
            this.dgvListadoMatriculas = new System.Windows.Forms.DataGridView();
            this.btnAgregarMatricula = new System.Windows.Forms.Button();
            this.btnEditarMatricula = new System.Windows.Forms.Button();
            this.btnEliminarMatricula = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.MatriculaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegmentoAcademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoMatriculas
            // 
            this.dgvListadoMatriculas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvListadoMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatriculaId,
            this.Codigo,
            this.Fecha,
            this.Carrera,
            this.AnioMatricula,
            this.SegmentoAcademico});
            this.dgvListadoMatriculas.Location = new System.Drawing.Point(70, 45);
            this.dgvListadoMatriculas.Name = "dgvListadoMatriculas";
            this.dgvListadoMatriculas.RowHeadersWidth = 51;
            this.dgvListadoMatriculas.RowTemplate.Height = 24;
            this.dgvListadoMatriculas.Size = new System.Drawing.Size(627, 532);
            this.dgvListadoMatriculas.TabIndex = 0;
            // 
            // btnAgregarMatricula
            // 
            this.btnAgregarMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMatricula.Location = new System.Drawing.Point(703, 45);
            this.btnAgregarMatricula.Name = "btnAgregarMatricula";
            this.btnAgregarMatricula.Size = new System.Drawing.Size(231, 77);
            this.btnAgregarMatricula.TabIndex = 1;
            this.btnAgregarMatricula.Text = "Agregar Matricula";
            this.btnAgregarMatricula.UseVisualStyleBackColor = false;
            this.btnAgregarMatricula.Click += new System.EventHandler(this.btnAgregarMatricula_Click);
            // 
            // btnEditarMatricula
            // 
            this.btnEditarMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMatricula.Location = new System.Drawing.Point(703, 128);
            this.btnEditarMatricula.Name = "btnEditarMatricula";
            this.btnEditarMatricula.Size = new System.Drawing.Size(231, 84);
            this.btnEditarMatricula.TabIndex = 2;
            this.btnEditarMatricula.Text = "Editar Matricula";
            this.btnEditarMatricula.UseVisualStyleBackColor = false;
            this.btnEditarMatricula.Click += new System.EventHandler(this.btnEditarMatricula_Click);
            // 
            // btnEliminarMatricula
            // 
            this.btnEliminarMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMatricula.Location = new System.Drawing.Point(703, 218);
            this.btnEliminarMatricula.Name = "btnEliminarMatricula";
            this.btnEliminarMatricula.Size = new System.Drawing.Size(231, 91);
            this.btnEliminarMatricula.TabIndex = 3;
            this.btnEliminarMatricula.Text = "Eliminar Matricula";
            this.btnEliminarMatricula.UseVisualStyleBackColor = false;
            this.btnEliminarMatricula.Click += new System.EventHandler(this.btnEliminarMatricula_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(703, 486);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(231, 91);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // MatriculaId
            // 
            this.MatriculaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MatriculaId.DataPropertyName = "MatriculaId";
            this.MatriculaId.Frozen = true;
            this.MatriculaId.HeaderText = "ID";
            this.MatriculaId.MinimumWidth = 6;
            this.MatriculaId.Name = "MatriculaId";
            this.MatriculaId.ReadOnly = true;
            this.MatriculaId.Width = 49;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 74;
            // 
            // Carrera
            // 
            this.Carrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Carrera.DataPropertyName = "Carrera";
            this.Carrera.Frozen = true;
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 81;
            // 
            // AnioMatricula
            // 
            this.AnioMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AnioMatricula.DataPropertyName = "AnioMatricula";
            this.AnioMatricula.Frozen = true;
            this.AnioMatricula.HeaderText = "Año";
            this.AnioMatricula.MinimumWidth = 6;
            this.AnioMatricula.Name = "AnioMatricula";
            this.AnioMatricula.ReadOnly = true;
            this.AnioMatricula.Width = 60;
            // 
            // SegmentoAcademico
            // 
            this.SegmentoAcademico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SegmentoAcademico.DataPropertyName = "SegmentoAcademico";
            this.SegmentoAcademico.Frozen = true;
            this.SegmentoAcademico.HeaderText = "Segmento Academico";
            this.SegmentoAcademico.MinimumWidth = 6;
            this.SegmentoAcademico.Name = "SegmentoAcademico";
            this.SegmentoAcademico.ReadOnly = true;
            this.SegmentoAcademico.Width = 155;
            // 
            // Matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 616);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarMatricula);
            this.Controls.Add(this.btnEditarMatricula);
            this.Controls.Add(this.btnAgregarMatricula);
            this.Controls.Add(this.dgvListadoMatriculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Matriculas";
            this.Text = "Matriculas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMatriculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoMatriculas;
        private System.Windows.Forms.Button btnAgregarMatricula;
        private System.Windows.Forms.Button btnEditarMatricula;
        private System.Windows.Forms.Button btnEliminarMatricula;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatriculaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegmentoAcademico;
    }
}