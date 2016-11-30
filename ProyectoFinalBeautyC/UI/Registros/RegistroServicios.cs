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
    public partial class RegistroServicios : Form
    {
        public RegistroServicios()
        {
            InitializeComponent();
        }

        public void BuscarID()
        {
            var ser = ServiciosBll.Buscar(Convert.ToInt32(IDtextBox.Text));
            if (ser != null)
            {
                TipoTextBox.Text = ser.TipoServicio;
                CostoTextBox.Text = ser.Costo.ToString();
            }
            else
            {
                MessageBox.Show("Este Servicio no Existe");
            }
        }
        

        public void LimpiarCampos()
        {
            IDtextBox.Clear();
            TipoTextBox.Clear();
            CostoTextBox.Clear();
        }

        private void RegistroServicios_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void BuscarBoton_Click_1(object sender, EventArgs e)
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

        private void EliminarBoton_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDtextBox.Text);

            ServiciosBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
        }

        private void GuardarBoton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TipoTextBox.Text) || string.IsNullOrEmpty(CostoTextBox.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Servicios service = new Servicios();

                int id;
                int.TryParse(IDtextBox.Text, out id);
                service.TipoServicio = TipoTextBox.Text;
                service.Costo = Convert.ToInt32(CostoTextBox.Text);
                service.ServicioId = id;

                if (ServiciosBll.Guardar(service))
                {
                    MessageBox.Show("Guardado !!");
                }
                LimpiarCampos();
            }
        }

        private void NuevoBoton_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
