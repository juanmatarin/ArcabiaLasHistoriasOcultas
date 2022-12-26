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
            this.nuevaPartidaBTN = new System.Windows.Forms.Button();
            this.continuarPartidaBTN = new System.Windows.Forms.Button();
            this.cargarPartidaBTN = new System.Windows.Forms.Button();
            this.salirBTN = new System.Windows.Forms.Button();
            this.conectarseBTN = new System.Windows.Forms.Button();
            this.usuarioConectado = new System.Windows.Forms.ToolStrip();
            this.toolStripLblUsuario = new System.Windows.Forms.ToolStripSplitButton();
            this.tuPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevaPartidaBTN
            // 
            this.nuevaPartidaBTN.BackColor = System.Drawing.Color.Transparent;
            this.nuevaPartidaBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.NuevaPartida_No_Pulsado;
            this.nuevaPartidaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuevaPartidaBTN.Location = new System.Drawing.Point(22, 275);
            this.nuevaPartidaBTN.Name = "nuevaPartidaBTN";
            this.nuevaPartidaBTN.Size = new System.Drawing.Size(146, 82);
            this.nuevaPartidaBTN.TabIndex = 2;
            this.nuevaPartidaBTN.UseVisualStyleBackColor = false;
            this.nuevaPartidaBTN.Click += new System.EventHandler(this.nuevaPartidaBTN_Click);
            this.nuevaPartidaBTN.MouseLeave += new System.EventHandler(this.nuevaPartidaBTN_MouseLeave);
            this.nuevaPartidaBTN.MouseHover += new System.EventHandler(this.nuevaPartidaBTN_MouseHover);
            // 
            // continuarPartidaBTN
            // 
            this.continuarPartidaBTN.BackColor = System.Drawing.Color.Transparent;
            this.continuarPartidaBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.ContinuarPartida_No_Pulsado;
            this.continuarPartidaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continuarPartidaBTN.Location = new System.Drawing.Point(174, 275);
            this.continuarPartidaBTN.Name = "continuarPartidaBTN";
            this.continuarPartidaBTN.Size = new System.Drawing.Size(146, 82);
            this.continuarPartidaBTN.TabIndex = 3;
            this.continuarPartidaBTN.UseVisualStyleBackColor = false;
            this.continuarPartidaBTN.Click += new System.EventHandler(this.continuarPartidaBTN_Click);
            this.continuarPartidaBTN.MouseLeave += new System.EventHandler(this.continuarPartidaBTN_MouseLeave);
            this.continuarPartidaBTN.MouseHover += new System.EventHandler(this.continuarPartidaBTN_MouseHover);
            // 
            // cargarPartidaBTN
            // 
            this.cargarPartidaBTN.BackColor = System.Drawing.Color.Transparent;
            this.cargarPartidaBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.CargarPartida_No_Pulsado;
            this.cargarPartidaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargarPartidaBTN.Location = new System.Drawing.Point(326, 275);
            this.cargarPartidaBTN.Name = "cargarPartidaBTN";
            this.cargarPartidaBTN.Size = new System.Drawing.Size(146, 82);
            this.cargarPartidaBTN.TabIndex = 4;
            this.cargarPartidaBTN.UseVisualStyleBackColor = false;
            this.cargarPartidaBTN.Click += new System.EventHandler(this.cargarPartidaBTN_Click);
            this.cargarPartidaBTN.MouseLeave += new System.EventHandler(this.cargarPartidaBTN_MouseLeave);
            this.cargarPartidaBTN.MouseHover += new System.EventHandler(this.cargarPartidaBTN_MouseHover);
            // 
            // salirBTN
            // 
            this.salirBTN.BackColor = System.Drawing.Color.Transparent;
            this.salirBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.SalirJuego_No_Pulsado;
            this.salirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salirBTN.Location = new System.Drawing.Point(478, 275);
            this.salirBTN.Name = "salirBTN";
            this.salirBTN.Size = new System.Drawing.Size(146, 82);
            this.salirBTN.TabIndex = 5;
            this.salirBTN.UseVisualStyleBackColor = false;
            this.salirBTN.Click += new System.EventHandler(this.salirBTN_Click);
            this.salirBTN.MouseLeave += new System.EventHandler(this.salirBTN_MouseLeave);
            this.salirBTN.MouseHover += new System.EventHandler(this.salirBTN_MouseHover);
            // 
            // conectarseBTN
            // 
            this.conectarseBTN.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectarseBTN.Location = new System.Drawing.Point(283, 363);
            this.conectarseBTN.Name = "conectarseBTN";
            this.conectarseBTN.Size = new System.Drawing.Size(78, 24);
            this.conectarseBTN.TabIndex = 6;
            this.conectarseBTN.Text = "Conectarse";
            this.conectarseBTN.UseVisualStyleBackColor = true;
            this.conectarseBTN.Click += new System.EventHandler(this.conectarseBTN_Click);
            // 
            // usuarioConectado
            // 
            this.usuarioConectado.Location = new System.Drawing.Point(0, 0);
            this.usuarioConectado.Name = "usuarioConectado";
            this.usuarioConectado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usuarioConectado.Size = new System.Drawing.Size(649, 25);
            this.usuarioConectado.TabIndex = 14;
            this.usuarioConectado.Text = "toolStrip1";
            // 
            // toolStripLblUsuario
            // 
            this.toolStripLblUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tuPerfilToolStripMenuItem,
            this.toolStripSeparator1,
            this.signOutToolStripMenuItem});
            this.toolStripLblUsuario.Name = "toolStripLblUsuario";
            this.toolStripLblUsuario.Size = new System.Drawing.Size(102, 22);
            this.toolStripLblUsuario.Text = "toolStripLabel1";
            // 
            // tuPerfilToolStripMenuItem
            // 
            this.tuPerfilToolStripMenuItem.Name = "tuPerfilToolStripMenuItem";
            this.tuPerfilToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.tuPerfilToolStripMenuItem.Text = "Tu perfil";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.signOutToolStripMenuItem.Text = "Sign out";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 235);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 423);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usuarioConectado);
            this.Controls.Add(this.conectarseBTN);
            this.Controls.Add(this.salirBTN);
            this.Controls.Add(this.cargarPartidaBTN);
            this.Controls.Add(this.continuarPartidaBTN);
            this.Controls.Add(this.nuevaPartidaBTN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenida";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bienvenida_FormClosing);
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nuevaPartidaBTN;
        private System.Windows.Forms.Button continuarPartidaBTN;
        private System.Windows.Forms.Button cargarPartidaBTN;
        private System.Windows.Forms.Button salirBTN;
        private System.Windows.Forms.Button conectarseBTN;
        private System.Windows.Forms.ToolStrip usuarioConectado;
        private System.Windows.Forms.ToolStripSplitButton toolStripLblUsuario;
        private System.Windows.Forms.ToolStripMenuItem tuPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}