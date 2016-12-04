namespace ProyectoFinalBeautyC.UI.Consultas
{
    partial class ConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.ImprimirReporteboton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.listadoConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // ImprimirReporteboton
            // 
            this.ImprimirReporteboton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ImprimirReporteboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirReporteboton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirReporteboton.Location = new System.Drawing.Point(274, 373);
            this.ImprimirReporteboton.Name = "ImprimirReporteboton";
            this.ImprimirReporteboton.Size = new System.Drawing.Size(160, 44);
            this.ImprimirReporteboton.TabIndex = 8;
            this.ImprimirReporteboton.Text = "Imprimir Reporte";
            this.ImprimirReporteboton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 26);
            this.textBox1.TabIndex = 7;
            // 
            // botonConsultar
            // 
            this.botonConsultar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.botonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultar.Location = new System.Drawing.Point(520, 61);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(112, 44);
            this.botonConsultar.TabIndex = 6;
            this.botonConsultar.Text = "consultar";
            this.botonConsultar.UseVisualStyleBackColor = false;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // listadoConsulta
            // 
            this.listadoConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoConsulta.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoConsulta.Location = new System.Drawing.Point(15, 147);
            this.listadoConsulta.Name = "listadoConsulta";
            this.listadoConsulta.Size = new System.Drawing.Size(672, 205);
            this.listadoConsulta.TabIndex = 5;
            // 
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(702, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImprimirReporteboton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.listadoConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaUsuarios";
            this.Text = "ConsultaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImprimirReporteboton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.DataGridView listadoConsulta;
    }
}