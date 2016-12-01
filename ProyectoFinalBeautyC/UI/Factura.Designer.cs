namespace ProyectoFinalBeautyC
{
    partial class Factura
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
            this.ServiciosDataGridView = new System.Windows.Forms.DataGridView();
            this.ServiciosComboBox = new System.Windows.Forms.ComboBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.FechaActualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TipoPagoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PorcientoDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MontoAdicionalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ComentarioRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ImpuestoTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.NuevoBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiciosDataGridView
            // 
            this.ServiciosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiciosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiciosDataGridView.Location = new System.Drawing.Point(61, 383);
            this.ServiciosDataGridView.Name = "ServiciosDataGridView";
            this.ServiciosDataGridView.Size = new System.Drawing.Size(822, 168);
            this.ServiciosDataGridView.TabIndex = 42;
            // 
            // ServiciosComboBox
            // 
            this.ServiciosComboBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiciosComboBox.FormattingEnabled = true;
            this.ServiciosComboBox.Location = new System.Drawing.Point(153, 342);
            this.ServiciosComboBox.Name = "ServiciosComboBox";
            this.ServiciosComboBox.Size = new System.Drawing.Size(307, 26);
            this.ServiciosComboBox.TabIndex = 41;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(39, 15);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(49, 26);
            this.IdTextBox.TabIndex = 40;
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarBoton.Location = new System.Drawing.Point(106, 11);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(57, 34);
            this.BuscarBoton.TabIndex = 39;
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click_1);
            // 
            // FechaActualDateTimePicker
            // 
            this.FechaActualDateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.FechaActualDateTimePicker.Enabled = false;
            this.FechaActualDateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaActualDateTimePicker.Location = new System.Drawing.Point(683, 9);
            this.FechaActualDateTimePicker.Name = "FechaActualDateTimePicker";
            this.FechaActualDateTimePicker.Size = new System.Drawing.Size(264, 27);
            this.FechaActualDateTimePicker.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TipoPagoTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PorcientoDescuentoTextBox);
            this.panel1.Controls.Add(this.NombreClienteTextBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.MontoAdicionalTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ComentarioRichTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ImpuestoTextBox);
            this.panel1.Controls.Add(this.DescuentoTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(39, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 230);
            this.panel1.TabIndex = 43;
            // 
            // TipoPagoTextBox
            // 
            this.TipoPagoTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoPagoTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.TipoPagoTextBox.Location = new System.Drawing.Point(148, 84);
            this.TipoPagoTextBox.Name = "TipoPagoTextBox";
            this.TipoPagoTextBox.Size = new System.Drawing.Size(273, 26);
            this.TipoPagoTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente";
            // 
            // PorcientoDescuentoTextBox
            // 
            this.PorcientoDescuentoTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorcientoDescuentoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PorcientoDescuentoTextBox.Location = new System.Drawing.Point(615, 129);
            this.PorcientoDescuentoTextBox.Name = "PorcientoDescuentoTextBox";
            this.PorcientoDescuentoTextBox.Size = new System.Drawing.Size(94, 26);
            this.PorcientoDescuentoTextBox.TabIndex = 31;
            this.PorcientoDescuentoTextBox.Text = "0";
            this.PorcientoDescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClienteTextBox.Location = new System.Drawing.Point(148, 38);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(273, 26);
            this.NombreClienteTextBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(512, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "% Descuento";
            // 
            // MontoAdicionalTextBox
            // 
            this.MontoAdicionalTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoAdicionalTextBox.Location = new System.Drawing.Point(615, 173);
            this.MontoAdicionalTextBox.Name = "MontoAdicionalTextBox";
            this.MontoAdicionalTextBox.Size = new System.Drawing.Size(94, 26);
            this.MontoAdicionalTextBox.TabIndex = 23;
            this.MontoAdicionalTextBox.Text = "0";
            this.MontoAdicionalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tipo de Pago";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Comentario";
            // 
            // ComentarioRichTextBox
            // 
            this.ComentarioRichTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComentarioRichTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ComentarioRichTextBox.Location = new System.Drawing.Point(148, 132);
            this.ComentarioRichTextBox.Name = "ComentarioRichTextBox";
            this.ComentarioRichTextBox.Size = new System.Drawing.Size(273, 78);
            this.ComentarioRichTextBox.TabIndex = 25;
            this.ComentarioRichTextBox.Text = "Comentario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Impuesto";
            // 
            // ImpuestoTextBox
            // 
            this.ImpuestoTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpuestoTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.ImpuestoTextBox.Location = new System.Drawing.Point(615, 38);
            this.ImpuestoTextBox.Name = "ImpuestoTextBox";
            this.ImpuestoTextBox.Size = new System.Drawing.Size(94, 26);
            this.ImpuestoTextBox.TabIndex = 21;
            this.ImpuestoTextBox.Text = "18";
            this.ImpuestoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescuentoTextBox.Location = new System.Drawing.Point(615, 81);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(94, 26);
            this.DescuentoTextBox.TabIndex = 22;
            this.DescuentoTextBox.Text = "0";
            this.DescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(519, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "$ Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto Adicional";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgregarBoton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 262);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarBoton.Location = new System.Drawing.Point(497, 18);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(107, 43);
            this.AgregarBoton.TabIndex = 28;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTextBox.ForeColor = System.Drawing.Color.Orange;
            this.SubTotalTextBox.Location = new System.Drawing.Point(847, 599);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(93, 26);
            this.SubTotalTextBox.TabIndex = 48;
            this.SubTotalTextBox.Text = "0.00";
            this.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(769, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "SubTotal";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.TotalTextBox.Location = new System.Drawing.Point(847, 640);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(93, 26);
            this.TotalTextBox.TabIndex = 46;
            this.TotalTextBox.Text = "0.00";
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(782, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Total";
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarBoton.Location = new System.Drawing.Point(576, 604);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(132, 51);
            this.EliminarBoton.TabIndex = 51;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click_1);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarBoton.Location = new System.Drawing.Point(358, 604);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(129, 51);
            this.GuardarBoton.TabIndex = 50;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click_1);
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.BackColor = System.Drawing.Color.GhostWhite;
            this.NuevoBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoBoton.Location = new System.Drawing.Point(106, 604);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(108, 51);
            this.NuevoBoton.TabIndex = 49;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoBoton.UseVisualStyleBackColor = false;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click_1);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 689);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ServiciosDataGridView);
            this.Controls.Add(this.ServiciosComboBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.FechaActualDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ServiciosDataGridView;
        private System.Windows.Forms.ComboBox ServiciosComboBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.DateTimePicker FechaActualDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TipoPagoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PorcientoDescuentoTextBox;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MontoAdicionalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox ComentarioRichTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ImpuestoTextBox;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button NuevoBoton;
    }
}