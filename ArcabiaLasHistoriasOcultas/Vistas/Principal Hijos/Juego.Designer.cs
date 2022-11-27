namespace ArcabiaLasHistoriasOcultas.Vistas
{
    partial class Juego
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
            this.ventanaTexto = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salirBTN = new System.Windows.Forms.Button();
            this.historiaBTN = new System.Windows.Forms.Button();
            this.cargarBTN = new System.Windows.Forms.Button();
            this.GuardarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ventanaTexto
            // 
            this.ventanaTexto.Location = new System.Drawing.Point(191, 40);
            this.ventanaTexto.MinimumSize = new System.Drawing.Size(20, 20);
            this.ventanaTexto.Name = "ventanaTexto";
            this.ventanaTexto.Size = new System.Drawing.Size(616, 328);
            this.ventanaTexto.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(191, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 192);
            this.panel1.TabIndex = 1;
            // 
            // salirBTN
            // 
            this.salirBTN.Location = new System.Drawing.Point(632, 533);
            this.salirBTN.Name = "salirBTN";
            this.salirBTN.Size = new System.Drawing.Size(175, 43);
            this.salirBTN.TabIndex = 5;
            this.salirBTN.Text = "Salir al Menú principal";
            this.salirBTN.UseVisualStyleBackColor = true;
            this.salirBTN.Click += new System.EventHandler(this.salirBTN_Click);
            // 
            // historiaBTN
            // 
            this.historiaBTN.Location = new System.Drawing.Point(632, 484);
            this.historiaBTN.Name = "historiaBTN";
            this.historiaBTN.Size = new System.Drawing.Size(175, 43);
            this.historiaBTN.TabIndex = 6;
            this.historiaBTN.Text = "Historia";
            this.historiaBTN.UseVisualStyleBackColor = true;
            // 
            // cargarBTN
            // 
            this.cargarBTN.Location = new System.Drawing.Point(632, 435);
            this.cargarBTN.Name = "cargarBTN";
            this.cargarBTN.Size = new System.Drawing.Size(175, 43);
            this.cargarBTN.TabIndex = 7;
            this.cargarBTN.Text = "Cargar";
            this.cargarBTN.UseVisualStyleBackColor = true;
            // 
            // GuardarBTN
            // 
            this.GuardarBTN.Location = new System.Drawing.Point(632, 384);
            this.GuardarBTN.Name = "GuardarBTN";
            this.GuardarBTN.Size = new System.Drawing.Size(175, 45);
            this.GuardarBTN.TabIndex = 8;
            this.GuardarBTN.Text = "Guardar";
            this.GuardarBTN.UseVisualStyleBackColor = true;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 605);
            this.Controls.Add(this.GuardarBTN);
            this.Controls.Add(this.cargarBTN);
            this.Controls.Add(this.historiaBTN);
            this.Controls.Add(this.salirBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ventanaTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ventanaTexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button salirBTN;
        private System.Windows.Forms.Button historiaBTN;
        private System.Windows.Forms.Button cargarBTN;
        private System.Windows.Forms.Button GuardarBTN;
    }
}