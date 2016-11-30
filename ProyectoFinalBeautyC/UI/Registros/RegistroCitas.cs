using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using DAL;
using BLL;

namespace ProyectoFinalBeautyC.Registros
{
    public partial class RegistroCitas : Form
    {
        public RegistroCitas()
        {
            InitializeComponent();
        }
 
        public void LimpiarCampos()
        {
            ClienteTextBox.Clear();
            IdCitaTextBox.Clear();
            IdClienteTextBox.Clear();
        }
        
        public void LlenarLista()
        {
            ListaCitaDataGridView.DataSource = null;
            ListaCitaDataGridView.DataSource = CitasBll.GetLista();
        }


        private void RegistroCitas_Load(object sender, EventArgs e)
        {
            LlenarLista();

            AutoCompleteMode DataCollection = new AutoCompleteMode();
            AutoCompletarTxt(DataCollection);

            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void AutoCompletarTxt(AutoCompleteMode AuMode)
        {
            BeautyCenterDb db = new BeautyCenterDb();

            ClienteTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            ClienteTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection aColl = new AutoCompleteStringCollection();


            var cl = from obj in db.Cliente
                     select obj.Nombre;

            foreach (string c in cl)
            {
                aColl.Add(c);
            }
            ClienteTextBox.AutoCompleteCustomSource = aColl;
        }

        public void EliminarCitaAntigua()
        {
            using (var db = new BeautyCenterDb())
            {
                DateTime hoy = DateTime.Now;

                var pastDate = from obj in db.Cita
                               where obj.FechaHora < hoy.Date
                               select obj.CitaId;

                foreach (int d in pastDate)
                {
                    CitasBll.EliminarCitaPasada(d);

                }
            }
            LlenarLista();
        }
        
        
        private void BuscarClienteBoton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdClienteTextBox.Text))
            {
                MessageBox.Show("Tienes el campo ID vacio");
            }
            else
            {
                var client = ClientesBll.Buscar(Convert.ToInt32(IdClienteTextBox.Text));
                if (client != null)
                {
                    ClienteTextBox.Text = client.Nombre;
                }
                else
                {
                    MessageBox.Show("Este Cliente no Existe");
                }
            }
        }

        private void BuscarCitaBoton_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdCitaTextBox.Text);

            if (string.IsNullOrEmpty(IdCitaTextBox.Text))
            {
                MessageBox.Show("Tienes el campo ID vacio");
            }
            else
            {
                var cita = CitasBll.Buscar(Convert.ToInt32(IdCitaTextBox.Text));
                if (cita != null)
                {
                    CitaDateTimePicker.Text = cita.FechaHora.ToString();
                    ClienteTextBox.Text = cita.NombreCliente;
                }
                else
                {
                    MessageBox.Show("Esta Cita no Existe");
                }
            }
        }

        private void ActualizarBoton_Click_1(object sender, EventArgs e)
        {
            EliminarCitaAntigua();
        }

        private void EliminarBoton_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdCitaTextBox.Text);

            CitasBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
            LlenarLista();
        }

        private void NuevoBoton_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GuardarBoton_Click_1(object sender, EventArgs e)
        {
            Citas date = new Citas();
            using (BeautyCenterDb db = new BeautyCenterDb())
            {
                string var = (from c in db.Cliente where c.Nombre == ClienteTextBox.Text select c.Nombre).FirstOrDefault();
                if (var == ClienteTextBox.Text)
                {
                    int id;
                    int.TryParse(IdCitaTextBox.Text, out id);
                    date.NombreCliente = ClienteTextBox.Text;
                    date.FechaHora = CitaDateTimePicker.Value;
                    date.CitaId = id;

                    if (CitasBll.Guardar(date))
                    {
                        MessageBox.Show("Cita Guardada");
                        LlenarLista();
                    }
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Este Cliente no esta registrado");
                }
            }
        }
    }
}
