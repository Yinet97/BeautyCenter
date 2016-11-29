using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalBeautyC.Registros
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) || string.IsNullOrEmpty(CedulaTextBox.Text) || string.IsNullOrEmpty(TelefonoTextBox.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {

                Clientes user = new Clientes();
                int id;
                int.TryParse(IDtextBox.Text, out id);
                user.Nombre = NombretextBox.Text;
                user.Cedula = CedulaTextBox.Text;
                user.Direccion = DireccionTextBox.Text;
                user.Telefono = TelefonoTextBox.Text;
                user.ClienteId = id;

                if (ClientesBll.Guardar(user))
                {
                    MessageBox.Show("Guardado !!");
                }
                LimpiarCampos();
            }
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDtextBox.Text);

            if (string.IsNullOrEmpty(IDtextBox.Text))
            {
                MessageBox.Show("Tienes el campo vacio");
            }
            else
            {
                BuscarID();
            }
        }

        public void BuscarID()
        {
            var client = ClientesBll.Buscar(Convert.ToInt32(IDtextBox.Text));
            if (client != null)
            {
                NombretextBox.Text = client.Nombre;
                CedulaTextBox.Text = client.Cedula;
                DireccionTextBox.Text = client.Direccion;
                TelefonoTextBox.Text = client.Telefono;
            }
            else
            {
                MessageBox.Show("Este Cliente no Existe");
            }

        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDtextBox.Text);

            ClientesBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            NombretextBox.Clear();
            DireccionTextBox.Clear();
            CedulaTextBox.Clear();
            IDtextBox.Clear();
            TelefonoTextBox.Clear();
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
