namespace ArcabiaLasHistoriasOcultas.Vistas
{
    partial class Iniciar_Sesion
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
            this.usuarioTXTB = new System.Windows.Forms.TextBox();
            this.contrasenaTXTB = new System.Windows.Forms.TextBox();
            this.usuarioLBL = new System.Windows.Forms.Label();
            this.contrasenaLBL = new System.Windows.Forms.Label();
            this.inisesBTN = new System.Windows.Forms.Button();
            this.volverBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioTXTB
            // 
            this.usuarioTXTB.Location = new System.Drawing.Point(137, 31);
            this.usuarioTXTB.Name = "usuarioTXTB";
            this.usuarioTXTB.Size = new System.Drawing.Size(212, 20);
            this.usuarioTXTB.TabIndex = 0;
            // 
            // contrasenaTXTB
            // 
            this.contrasenaTXTB.Location = new System.Drawing.Point(137, 84);
            this.contrasenaTXTB.Name = "contrasenaTXTB";
            this.contrasenaTXTB.Size = new System.Drawing.Size(212, 20);
            this.contrasenaTXTB.TabIndex = 1;
            // 
            // usuarioLBL
            // 
            this.usuarioLBL.AutoSize = true;
            this.usuarioLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLBL.Location = new System.Drawing.Point(25, 26);
            this.usuarioLBL.Name = "usuarioLBL";
            this.usuarioLBL.Size = new System.Drawing.Size(74, 24);
            this.usuarioLBL.TabIndex = 2;
            this.usuarioLBL.Text = "Usuario";
            // 
            // contrasenaLBL
            // 
            this.contrasenaLBL.AutoSize = true;
            this.contrasenaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaLBL.Location = new System.Drawing.Point(25, 80);
            this.contrasenaLBL.Name = "contrasenaLBL";
            this.contrasenaLBL.Size = new System.Drawing.Size(106, 24);
            this.contrasenaLBL.TabIndex = 3;
            this.contrasenaLBL.Text = "Contraseña";
            // 
            // inisesBTN
            // 
            this.inisesBTN.Location = new System.Drawing.Point(29, 132);
            this.inisesBTN.Name = "inisesBTN";
            this.inisesBTN.Size = new System.Drawing.Size(154, 41);
            this.inisesBTN.TabIndex = 4;
            this.inisesBTN.Text = "Iniciar Sesión";
            this.inisesBTN.UseVisualStyleBackColor = true;
            this.inisesBTN.Click += new System.EventHandler(this.inisesBTN_Click);
            // 
            // volverBTN
            // 
            this.volverBTN.Location = new System.Drawing.Point(195, 132);
            this.volverBTN.Name = "volverBTN";
            this.volverBTN.Size = new System.Drawing.Size(154, 41);
            this.volverBTN.TabIndex = 5;
            this.volverBTN.Text = "Volver";
            this.volverBTN.UseVisualStyleBackColor = true;
            this.volverBTN.Click += new System.EventHandler(this.volverBTN_Click);
            // 
            // Iniciar_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 185);
            this.Controls.Add(this.volverBTN);
            this.Controls.Add(this.inisesBTN);
            this.Controls.Add(this.contrasenaLBL);
            this.Controls.Add(this.usuarioLBL);
            this.Controls.Add(this.contrasenaTXTB);
            this.Controls.Add(this.usuarioTXTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Iniciar_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar_Sesion";
            this.Load += new System.EventHandler(this.Iniciar_Sesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTXTB;
        private System.Windows.Forms.TextBox contrasenaTXTB;
        private System.Windows.Forms.Label usuarioLBL;
        private System.Windows.Forms.Label contrasenaLBL;
        private System.Windows.Forms.Button inisesBTN;
        private System.Windows.Forms.Button volverBTN;
    }
}