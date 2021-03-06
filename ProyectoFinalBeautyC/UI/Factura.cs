﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Entidades;
using BLL;

namespace ProyectoFinalBeautyC
{
    public partial class Factura : Form
    {
        Facturas f;
        public Factura()
        {
            InitializeComponent();
            LlenarComboBox();
            f = new Facturas();
        }

        public void Calcular()
        {
            Decimal suma = 0.00m;
            BeautyCenterDb db = new BeautyCenterDb();

            var costos = from ser in db.Servicio
                         select ser.Costo;

            const int COLUMNA = 2;

            if (ServiciosDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in ServiciosDataGridView.Rows)
                {
                    suma += (int)row.Cells[COLUMNA].Value;
                    TotalTextBox.Text = suma.ToString();
                    SubTotalTextBox.Text = suma.ToString();
                }
                if (MontoAdicionalTextBox.Text != null)
                {
                    suma = suma + Convert.ToInt32(MontoAdicionalTextBox.Text);
                    TotalTextBox.Text = suma.ToString();
                }

                if (DescuentoTextBox.Text != null)
                {
                    suma = suma - Convert.ToInt32(DescuentoTextBox.Text);
                    TotalTextBox.Text = suma.ToString();
                    SubTotalTextBox.Text = suma.ToString();
                }

                if (PorcientoDescuentoTextBox.Text != null)
                {
                    Decimal porcent = 0.00m;
                    porcent = (Convert.ToDecimal(PorcientoDescuentoTextBox.Text) * Convert.ToDecimal(suma)) / 100;
                    suma = Convert.ToDecimal(suma) - porcent;
                    TotalTextBox.Text = suma.ToString();
                    SubTotalTextBox.Text = suma.ToString();
                }

                if (ImpuestoTextBox.Text != null)
                {
                    Decimal porcent = 0.00m;
                    porcent = (Convert.ToDecimal(ImpuestoTextBox.Text) * Convert.ToDecimal(suma)) / 100;
                    suma = Convert.ToDecimal(suma) + porcent;
                    TotalTextBox.Text = suma.ToString();
                }

            }
            else
            {
                MessageBox.Show("No tienes servicios para registar");
            }
        }

        private void LlenarComboBox()
        {
            ServiciosComboBox.DataSource = ServiciosBll.GetLista();
            ServiciosComboBox.DisplayMember = "TipoServicio";
            ServiciosComboBox.ValueMember = "ServicioId";
        }
        

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            f.Service.Add(ServiciosBll.Buscar((int)ServiciosComboBox.SelectedValue));
            ServiciosDataGridView.DataSource = null;
            ServiciosDataGridView.DataSource = f.Service;

            Calcular();
        }

        public void Limpiar()
        {
            DescuentoTextBox.Text = 0.ToString();
            PorcientoDescuentoTextBox.Text = 0.ToString();
            IdTextBox.Clear();
            ImpuestoTextBox.Text = 18.ToString();
            MontoAdicionalTextBox.Text = 0.ToString();
            ComentarioRichTextBox.Text = "Comentario";
            TipoPagoTextBox.Clear();
            ServiciosDataGridView.DataSource = null;
            NombreClienteTextBox.Clear();
            TotalTextBox.Text = 0.00m.ToString();
            SubTotalTextBox.Text = 0.00.ToString();
            f = new Facturas();
        }
        
        private void AutoCompletarTxt(AutoCompleteMode AuMode)
        {
            BeautyCenterDb db = new BeautyCenterDb();

            NombreClienteTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            NombreClienteTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection aColl = new AutoCompleteStringCollection();


            var cl = from obj in db.Cliente
                     select obj.Nombre;

            foreach (string c in cl)
            {
                aColl.Add(c);
            }
            NombreClienteTextBox.AutoCompleteCustomSource = aColl;
        }

        private void BuscarBoton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                MessageBox.Show("Tienes el campo ID vacio");
            }
            else
            {
                var fact = FacturasBll.Buscar(Convert.ToInt32(IdTextBox.Text));
                if (fact != null)
                {
                    NombreClienteTextBox.Text = fact.NombreCliente;
                    FechaActualDateTimePicker.Text = fact.Fecha.ToString();
                    MontoAdicionalTextBox.Text = fact.MontoAdicional.ToString();
                    ImpuestoTextBox.Text = fact.Impuesto.ToString();
                    DescuentoTextBox.Text = fact.Descuento.ToString();
                    ComentarioRichTextBox.Text = fact.Comentario;
                    ServiciosDataGridView.DataSource = null;
                    ServiciosDataGridView.DataSource = fact.Service;
                    TipoPagoTextBox.Text = fact.TipoPago;
                    TotalTextBox.Text = fact.Total.ToString();
                    SubTotalTextBox.Text = fact.SubTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Esta Factura no Existe");
                }
            }
        }

        private void GuardarBoton_Click_1(object sender, EventArgs e)
        {
            BeautyCenterDb db = new BeautyCenterDb();
            Facturas fact = new Facturas();

            string var = (from c in db.Cliente where c.Nombre == NombreClienteTextBox.Text select c.Nombre).FirstOrDefault();

            if (string.IsNullOrEmpty(NombreClienteTextBox.Text)
                 || var != NombreClienteTextBox.Text || string.IsNullOrEmpty(ServiciosDataGridView.DataSource.ToString()))
            {
                MessageBox.Show("Dejaste campos importantes Vacios o quizas el cliente no esta registrado");
            }
            else
            {

                int id;
                int.TryParse(IdTextBox.Text, out id);
                f.Fecha = DateTime.Now;
                f.Comentario = ComentarioRichTextBox.Text;
                f.Descuento = Convert.ToInt32(DescuentoTextBox.Text);
                f.DescuentoPorciento = Convert.ToDouble(PorcientoDescuentoTextBox.Text);
                f.Impuesto = Convert.ToInt32(ImpuestoTextBox.Text);
                f.NombreCliente = NombreClienteTextBox.Text;
                f.MontoAdicional = Convert.ToInt32(MontoAdicionalTextBox.Text);
                f.TipoPago = TipoPagoTextBox.Text;
                f.Total = Convert.ToDouble(TotalTextBox.Text);
                f.SubTotal = Convert.ToDouble(SubTotalTextBox.Text);
                f.FacturaId = id;

                if (FacturasBll.Guardar(f))
                {
                    MessageBox.Show("Guardado");
                }
                Limpiar();
            }
        }

        private void EliminarBoton_Click_1(object sender, EventArgs e)
        {
            var fact = new Facturas();
            int id = Convert.ToInt32(IdTextBox.Text);
            if(IdTextBox.Text == null)
            {
                MessageBox.Show("Dejaste el campo del ID vacio");
            }
            else
            {
                FacturasBll.Eliminar(id);
                MessageBox.Show("Factura Eliminada !");
                Limpiar();
            }
            
        }

        private void NuevoBoton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Factura_Load_1(object sender, EventArgs e)
        {
            AutoCompleteMode DataCollection = new AutoCompleteMode();
            AutoCompletarTxt(DataCollection);

            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
