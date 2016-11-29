using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalBeautyC.UI.Reportes
{
    public partial class ReporteClientes : Form
    {
        public ReporteClientes()
        {
            InitializeComponent();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {

            this.ClientesReportViewer.RefreshReport();

            ClientesReportViewer.Reset();
            ClientesReportViewer.ProcessingMode = ProcessingMode.Local;

            ClientesReportViewer.LocalReport.ReportPath = @"C:\Users\Yinet Jaquez\Desktop\ProyectoFinalBeautyC\ProyectoFinalBeautyC\UI\Reportes\Clientes.rdlc";

            ReportDataSource source = new ReportDataSource("ClienteDataSet", ClientesBll.GetLista());

            ClientesReportViewer.LocalReport.DataSources.Add(source);
            this.ClientesReportViewer.RefreshReport();
        }

        private void ClientesReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
