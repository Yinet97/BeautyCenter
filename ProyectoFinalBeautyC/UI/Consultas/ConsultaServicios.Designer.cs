namespace ProyectoFinalBeautyC.UI.Consultas
{
    partial class ConsultaServicios
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
            this.ImprimirReporte = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.listadoConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // ImprimirReporte
            // 
            this.ImprimirReporte.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ImprimirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirReporte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirReporte.Location = new System.Drawing.Point(316, 351);
            this.ImprimirReporte.Name = "ImprimirReporte";
            this.ImprimirReporte.Size = new System.Drawing.Size(152, 49);
            this.ImprimirReporte.TabIndex = 13;
            this.ImprimirReporte.Text = "ImprimirReporte";
            this.ImprimirReporte.UseVisualStyleBackColor = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(154, 57);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(293, 27);
            this.textBoxID.TabIndex = 12;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscar.Location = new System.Drawing.Point(479, 45);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(152, 49);
            this.BotonBuscar.TabIndex = 11;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = false;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // listadoConsulta
            // 
            this.listadoConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoConsulta.BackgroundColor = System.Drawing.Color.White;
            this.listadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoConsulta.Location = new System.Drawing.Point(115, 147);
            this.listadoConsulta.Name = "listadoConsulta";
            this.listadoConsulta.Size = new System.Drawing.Size(549, 179);
            this.listadoConsulta.TabIndex = 10;
            // 
            // ConsultaServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(759, 424);
            this.Controls.Add(this.ImprimirReporte);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.listadoConsulta);
            this.Name = "ConsultaServicios";
            this.Text = "ConsultaServicios";
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImprimirReporte;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.DataGridView listadoConsulta;
    }
}