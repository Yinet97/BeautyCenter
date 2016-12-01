using ProyectoFinalBeautyC.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalBeautyC
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }
        
           private void botonRegistrar_Click(object sender, EventArgs e)
           {
               RegistroTiposUsuarios rtu = new RegistroTiposUsuarios();
               rtu.Show();
           }

           private void CitasBoton_Click(object sender, EventArgs e)
           {
               Registros.RegistroCitas rc = new Registros.RegistroCitas();
               rc.Show();
           }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegistroTiposUsuarios rtu = new RegistroTiposUsuarios();
            rtu.Show();
        }

        private void FacturarBoton_Click_1(object sender, EventArgs e)
        {
            Factura f = new Factura();
            f.Show();
        }

        private void Programa_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;

            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void regEmpleadasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegistroEmpleada r = new RegistroEmpleada();
            r.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           RegistroClientes rc = new RegistroClientes();
            rc.Show();
        }

        private void serviciosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegistroServicios rS = new RegistroServicios();
            rS.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaUsuarios c = new UI.Consultas.ConsultaUsuarios();
            c.Show();
        }

        private void empleadasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaEmpleadas ce = new UI.Consultas.ConsultaEmpleadas();
            ce.Show();
        }

        private void clientesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaClientes cc = new UI.Consultas.ConsultaClientes();
            cc.Show();
        }

        private void serviciosToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaServicios cS = new UI.Consultas.ConsultaServicios();
            cS.Show();
        }

        private void citasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaCitas cc = new UI.Consultas.ConsultaCitas();
            cc.Show();
        }

        private void facturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaFacturas cf = new UI.Consultas.ConsultaFacturas();
            cf.Show();
        }

        private void clientesToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            UI.Reportes.ReporteClientes re = new UI.Reportes.ReporteClientes();
            re.Show();
        }

        private void empleadasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            UI.Reportes.ReporteEmpleadas report = new UI.Reportes.ReporteEmpleadas();
            report.Show();
        }

        private void serviciosToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            UI.Reportes.ReporteServicios reporte = new UI.Reportes.ReporteServicios();
            reporte.Show();
        }

        private void usuariosToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            UI.Reportes.ReporteUsuarios ru = new UI.Reportes.ReporteUsuarios();
            ru.Show();
        }

        private void facturasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            UI.Reportes.ReporteFacturas rp = new UI.Reportes.ReporteFacturas();
            rp.Show();

        }
    }
}
