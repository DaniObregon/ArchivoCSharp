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
    public partial class FormEditar : Form
    {

        Alumno alumno = new Alumno();
        Form1 form1 = new Form1();
        GestorAlumnos gestorAlumnos = new GestorAlumnos();

        public FormEditar(Alumno alumnoEditar, Form1 form1)
        {
            this.alumno = alumnoEditar;
            this.form1 = form1;
            InitializeComponent();

            this.txtApellidoEditar.Text = alumno.Apellido;
            this.txtNombreEditar.Text = alumno.Nombre;
            this.numericUpDownDNIEditar.Value = alumno.DNI;
            this.txtEmailEditar.Text = alumno.Email;
            this.txtTelefonoEditar.Text = alumno.Telefono;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno alumnoEditar = new Alumno();
            alumnoEditar.Apellido = this.txtApellidoEditar.Text;
            alumnoEditar.Nombre = this.txtNombreEditar.Text;
            alumnoEditar.DNI = (long)this.numericUpDownDNIEditar.Value;
            alumnoEditar.Email = this.txtEmailEditar.Text;
            alumnoEditar.Telefono = this.txtTelefonoEditar.Text;

            if(MessageBox.Show("Esta a punto de cambiar los datos\nRealmente desea editar el registro?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                gestorAlumnos.EditarAlumno(alumno.DNI, alumnoEditar);
                form1.ReiniciarCampos();
                form1.LlenarGrilla();
                this.Close();
            }
            else
            {
                MessageBox.Show("Puede dormir tranquilo, su registro esta a salvo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
