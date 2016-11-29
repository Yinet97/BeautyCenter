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

namespace ProyectoFinalBeautyC.UI.Consultas
{
    public partial class ConsultaServicios : Form
    {
        public ConsultaServicios()
        {
            InitializeComponent();
        }

        List<Servicios> lista = new List<Servicios>();

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxID.Text))
            {
                lista = ServiciosBll.GetLista(Utilidades.stringToInt(textBoxID.Text));
            }
            else
            {
                lista = ServiciosBll.GetLista();

            }
            listadoConsulta.DataSource = lista;
        }

        private void ImprimirReporte_Click(object sender, EventArgs e)
        {
            Reportes.ReporteServicios rs = new Reportes.ReporteServicios();
            rs.Show();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void listadoConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
