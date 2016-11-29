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
    public partial class ReporteCitas : Form
    {
        public ReporteCitas()
        {
            InitializeComponent();
        }

        private void ReporteCitas_Load(object sender, EventArgs e)
        {

            this.CitasReportViewer.RefreshReport();

            CitasReportViewer.Reset();
            CitasReportViewer.ProcessingMode = ProcessingMode.Local;

            CitasReportViewer.LocalReport.ReportPath = @"C:\Users\Yinet Jaquez\Desktop\ProyectoFinalBeautyC\ProyectoFinalBeautyC\UI\Reportes\Citas.rdlc";

            ReportDataSource source = new ReportDataSource("CitaDataSet", CitasBll.GetLista());

            CitasReportViewer.LocalReport.DataSources.Add(source);
            this.CitasReportViewer.RefreshReport();
        }

        private void CitasReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
