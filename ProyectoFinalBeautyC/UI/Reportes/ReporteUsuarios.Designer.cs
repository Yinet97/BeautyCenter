namespace ProyectoFinalBeautyC.UI.Reportes
{
    partial class ReporteUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsuariosReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // UsuariosReportViewer
            // 
            this.UsuariosReportViewer.Location = new System.Drawing.Point(-2, -3);
            this.UsuariosReportViewer.Name = "UsuariosReportViewer";
            this.UsuariosReportViewer.Size = new System.Drawing.Size(698, 429);
            this.UsuariosReportViewer.TabIndex = 0;
            this.UsuariosReportViewer.Load += new System.EventHandler(this.UsuariosReportViewer_Load);
            // 
            // ReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 422);
            this.Controls.Add(this.UsuariosReportViewer);
            this.Name = "ReporteUsuarios";
            this.Text = "ReporteUsuarios";
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer UsuariosReportViewer;
    }
}