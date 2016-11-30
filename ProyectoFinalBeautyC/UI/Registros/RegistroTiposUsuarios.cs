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
using DAL;

namespace ProyectoFinalBeautyC.Registros
{
    public partial class RegistroTiposUsuarios : Form
    {
        public RegistroTiposUsuarios()
        {
            InitializeComponent();
        }
        

        public void LimpiarCampos()
        {
            NombreTextBox.Clear();
            ClaveTextBox.Clear();
            IdTextBox.Clear();
        }
        

        public void BuscarID()
        {
            var user = UsuariosBll.Buscar(Convert.ToInt32(IdTextBox.Text));
            if (user != null)
            {
                NombreTextBox.Text = user.Nombre;
                ClaveTextBox.Text = user.Clave;
            }
            else
            {
                MessageBox.Show("Este Usuario no Existe");
            }
        }

        BeautyCenterDb db = new BeautyCenterDb();
        private void ListarTipo()
        {
            var lista = db.TipoUsuario.ToList();

            if (lista.Count > 0)
            {
                TiposComboBox.DataSource = lista;
                TiposComboBox.DisplayMember = "tipoCategoria";
                TiposComboBox.ValueMember = "tipoID";

            }
        }
        

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
          //  string type = TiposComboBox.SelectedValue.ToString();

            if (string.IsNullOrEmpty(NombreTextBox.Text) || string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Usuarios user = new Usuarios();

                int id;
                int.TryParse(IdTextBox.Text, out id);
                user.Clave = ClaveTextBox.Text;
                user.Nombre = NombreTextBox.Text;
              //  user.Tipo = type;
                user.UsuarioId = id;

                if (UsuariosBll.Insertar(user))
                {
                    MessageBox.Show("Guardado !!");
                }
                LimpiarCampos();

            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);

            UsuariosBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
        }

        private void BotonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);

            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                MessageBox.Show("Tienes el campo vacio");
            }
            else
            {
                BuscarID();
            }
        }

        private void RegistroTiposUsuarios_Load_1(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
