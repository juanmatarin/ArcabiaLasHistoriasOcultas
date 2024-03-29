﻿namespace ArcabiaLasHistoriasOcultas.Vistas
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
            this.cargarBTN = new System.Windows.Forms.Button();
            this.GuardarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ventanaTexto
            // 
            this.ventanaTexto.Location = new System.Drawing.Point(93, 44);
            this.ventanaTexto.MinimumSize = new System.Drawing.Size(20, 20);
            this.ventanaTexto.Name = "ventanaTexto";
            this.ventanaTexto.Size = new System.Drawing.Size(963, 446);
            this.ventanaTexto.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.FondoListas;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(93, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 141);
            this.panel1.TabIndex = 1;
            // 
            // salirBTN
            // 
            this.salirBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.SalirMenu_No_Pulsado;
            this.salirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salirBTN.Location = new System.Drawing.Point(881, 596);
            this.salirBTN.Name = "salirBTN";
            this.salirBTN.Size = new System.Drawing.Size(175, 43);
            this.salirBTN.TabIndex = 5;
            this.salirBTN.UseVisualStyleBackColor = true;
            this.salirBTN.Click += new System.EventHandler(this.salirBTN_Click);
            this.salirBTN.MouseLeave += new System.EventHandler(this.salirBTN_MouseLeave);
            this.salirBTN.MouseHover += new System.EventHandler(this.salirBTN_MouseHover);
            // 
            // cargarBTN
            // 
            this.cargarBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.Cargar_No_Pulsado;
            this.cargarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargarBTN.Location = new System.Drawing.Point(881, 547);
            this.cargarBTN.Name = "cargarBTN";
            this.cargarBTN.Size = new System.Drawing.Size(175, 43);
            this.cargarBTN.TabIndex = 7;
            this.cargarBTN.UseVisualStyleBackColor = true;
            this.cargarBTN.Click += new System.EventHandler(this.cargarBTN_Click);
            this.cargarBTN.MouseLeave += new System.EventHandler(this.cargarBTN_MouseLeave);
            this.cargarBTN.MouseHover += new System.EventHandler(this.cargarBTN_MouseHover);
            // 
            // GuardarBTN
            // 
            this.GuardarBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.Guardar_No_Pulsado;
            this.GuardarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuardarBTN.Location = new System.Drawing.Point(881, 496);
            this.GuardarBTN.Name = "GuardarBTN";
            this.GuardarBTN.Size = new System.Drawing.Size(175, 45);
            this.GuardarBTN.TabIndex = 8;
            this.GuardarBTN.UseVisualStyleBackColor = true;
            this.GuardarBTN.Click += new System.EventHandler(this.GuardarBTN_Click);
            this.GuardarBTN.MouseLeave += new System.EventHandler(this.GuardarBTN_MouseLeave);
            this.GuardarBTN.MouseHover += new System.EventHandler(this.GuardarBTN_MouseHover);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.FondoVentanas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 697);
            this.Controls.Add(this.GuardarBTN);
            this.Controls.Add(this.cargarBTN);
            this.Controls.Add(this.salirBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ventanaTexto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ventanaTexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button salirBTN;
        private System.Windows.Forms.Button cargarBTN;
        private System.Windows.Forms.Button GuardarBTN;
    }
}