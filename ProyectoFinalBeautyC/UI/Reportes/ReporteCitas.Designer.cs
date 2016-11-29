namespace ProyectoFinalBeautyC.UI.Reportes
{
    partial class ReporteCitas
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
            this.CitasReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // CitasReportViewer
            // 
            this.CitasReportViewer.Location = new System.Drawing.Point(-2, 0);
            this.CitasReportViewer.Name = "CitasReportViewer";
            this.CitasReportViewer.Size = new System.Drawing.Size(720, 449);
            this.CitasReportViewer.TabIndex = 0;
            this.CitasReportViewer.Load += new System.EventHandler(this.CitasReportViewer_Load);
            // 
            // ReporteCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 445);
            this.Controls.Add(this.CitasReportViewer);
            this.Name = "ReporteCitas";
            this.Text = "ReporteCitas";
            this.Load += new System.EventHandler(this.ReporteCitas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer CitasReportViewer;
    }
}