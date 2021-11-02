using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class Form1 : Form
    {

        GestorAlumnos gestorAlumnos = new GestorAlumnos();

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LlenarGrilla();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;



        }

        private void alta_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno((long)this.numericUpDownDNI.Value)
            {
                Apellido = this.txtApellido.Text,
                Nombre = this.txtNombre.Text,
                Email = this.txtEmail.Text,
                Telefono = this.txtTelefono.Text
            };
            gestorAlumnos.Alta(alumno);
            LlenarGrilla();
            ReiniciarCampos();
        }

        public void LlenarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = gestorAlumnos.Listar();
            this.dataGridView1.ClearSelection();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                Alumno alumnoSeleccionado = (Alumno)this.dataGridView1.SelectedRows[0].DataBoundItem;
                gestorAlumnos.Baja(alumnoSeleccionado.DNI);
                LlenarGrilla();
                ReiniciarCampos();
            }
        }

        public void ReiniciarCampos()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.numericUpDownDNI.Value = 0;
            this.txtEmail.Text = "";
            this.txtTelefono.Text = "";
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = new Alumno();
            
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                alumnoSeleccionado = (Alumno)this.dataGridView1.SelectedRows[0].DataBoundItem;
            }


            //gestorAlumnos.EncontrarAlumno(alumnoSeleccionado);

            FormEditar formEditar = new FormEditar(alumnoSeleccionado, this);
            formEditar.Show();
        }

        /* private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             if (this.dataGridView1.SelectedRows.Count == 1)
             {
                 Alumno alumnoSeleccionado = (Alumno)this.dataGridView1.SelectedRows[0].DataBoundItem;
                 this.txtNombre.Text = alumnoSeleccionado.Nombre;
                 this.txtApellido.Text = alumnoSeleccionado.Apellido;
                 this.numericUpDownDNI.Value = alumnoSeleccionado.DNI;
             }
         }*/
    }
}
