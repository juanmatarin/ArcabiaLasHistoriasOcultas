﻿namespace ArcabiaLasHistoriasOcultas.Vistas
{
    partial class Seleccion_Historias
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
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.volverBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.FondoListas2;
            this.panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(851, 568);
            this.panel.TabIndex = 0;
            // 
            // volverBTN
            // 
            this.volverBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.Volver_No_Pulsado;
            this.volverBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volverBTN.Cursor = System.Windows.Forms.Cursors.Default;
            this.volverBTN.Location = new System.Drawing.Point(688, 586);
            this.volverBTN.Name = "volverBTN";
            this.volverBTN.Size = new System.Drawing.Size(175, 45);
            this.volverBTN.TabIndex = 6;
            this.volverBTN.UseVisualStyleBackColor = true;
            this.volverBTN.Click += new System.EventHandler(this.volverBTN_Click);
            // 
            // Seleccion_Historias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.FondoVentanas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 643);
            this.Controls.Add(this.volverBTN);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seleccion_Historias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion_Historias";
            this.Load += new System.EventHandler(this.Seleccion_Historias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Button volverBTN;
    }
}