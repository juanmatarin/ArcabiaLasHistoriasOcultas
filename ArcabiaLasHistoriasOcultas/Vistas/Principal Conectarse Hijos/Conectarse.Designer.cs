namespace ArcabiaLasHistoriasOcultas.Vistas
{
    partial class Conectarse
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
            this.iniciarSesionBTN = new System.Windows.Forms.Button();
            this.registrarseBTN = new System.Windows.Forms.Button();
            this.salirBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciarSesionBTN
            // 
            this.iniciarSesionBTN.Location = new System.Drawing.Point(79, 265);
            this.iniciarSesionBTN.Name = "iniciarSesionBTN";
            this.iniciarSesionBTN.Size = new System.Drawing.Size(160, 85);
            this.iniciarSesionBTN.TabIndex = 0;
            this.iniciarSesionBTN.Text = "Iniciar Sesión";
            this.iniciarSesionBTN.UseVisualStyleBackColor = true;
            this.iniciarSesionBTN.Click += new System.EventHandler(this.iniciarSesionBTN_Click);
            // 
            // registrarseBTN
            // 
            this.registrarseBTN.Location = new System.Drawing.Point(245, 265);
            this.registrarseBTN.Name = "registrarseBTN";
            this.registrarseBTN.Size = new System.Drawing.Size(160, 85);
            this.registrarseBTN.TabIndex = 1;
            this.registrarseBTN.Text = "Registrarse";
            this.registrarseBTN.UseVisualStyleBackColor = true;
            this.registrarseBTN.Click += new System.EventHandler(this.registrarseBTN_Click);
            // 
            // salirBTN
            // 
            this.salirBTN.Location = new System.Drawing.Point(411, 265);
            this.salirBTN.Name = "salirBTN";
            this.salirBTN.Size = new System.Drawing.Size(160, 85);
            this.salirBTN.TabIndex = 2;
            this.salirBTN.Text = "Volver";
            this.salirBTN.UseVisualStyleBackColor = true;
            this.salirBTN.Click += new System.EventHandler(this.salirBTN_Click);
            // 
            // Conectarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 406);
            this.Controls.Add(this.salirBTN);
            this.Controls.Add(this.registrarseBTN);
            this.Controls.Add(this.iniciarSesionBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conectarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectarse";
            this.Load += new System.EventHandler(this.Conectarse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciarSesionBTN;
        private System.Windows.Forms.Button registrarseBTN;
        private System.Windows.Forms.Button salirBTN;
    }
}