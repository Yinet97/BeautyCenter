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
    public partial class RegistroEmpleada : Form
    {
        public RegistroEmpleada()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            IdTextBox.Clear();
            NombreTextBox.Clear();
            ServicioTextBox.Clear();
            CedulaTextBox.Clear();
            DireccionTextBox.Clear();
            SueldoFijoTextBox.Clear();
            ServicioTextBox.Clear();
            TelefonoTextBox.Clear();
        }

        public void BuscarID()
        {
            var emp = EmpleadasBll.Buscar(Convert.ToInt32(IdTextBox.Text));
            if (emp != null)
            {
                NombreTextBox.Text = emp.Nombre;
                CedulaTextBox.Text = emp.Cedula;
                DireccionTextBox.Text = emp.Direccion;
                TelefonoTextBox.Text = emp.Telefono;
                ServicioTextBox.Text = emp.Servicio;
                FechaDateTimePicker.Text = emp.FechaEntrada.ToString();
                SueldoFijoTextBox.Text = emp.SueldoFijo.ToString();
            }
            else
            {
                MessageBox.Show("Este Empleado no Existe");
            }

        }

        private void RegistroEmpleada_Load(object sender, EventArgs e)
        {
            AutoCompleteMode DataCollection = new AutoCompleteMode();
            AutoCompletarTxt(DataCollection);

            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void AutoCompletarTxt(AutoCompleteMode AuMode)
        {
            BeautyCenterDb db = new BeautyCenterDb();

            ServicioTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            ServicioTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection aColl = new AutoCompleteStringCollection();


            var ser = from obj in db.Servicio
                      select obj.TipoServicio;

            foreach (string cad in ser)
            {
                aColl.Add(cad);
            }
            ServicioTextBox.AutoCompleteCustomSource = aColl;
        }

        private void BuscarBoton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                MessageBox.Show("Tienes el campo vacio");
            }
            else
            {
                int id = Convert.ToInt32(IdTextBox.Text);
                BuscarID();
            }
        }

        private void EliminarBoton_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);

            EmpleadasBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
        }

        private void GuardarBoton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text) || string.IsNullOrEmpty(CedulaTextBox.Text) || string.IsNullOrEmpty(ServicioTextBox.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Empleadas user = new Empleadas();

                using (BeautyCenterDb db = new BeautyCenterDb())
                {
                    string var = (from c in db.Servicio where c.TipoServicio == ServicioTextBox.Text select c.TipoServicio).FirstOrDefault();
                    if (var == ServicioTextBox.Text)
                    {
                        int id;
                        int.TryParse(IdTextBox.Text, out id);
                        user.Nombre = NombreTextBox.Text;
                        user.Cedula = CedulaTextBox.Text;
                        user.Telefono = TelefonoTextBox.Text;
                        user.Direccion = DireccionTextBox.Text;
                        user.Servicio = ServicioTextBox.Text;
                        user.SueldoFijo = Convert.ToInt32(SueldoFijoTextBox.Text);
                        user.FechaEntrada = FechaDateTimePicker.Value.Date;
                        user.EmpleadaId = id;

                        if (EmpleadasBll.Insertar(user))
                        {
                            MessageBox.Show("Empleado Guardada Exitosamente");

                        }
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El Servicio no esta registrado");
                    }
                }
            }
        }

        private void NuevoBoton_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
