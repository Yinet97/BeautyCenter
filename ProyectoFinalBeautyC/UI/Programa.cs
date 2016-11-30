﻿using ProyectoFinalBeautyC.Registros;
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
        

           private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
           {
               UI.Consultas.ConsultaUsuarios c = new UI.Consultas.ConsultaUsuarios();
               c.Show();
           }


           private void botonRegistrar_Click(object sender, EventArgs e)
           {
               RegistroTiposUsuarios rtu = new RegistroTiposUsuarios();
               rtu.Show();
           }

           private void regEmpleadasToolStripMenuItem_Click(object sender, EventArgs e)
           {
               RegistroEmpleada re = new RegistroEmpleada();
               re.Show();
           }

           private void empleadasToolStripMenuItem_Click(object sender, EventArgs e)
           {
               UI.Consultas.ConsultaEmpleadas ce = new UI.Consultas.ConsultaEmpleadas();
               ce.Show();
           }

           private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
           {
               Registros.RegistroClientes rc = new Registros.RegistroClientes();
               rc.Show();
           }

           private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
           {
                UI.Consultas.ConsultaClientes cc = new UI.Consultas.ConsultaClientes();
               cc.Show();
           }

           private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
           {
               Registros.RegistroServicios rS = new Registros.RegistroServicios();
               rS.Show();
           }

           private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
           {
              UI.Consultas.ConsultaServicios cS = new UI.Consultas.ConsultaServicios();
               cS.Show();
           }

           private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
           {
               UI.Reportes.ReporteClientes re = new UI.Reportes.ReporteClientes();
               re.Show();
           }

           private void empleadasToolStripMenuItem1_Click(object sender, EventArgs e)
           {
               UI.Reportes.ReporteEmpleadas report = new UI.Reportes.ReporteEmpleadas();
               report.Show();
           }

           private void serviciosToolStripMenuItem2_Click(object sender, EventArgs e)
           {
               UI.Reportes.ReporteServicios reporte = new UI.Reportes.ReporteServicios();
               reporte.Show();
           }

           private void Login_Load(object sender, EventArgs e)
           {
               if (this.WindowState == FormWindowState.Normal)
                   this.WindowState = FormWindowState.Maximized;

               MaximizeBox = false;
               MinimizeBox = false;
           }

           private void CitasBoton_Click(object sender, EventArgs e)
           {
               Registros.RegistroCitas rc = new Registros.RegistroCitas();
               rc.Show();
           }

           private void FacturarBoton_Click(object sender, EventArgs e)
           {
               Factura f = new Factura();
               f.Show();
           }

           private void citasToolStripMenuItem_Click(object sender, EventArgs e)
           {
               UI.Consultas.ConsultaCitas cc = new UI.Consultas.ConsultaCitas();
               cc.Show();
           }

           private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
           {
               UI.Consultas.ConsultaFacturas cf = new UI.Consultas.ConsultaFacturas();
               cf.Show();
           }

           private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
           {
               UI.Reportes.ReporteUsuarios ru = new UI.Reportes.ReporteUsuarios();
               ru.Show();
           }

           private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
           {
               UI.Reportes.ReporteFacturas rp = new UI.Reportes.ReporteFacturas();
               rp.Show();

           }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegistroTiposUsuarios rtu = new RegistroTiposUsuarios();
            rtu.Show();
        }

        private void usuariosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UI.Reportes.ReporteUsuarios ru = new UI.Reportes.ReporteUsuarios();
            ru.Show();
        }
    }
}