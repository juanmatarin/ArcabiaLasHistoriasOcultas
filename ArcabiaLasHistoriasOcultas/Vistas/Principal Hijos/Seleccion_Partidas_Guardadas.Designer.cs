namespace ArcabiaLasHistoriasOcultas.Vistas
{
    partial class Seleccion_Partidas_Guardadas
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
            this.seleccionarBTN = new System.Windows.Forms.Button();
            this.PartidasLST = new System.Windows.Forms.ListBox();
            this.volverBTN = new System.Windows.Forms.Button();
            this.borrarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seleccionarBTN
            // 
            this.seleccionarBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.Seleccionar_No_Pulsado;
            this.seleccionarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seleccionarBTN.Location = new System.Drawing.Point(59, 353);
            this.seleccionarBTN.Name = "seleccionarBTN";
            this.seleccionarBTN.Size = new System.Drawing.Size(175, 45);
            this.seleccionarBTN.TabIndex = 0;
            this.seleccionarBTN.UseVisualStyleBackColor = true;
            this.seleccionarBTN.Click += new System.EventHandler(this.seleccionarBTN_Click);
            // 
            // PartidasLST
            // 
            this.PartidasLST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PartidasLST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartidasLST.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartidasLST.ForeColor = System.Drawing.Color.White;
            this.PartidasLST.FormattingEnabled = true;
            this.PartidasLST.ItemHeight = 28;
            this.PartidasLST.Location = new System.Drawing.Point(12, 12);
            this.PartidasLST.Name = "PartidasLST";
            this.PartidasLST.Size = new System.Drawing.Size(625, 308);
            this.PartidasLST.TabIndex = 1;
            // 
            // volverBTN
            // 
            this.volverBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.Volver_No_Pulsado;
            this.volverBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volverBTN.Location = new System.Drawing.Point(421, 353);
            this.volverBTN.Name = "volverBTN";
            this.volverBTN.Size = new System.Drawing.Size(175, 45);
            this.volverBTN.TabIndex = 2;
            this.volverBTN.UseVisualStyleBackColor = true;
            this.volverBTN.Click += new System.EventHandler(this.volverBTN_Click);
            // 
            // borrarBTN
            // 
            this.borrarBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.Borrar_No_Pulsado;
            this.borrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrarBTN.Location = new System.Drawing.Point(240, 353);
            this.borrarBTN.Name = "borrarBTN";
            this.borrarBTN.Size = new System.Drawing.Size(175, 45);
            this.borrarBTN.TabIndex = 3;
            this.borrarBTN.UseVisualStyleBackColor = true;
            this.borrarBTN.Click += new System.EventHandler(this.borrarBTN_Click);
            // 
            // Seleccion_Partidas_Guardadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.FondoVentanas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 423);
            this.Controls.Add(this.borrarBTN);
            this.Controls.Add(this.volverBTN);
            this.Controls.Add(this.PartidasLST);
            this.Controls.Add(this.seleccionarBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seleccion_Partidas_Guardadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion_Partidas_Guardadas";
            this.Load += new System.EventHandler(this.Seleccion_Partidas_Guardadas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button seleccionarBTN;
        private System.Windows.Forms.ListBox PartidasLST;
        private System.Windows.Forms.Button volverBTN;
        private System.Windows.Forms.Button borrarBTN;
    }
}