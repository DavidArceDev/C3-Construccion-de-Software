﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            { 
            }
            MatriculaBLL matricula = new MatriculaBLL();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listadoAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoAlumnos listadoAlumnos = new ListadoAlumnos();
            listadoAlumnos.ShowDialog();
            
        }
    }
}
