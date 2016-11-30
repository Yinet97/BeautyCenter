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
    public partial class ReporteServicios : Form
    {
        public ReporteServicios()
        {
            InitializeComponent();
        }

        private void ReporteServicios_Load(object sender, EventArgs e)
        {

            this.ServiciosReportViewer.RefreshReport();
            ServiciosReportViewer.Reset();
            ServiciosReportViewer.ProcessingMode = ProcessingMode.Local;

            ServiciosReportViewer.LocalReport.ReportPath = @"C:\Users\Yinet Jaquez\Desktop\ProyectoFinalBeautyC\ProyectoFinalBeautyC\UI\Reportes\Servicios.rdlc";

            ReportDataSource source = new ReportDataSource("ServiciosDataSet", ServiciosBll.GetLista());

            ServiciosReportViewer.LocalReport.DataSources.Add(source);
            this.ServiciosReportViewer.RefreshReport();
        }

        private void ServiciosReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
