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
    public partial class ReporteFacturas : Form
    {
        public ReporteFacturas()
        {
            InitializeComponent();
        }

        private void ReporteFacturas_Load(object sender, EventArgs e)
        {

            this.FacturaReportViewer.RefreshReport();

            FacturaReportViewer.Reset();
            FacturaReportViewer.ProcessingMode = ProcessingMode.Local;

            FacturaReportViewer.LocalReport.ReportPath = @"C:\Users\Yinet Jaquez\Desktop\ProyectoFinalBeautyC\ProyectoFinalBeautyC\UI\Reportes\Facturas.rdlc";

            ReportDataSource source = new ReportDataSource("FacturasDataSet", FacturasBll.GetLista());

            FacturaReportViewer.LocalReport.DataSources.Add(source);
            this.FacturaReportViewer.RefreshReport();
        }

        private void FacturasReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
