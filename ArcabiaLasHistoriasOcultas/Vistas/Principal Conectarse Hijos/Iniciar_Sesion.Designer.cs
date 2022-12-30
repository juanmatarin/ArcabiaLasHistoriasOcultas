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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.usuarioLBL = new System.Windows.Forms.Label();
            this.contrasenaLBL = new System.Windows.Forms.Label();
            this.inisesBTN = new System.Windows.Forms.Button();
            this.volverBTN = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.linkLabelCrearUser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(137, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.usuarioTXTB_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(137, 98);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(212, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextChanged += new System.EventHandler(this.contrasenaTXTB_TextChanged);
            // 
            // usuarioLBL
            // 
            this.usuarioLBL.AutoSize = true;
            this.usuarioLBL.BackColor = System.Drawing.Color.Transparent;
            this.usuarioLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLBL.Location = new System.Drawing.Point(25, 40);
            this.usuarioLBL.Name = "usuarioLBL";
            this.usuarioLBL.Size = new System.Drawing.Size(74, 24);
            this.usuarioLBL.TabIndex = 2;
            this.usuarioLBL.Text = "Usuario";
            // 
            // contrasenaLBL
            // 
            this.contrasenaLBL.AutoSize = true;
            this.contrasenaLBL.BackColor = System.Drawing.Color.Transparent;
            this.contrasenaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaLBL.Location = new System.Drawing.Point(25, 94);
            this.contrasenaLBL.Name = "contrasenaLBL";
            this.contrasenaLBL.Size = new System.Drawing.Size(106, 24);
            this.contrasenaLBL.TabIndex = 3;
            this.contrasenaLBL.Text = "Contraseña";
            // 
            // inisesBTN
            // 
            this.inisesBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.IniSes_No_Pulsado;
            this.inisesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inisesBTN.Location = new System.Drawing.Point(14, 174);
            this.inisesBTN.Name = "inisesBTN";
            this.inisesBTN.Size = new System.Drawing.Size(175, 45);
            this.inisesBTN.TabIndex = 4;
            this.inisesBTN.UseVisualStyleBackColor = true;
            this.inisesBTN.Click += new System.EventHandler(this.inisesBTN_Click);
            this.inisesBTN.MouseLeave += new System.EventHandler(this.inisesBTN_MouseLeave);
            this.inisesBTN.MouseHover += new System.EventHandler(this.inisesBTN_MouseHover);
            // 
            // volverBTN
            // 
            this.volverBTN.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.Volver_No_Pulsado;
            this.volverBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volverBTN.Cursor = System.Windows.Forms.Cursors.Default;
            this.volverBTN.Location = new System.Drawing.Point(218, 174);
            this.volverBTN.Name = "volverBTN";
            this.volverBTN.Size = new System.Drawing.Size(175, 45);
            this.volverBTN.TabIndex = 5;
            this.volverBTN.UseVisualStyleBackColor = true;
            this.volverBTN.Click += new System.EventHandler(this.volverBTN_Click);
            this.volverBTN.MouseLeave += new System.EventHandler(this.volverBTN_MouseLeave);
            this.volverBTN.MouseHover += new System.EventHandler(this.volverBTN_MouseHover);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(113, 135);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(187, 20);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Usuario y/o clave errónea";
            this.lblError.Visible = false;
            // 
            // linkLabelCrearUser
            // 
            this.linkLabelCrearUser.AutoSize = true;
            this.linkLabelCrearUser.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelCrearUser.Location = new System.Drawing.Point(29, 9);
            this.linkLabelCrearUser.Name = "linkLabelCrearUser";
            this.linkLabelCrearUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabelCrearUser.Size = new System.Drawing.Size(360, 13);
            this.linkLabelCrearUser.TabIndex = 19;
            this.linkLabelCrearUser.TabStop = true;
            this.linkLabelCrearUser.Text = "En caso de no tener un usuario creado, pulsa aquí para registrar tu usuario";
            this.linkLabelCrearUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCrearUser_LinkClicked);
            // 
            // Iniciar_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.FondoVentanas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 239);
            this.Controls.Add(this.linkLabelCrearUser);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.volverBTN);
            this.Controls.Add(this.inisesBTN);
            this.Controls.Add(this.contrasenaLBL);
            this.Controls.Add(this.usuarioLBL);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Iniciar_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar_Sesion";
            this.Load += new System.EventHandler(this.Iniciar_Sesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label usuarioLBL;
        private System.Windows.Forms.Label contrasenaLBL;
        private System.Windows.Forms.Button inisesBTN;
        private System.Windows.Forms.Button volverBTN;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.LinkLabel linkLabelCrearUser;
    }
}