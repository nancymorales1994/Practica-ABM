
namespace ABM_Clientes
{
    partial class Front
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCUIL = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelCUIL = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxBuscarPorDNI = new System.Windows.Forms.TextBox();
            this.labelBuscarPorDNI = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(140, 38);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(250, 19);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(140, 72);
            this.textBoxApellido.Multiline = true;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(250, 19);
            this.textBoxApellido.TabIndex = 1;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(140, 106);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(250, 19);
            this.textBoxDireccion.TabIndex = 2;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(140, 139);
            this.textBoxTelefono.Multiline = true;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(250, 19);
            this.textBoxTelefono.TabIndex = 3;
            // 
            // textBoxCUIL
            // 
            this.textBoxCUIL.Location = new System.Drawing.Point(140, 206);
            this.textBoxCUIL.Multiline = true;
            this.textBoxCUIL.Name = "textBoxCUIL";
            this.textBoxCUIL.Size = new System.Drawing.Size(250, 19);
            this.textBoxCUIL.TabIndex = 4;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(140, 173);
            this.textBoxDNI.Multiline = true;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(250, 19);
            this.textBoxDNI.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.Location = new System.Drawing.Point(13, 41);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(108, 34);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre Completo";
            // 
            // labelApellido
            // 
            this.labelApellido.Location = new System.Drawing.Point(13, 75);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(108, 34);
            this.labelApellido.TabIndex = 8;
            this.labelApellido.Text = "Apellido";
            // 
            // labelDireccion
            // 
            this.labelDireccion.Location = new System.Drawing.Point(13, 109);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(108, 34);
            this.labelDireccion.TabIndex = 9;
            this.labelDireccion.Text = "Dirección";
            this.labelDireccion.Click += new System.EventHandler(this.labelDireccion_Click);
            // 
            // labelTelefono
            // 
            this.labelTelefono.Location = new System.Drawing.Point(13, 142);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(108, 34);
            this.labelTelefono.TabIndex = 10;
            this.labelTelefono.Text = "Telefono";
            // 
            // labelDNI
            // 
            this.labelDNI.Location = new System.Drawing.Point(13, 176);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(108, 34);
            this.labelDNI.TabIndex = 11;
            this.labelDNI.Text = "DNI";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.Location = new System.Drawing.Point(13, 243);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(108, 34);
            this.labelFechaNacimiento.TabIndex = 12;
            this.labelFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // labelCUIL
            // 
            this.labelCUIL.Location = new System.Drawing.Point(13, 209);
            this.labelCUIL.Name = "labelCUIL";
            this.labelCUIL.Size = new System.Drawing.Size(108, 34);
            this.labelCUIL.TabIndex = 13;
            this.labelCUIL.Text = "CUIL";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(125, 300);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(80, 34);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(211, 300);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(80, 34);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxBuscarPorDNI
            // 
            this.textBoxBuscarPorDNI.Location = new System.Drawing.Point(643, 38);
            this.textBoxBuscarPorDNI.Multiline = true;
            this.textBoxBuscarPorDNI.Name = "textBoxBuscarPorDNI";
            this.textBoxBuscarPorDNI.Size = new System.Drawing.Size(250, 19);
            this.textBoxBuscarPorDNI.TabIndex = 17;
            this.textBoxBuscarPorDNI.TextChanged += new System.EventHandler(this.textBoxBuscarPorDNI_TextChanged);
            // 
            // labelBuscarPorDNI
            // 
            this.labelBuscarPorDNI.Location = new System.Drawing.Point(540, 41);
            this.labelBuscarPorDNI.Name = "labelBuscarPorDNI";
            this.labelBuscarPorDNI.Size = new System.Drawing.Size(85, 34);
            this.labelBuscarPorDNI.TabIndex = 18;
            this.labelBuscarPorDNI.Text = "Buscar por DNI";
            this.labelBuscarPorDNI.Click += new System.EventHandler(this.labelBuscarPorDNI_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(910, 30);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(80, 34);
            this.buttonBuscar.TabIndex = 19;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(543, 75);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(447, 238);
            this.listBoxClientes.TabIndex = 21;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(910, 331);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(80, 34);
            this.buttonEliminar.TabIndex = 22;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(140, 237);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(250, 20);
            this.dateTimeFechaNacimiento.TabIndex = 23;
            this.dateTimeFechaNacimiento.ValueChanged += new System.EventHandler(this.dateTimeFechaNacimiento_ValueChanged);
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 461);
            this.Controls.Add(this.dateTimeFechaNacimiento);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelBuscarPorDNI);
            this.Controls.Add(this.textBoxBuscarPorDNI);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelCUIL);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxCUIL);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "Front";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxCUIL;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelCUIL;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxBuscarPorDNI;
        private System.Windows.Forms.Label labelBuscarPorDNI;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
    }
}

