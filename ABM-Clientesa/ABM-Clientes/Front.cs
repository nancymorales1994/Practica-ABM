using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace ABM_Clientes
{
    public partial class Front : Form
    {
        public Front()
        {
            InitializeComponent();
        }

        public void limpieza()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxCUIL.Text = "";
            textBoxDireccion.Text = "";
            textBoxDNI.Text = "";
            textBoxTelefono.Text = "";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Nombre = textBoxNombre.Text;
            cliente.Apellido = textBoxApellido.Text;
            cliente.Cuil = textBoxCUIL.Text;
            cliente.Direccion = textBoxDireccion.Text;
            cliente.DNI = textBoxDNI.Text;
            cliente.Telefono = textBoxTelefono.Text;
            //cliente.FechaNacimiento =

            listBoxClientes.Items.Add(cliente);

            limpieza();
            

        }

        private void labelBuscarPorDNI_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limpieza();
        }

        private void labelDireccion_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarPorDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
