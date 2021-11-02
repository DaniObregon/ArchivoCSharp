
namespace Archivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Alumno = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.alta = new System.Windows.Forms.Button();
            this.numericUpDownDNI = new System.Windows.Forms.NumericUpDown();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.baja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 331);
            this.dataGridView1.TabIndex = 8;
            // 
            // Alumno
            // 
            this.Alumno.Controls.Add(this.txtTelefono);
            this.Alumno.Controls.Add(this.txtEmail);
            this.Alumno.Controls.Add(this.label3);
            this.Alumno.Controls.Add(this.label2);
            this.Alumno.Controls.Add(this.alta);
            this.Alumno.Controls.Add(this.numericUpDownDNI);
            this.Alumno.Controls.Add(this.txtApellido);
            this.Alumno.Controls.Add(this.txtNombre);
            this.Alumno.Controls.Add(this.dni);
            this.Alumno.Controls.Add(this.apellido);
            this.Alumno.Controls.Add(this.nombre);
            this.Alumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alumno.Location = new System.Drawing.Point(814, 88);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(292, 331);
            this.Alumno.TabIndex = 1;
            this.Alumno.TabStop = false;
            this.Alumno.Text = "Alumno";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(469, 429);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 40);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(96, 281);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(90, 29);
            this.alta.TabIndex = 5;
            this.alta.Text = "Alta";
            this.alta.UseVisualStyleBackColor = true;
            this.alta.Click += new System.EventHandler(this.alta_Click);
            // 
            // numericUpDownDNI
            // 
            this.numericUpDownDNI.Location = new System.Drawing.Point(115, 131);
            this.numericUpDownDNI.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownDNI.Name = "numericUpDownDNI";
            this.numericUpDownDNI.Size = new System.Drawing.Size(151, 22);
            this.numericUpDownDNI.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(115, 82);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(17, 133);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(34, 17);
            this.dni.TabIndex = 2;
            this.dni.Text = "DNI";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(17, 82);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(66, 17);
            this.apellido.TabIndex = 1;
            this.apellido.Text = "Apellido";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(17, 36);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(64, 17);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // baja
            // 
            this.baja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baja.Location = new System.Drawing.Point(237, 429);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(90, 40);
            this.baja.TabIndex = 7;
            this.baja.Text = "Baja";
            this.baja.UseVisualStyleBackColor = true;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(231, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sistema de gestion de Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(115, 229);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 22);
            this.txtTelefono.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditar);
            this.Name = "Form1";
            this.Text = "Sistema de gestion de Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Alumno.ResumeLayout(false);
            this.Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Alumno;
        private System.Windows.Forms.Button alta;
        private System.Windows.Forms.NumericUpDown numericUpDownDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button baja;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

