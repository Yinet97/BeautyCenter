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
    public partial class ReporteEmpleadas : Form
    {
        public ReporteEmpleadas()
        {
            InitializeComponent();
        }

        private void ReporteEmpleadas_Load(object sender, EventArgs e)
        {
            this.EmpleadasReportViewer.RefreshReport();
            EmpleadasReportViewer.Reset();
            EmpleadasReportViewer.ProcessingMode = ProcessingMode.Local;

            EmpleadasReportViewer.LocalReport.ReportPath = @"C:\Users\Yinet Jaquez\Desktop\ProyectoFinalBeautyC\ProyectoFinalBeautyC\UI\Reportes\Empleadas.rdlc";

            ReportDataSource source = new ReportDataSource("EmpleadasDataSet", EmpleadasBll.GetLista());

            EmpleadasReportViewer.LocalReport.DataSources.Add(source);
            this.EmpleadasReportViewer.RefreshReport();
        }

        private void EmpleadasReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
