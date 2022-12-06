﻿namespace ArcabiaLasHistoriasOcultas.Vistas
{
    partial class Bienvenida
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
            this.titulo = new System.Windows.Forms.Label();
            this.nuevaPartidaBTN = new System.Windows.Forms.Button();
            this.continuarPartidaBTN = new System.Windows.Forms.Button();
            this.cargarPartidaBTN = new System.Windows.Forms.Button();
            this.salirBTN = new System.Windows.Forms.Button();
            this.conectarseBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(158, 134);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(665, 55);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Arcabia: Las Historias Ocultas";
            // 
            // nuevaPartidaBTN
            // 
            this.nuevaPartidaBTN.Location = new System.Drawing.Point(199, 359);
            this.nuevaPartidaBTN.Name = "nuevaPartidaBTN";
            this.nuevaPartidaBTN.Size = new System.Drawing.Size(146, 82);
            this.nuevaPartidaBTN.TabIndex = 2;
            this.nuevaPartidaBTN.Text = "Nueva Partida";
            this.nuevaPartidaBTN.UseVisualStyleBackColor = true;
            this.nuevaPartidaBTN.Click += new System.EventHandler(this.nuevaPartidaBTN_Click);
            // 
            // continuarPartidaBTN
            // 
            this.continuarPartidaBTN.Location = new System.Drawing.Point(351, 359);
            this.continuarPartidaBTN.Name = "continuarPartidaBTN";
            this.continuarPartidaBTN.Size = new System.Drawing.Size(146, 82);
            this.continuarPartidaBTN.TabIndex = 3;
            this.continuarPartidaBTN.Text = "Continuar Partida";
            this.continuarPartidaBTN.UseVisualStyleBackColor = true;
            this.continuarPartidaBTN.Click += new System.EventHandler(this.continuarPartidaBTN_Click);
            // 
            // cargarPartidaBTN
            // 
            this.cargarPartidaBTN.Location = new System.Drawing.Point(503, 359);
            this.cargarPartidaBTN.Name = "cargarPartidaBTN";
            this.cargarPartidaBTN.Size = new System.Drawing.Size(146, 82);
            this.cargarPartidaBTN.TabIndex = 4;
            this.cargarPartidaBTN.Text = "Cargar Partida";
            this.cargarPartidaBTN.UseVisualStyleBackColor = true;
            this.cargarPartidaBTN.Click += new System.EventHandler(this.cargarPartidaBTN_Click);
            // 
            // salirBTN
            // 
            this.salirBTN.Location = new System.Drawing.Point(655, 359);
            this.salirBTN.Name = "salirBTN";
            this.salirBTN.Size = new System.Drawing.Size(146, 82);
            this.salirBTN.TabIndex = 5;
            this.salirBTN.Text = "Salir del Juego";
            this.salirBTN.UseVisualStyleBackColor = true;
            this.salirBTN.Click += new System.EventHandler(this.salirBTN_Click);
            // 
            // conectarseBTN
            // 
            this.conectarseBTN.Location = new System.Drawing.Point(460, 447);
            this.conectarseBTN.Name = "conectarseBTN";
            this.conectarseBTN.Size = new System.Drawing.Size(78, 24);
            this.conectarseBTN.TabIndex = 6;
            this.conectarseBTN.Text = "Conectarse";
            this.conectarseBTN.UseVisualStyleBackColor = true;
            this.conectarseBTN.Click += new System.EventHandler(this.conectarseBTN_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 605);
            this.ControlBox = false;
            this.Controls.Add(this.conectarseBTN);
            this.Controls.Add(this.salirBTN);
            this.Controls.Add(this.cargarPartidaBTN);
            this.Controls.Add(this.continuarPartidaBTN);
            this.Controls.Add(this.nuevaPartidaBTN);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bienvenida_FormClosing);
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button nuevaPartidaBTN;
        private System.Windows.Forms.Button continuarPartidaBTN;
        private System.Windows.Forms.Button cargarPartidaBTN;
        private System.Windows.Forms.Button salirBTN;
        private System.Windows.Forms.Button conectarseBTN;
    }
}