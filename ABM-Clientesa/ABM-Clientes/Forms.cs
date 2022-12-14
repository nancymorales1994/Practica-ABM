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
using Data;

namespace ABM_Clientes
{
    public partial class Forms : Form
    {
        public Forms()
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
        List<Cliente> listaClientes = new List<Cliente>();
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textBoxNombre.Text;
            cliente.Apellido = textBoxApellido.Text;
            cliente.Cuil = textBoxCUIL.Text;
            cliente.Direccion = textBoxDireccion.Text;
            cliente.DNI = textBoxDNI.Text;
            cliente.Telefono = textBoxTelefono.Text;
            //cliente.FechaNacimiento =
           
            listBoxClientes.Items.Add(cliente);
            listaClientes.Add(cliente);

            limpieza();
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int indice = listBoxClientes.SelectedIndex;
            listBoxClientes.Items.RemoveAt(indice);
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

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            Cliente c = con.GetClientByDNI(textBoxBuscarPorDNI.Text);
            
        }
    }
}
