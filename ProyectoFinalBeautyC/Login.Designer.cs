namespace ProyectoFinalBeautyC
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.botonEntrar = new System.Windows.Forms.Button();
            this.claveTexBox = new System.Windows.Forms.TextBox();
            this.usuarioTexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.botonRegistrar);
            this.panel1.Controls.Add(this.botonEntrar);
            this.panel1.Controls.Add(this.claveTexBox);
            this.panel1.Controls.Add(this.usuarioTexBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(94, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 351);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalBeautyC.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(174, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.Indigo;
            this.botonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonRegistrar.Image = global::ProyectoFinalBeautyC.Properties.Resources.login__1_;
            this.botonRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistrar.Location = new System.Drawing.Point(356, 292);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(107, 45);
            this.botonRegistrar.TabIndex = 5;
            this.botonRegistrar.Text = "Registar";
            this.botonRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // botonEntrar
            // 
            this.botonEntrar.BackColor = System.Drawing.Color.Thistle;
            this.botonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEntrar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonEntrar.Image = global::ProyectoFinalBeautyC.Properties.Resources.login;
            this.botonEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonEntrar.Location = new System.Drawing.Point(237, 292);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(101, 45);
            this.botonEntrar.TabIndex = 4;
            this.botonEntrar.Text = "Entrar";
            this.botonEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonEntrar.UseVisualStyleBackColor = false;
            this.botonEntrar.Click += new System.EventHandler(this.botonEntrar_Click_1);
            // 
            // claveTexBox
            // 
            this.claveTexBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveTexBox.ForeColor = System.Drawing.Color.Teal;
            this.claveTexBox.Location = new System.Drawing.Point(96, 248);
            this.claveTexBox.Name = "claveTexBox";
            this.claveTexBox.Size = new System.Drawing.Size(319, 27);
            this.claveTexBox.TabIndex = 3;
            // 
            // usuarioTexBox
            // 
            this.usuarioTexBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTexBox.ForeColor = System.Drawing.Color.Teal;
            this.usuarioTexBox.Location = new System.Drawing.Point(96, 192);
            this.usuarioTexBox.Name = "usuarioTexBox";
            this.usuarioTexBox.Size = new System.Drawing.Size(319, 27);
            this.usuarioTexBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(50, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(50, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(666, 426);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Button botonEntrar;
        private System.Windows.Forms.TextBox claveTexBox;
        private System.Windows.Forms.TextBox usuarioTexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}