using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace ProyectoFinalBeautyC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            Registros.RegistroTiposUsuarios ru = new Registros.RegistroTiposUsuarios();
            ru.Show();
        }
        

        private void Login_Load_1(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            //Asignar los asteriscos para la clave
            claveTexBox.Text = "";
            claveTexBox.PasswordChar = '*';
            claveTexBox.MaxLength = 14;
        }

        private void botonEntrar_Click_1(object sender, EventArgs e)
        {
            string username = usuarioTexBox.Text;
            string clave = claveTexBox.Text;

            if (String.IsNullOrEmpty(usuarioTexBox.Text) || String.IsNullOrEmpty(claveTexBox.Text))
            {
                MessageBox.Show("Dejaste campos Vacios");
            }
            else
            {
                using (BeautyCenterDb db = new BeautyCenterDb())
                {
                    var user = (from u in db.Usuario where u.Nombre == username select u.Nombre).FirstOrDefault();
                    var passw = (from u in db.Usuario where u.Clave == username select u.Clave).FirstOrDefault();

                    if (user == username || passw == clave)
                    {
                        Programa c = new Programa();
                        this.Hide();
                        c.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Los datos estan incompletos");
                    }
                }
            }
        }
    }
}
