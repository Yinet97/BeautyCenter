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

namespace ProyectoFinalBeautyC.UI.Consultas
{
    public partial class ConsultaFacturas : Form
    {
        public ConsultaFacturas()
        {
            InitializeComponent();
        }

        List<Facturas> lista = new List<Facturas>();
        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxID.Text))
            {
                lista = FacturasBll.GetLista(Utilidades.stringToInt(textBoxID.Text));
            }
            else
            {
                lista = FacturasBll.GetLista();

            }
            listadoConsulta.DataSource = lista;
        }

        private void ImprimirReporte_Click(object sender, EventArgs e)
        {
            UI.Reportes.ReporteFacturas rf = new Reportes.ReporteFacturas();
            rf.Show();
        }

        private void FiltrarFechaBoton_Click(object sender, EventArgs e)
        {
            BeautyCenterDb db = new BeautyCenterDb();

            if (DesdeDateTimePicker.Value.Date < HastaDateTimePicker.Value.Date)
            {
                listadoConsulta.DataSource = FacturasBll.GetListaFecha(DesdeDateTimePicker.Value.Date, HastaDateTimePicker.Value.Date);
            }
        }
    }
}
