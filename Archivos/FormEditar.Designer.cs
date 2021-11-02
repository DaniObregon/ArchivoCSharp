
namespace Archivos
{
    partial class FormEditar
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
            this.Alumno = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.numericUpDownDNIEditar = new System.Windows.Forms.NumericUpDown();
            this.txtApellidoEditar = new System.Windows.Forms.TextBox();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailEditar = new System.Windows.Forms.TextBox();
            this.txtTelefonoEditar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNIEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // Alumno
            // 
            this.Alumno.Controls.Add(this.txtTelefonoEditar);
            this.Alumno.Controls.Add(this.txtEmailEditar);
            this.Alumno.Controls.Add(this.label2);
            this.Alumno.Controls.Add(this.label1);
            this.Alumno.Controls.Add(this.btnCancelar);
            this.Alumno.Controls.Add(this.btnGuardar);
            this.Alumno.Controls.Add(this.numericUpDownDNIEditar);
            this.Alumno.Controls.Add(this.txtApellidoEditar);
            this.Alumno.Controls.Add(this.txtNombreEditar);
            this.Alumno.Controls.Add(this.dni);
            this.Alumno.Controls.Add(this.apellido);
            this.Alumno.Controls.Add(this.nombre);
            this.Alumno.Location = new System.Drawing.Point(26, 75);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(427, 429);
            this.Alumno.TabIndex = 2;
            this.Alumno.TabStop = false;
            this.Alumno.Text = "Alumno";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(88, 358);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 29);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // numericUpDownDNIEditar
            // 
            this.numericUpDownDNIEditar.Location = new System.Drawing.Point(152, 164);
            this.numericUpDownDNIEditar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownDNIEditar.Name = "numericUpDownDNIEditar";
            this.numericUpDownDNIEditar.Size = new System.Drawing.Size(196, 22);
            this.numericUpDownDNIEditar.TabIndex = 5;
            // 
            // txtApellidoEditar
            // 
            this.txtApellidoEditar.Location = new System.Drawing.Point(152, 108);
            this.txtApellidoEditar.Name = "txtApellidoEditar";
            this.txtApellidoEditar.Size = new System.Drawing.Size(196, 22);
            this.txtApellidoEditar.TabIndex = 4;
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txtNombreEditar.Location = new System.Drawing.Point(152, 52);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(196, 22);
            this.txtNombreEditar.TabIndex = 3;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(54, 167);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(31, 17);
            this.dni.TabIndex = 2;
            this.dni.Text = "DNI";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(54, 111);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(58, 17);
            this.apellido.TabIndex = 1;
            this.apellido.Text = "Apellido";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(54, 55);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(58, 17);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 29);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefono";
            // 
            // txtEmailEditar
            // 
            this.txtEmailEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txtEmailEditar.Location = new System.Drawing.Point(152, 225);
            this.txtEmailEditar.Name = "txtEmailEditar";
            this.txtEmailEditar.Size = new System.Drawing.Size(196, 22);
            this.txtEmailEditar.TabIndex = 11;
            // 
            // txtTelefonoEditar
            // 
            this.txtTelefonoEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txtTelefonoEditar.Location = new System.Drawing.Point(152, 275);
            this.txtTelefonoEditar.Name = "txtTelefonoEditar";
            this.txtTelefonoEditar.Size = new System.Drawing.Size(196, 22);
            this.txtTelefonoEditar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Editar Registro";
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Alumno);
            this.Name = "FormEditar";
            this.Text = "Editar datos";
            this.Alumno.ResumeLayout(false);
            this.Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNIEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Alumno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown numericUpDownDNIEditar;
        private System.Windows.Forms.TextBox txtApellidoEditar;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTelefonoEditar;
        private System.Windows.Forms.TextBox txtEmailEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}