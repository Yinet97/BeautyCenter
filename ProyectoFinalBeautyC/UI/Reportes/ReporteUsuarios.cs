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
    public partial class ReporteUsuarios : Form
    {
        public ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {

            this.UsuariosReportViewer.RefreshReport();
            UsuariosReportViewer.Reset();
            UsuariosReportViewer.ProcessingMode = ProcessingMode.Local;

            UsuariosReportViewer.LocalReport.ReportPath = @"C:\Users\Yinet Jaquez\Desktop\ProyectoFinalBeautyC\ProyectoFinalBeautyC\UI\Reportes\Usuarios.rdlc";

            ReportDataSource source = new ReportDataSource("UsuariosDataSet", BLL.UsuariosBll.GetLista());

            UsuariosReportViewer.LocalReport.DataSources.Add(source);
            this.UsuariosReportViewer.RefreshReport();
        }

        private void UsuariosReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
