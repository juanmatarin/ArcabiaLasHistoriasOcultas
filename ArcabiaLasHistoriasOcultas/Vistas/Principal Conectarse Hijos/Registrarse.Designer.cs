namespace ArcabiaLasHistoriasOcultas.Vistas
{
    partial class Registrarse
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblErrorEdad = new System.Windows.Forms.Label();
            this.lblErrorUsername = new System.Windows.Forms.Label();
            this.lblErrorApellidos = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblErrorContraseña = new System.Windows.Forms.Label();
            this.lblErrorCorreo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRepetirContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.registrarseBTN = new System.Windows.Forms.Button();
            this.cancelarBTN = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpFechaNacimiento);
            this.tabPage1.Controls.Add(this.lblErrorEdad);
            this.tabPage1.Controls.Add(this.lblErrorUsername);
            this.tabPage1.Controls.Add(this.lblErrorApellidos);
            this.tabPage1.Controls.Add(this.lblErrorNombre);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.txtApellidos);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información Personal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(208, 166);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(217, 20);
            this.dtpFechaNacimiento.TabIndex = 29;
            // 
            // lblErrorEdad
            // 
            this.lblErrorEdad.AutoSize = true;
            this.lblErrorEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEdad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEdad.Location = new System.Drawing.Point(431, 166);
            this.lblErrorEdad.Name = "lblErrorEdad";
            this.lblErrorEdad.Size = new System.Drawing.Size(18, 24);
            this.lblErrorEdad.TabIndex = 28;
            this.lblErrorEdad.Text = "*";
            this.lblErrorEdad.Visible = false;
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.AutoSize = true;
            this.lblErrorUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsername.Location = new System.Drawing.Point(431, 127);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(18, 24);
            this.lblErrorUsername.TabIndex = 27;
            this.lblErrorUsername.Text = "*";
            this.lblErrorUsername.Visible = false;
            // 
            // lblErrorApellidos
            // 
            this.lblErrorApellidos.AutoSize = true;
            this.lblErrorApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorApellidos.ForeColor = System.Drawing.Color.Red;
            this.lblErrorApellidos.Location = new System.Drawing.Point(431, 91);
            this.lblErrorApellidos.Name = "lblErrorApellidos";
            this.lblErrorApellidos.Size = new System.Drawing.Size(18, 24);
            this.lblErrorApellidos.TabIndex = 26;
            this.lblErrorApellidos.Text = "*";
            this.lblErrorApellidos.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(431, 52);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(18, 24);
            this.lblErrorNombre.TabIndex = 25;
            this.lblErrorNombre.Text = "*";
            this.lblErrorNombre.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(208, 127);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(217, 20);
            this.txtUsername.TabIndex = 20;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(208, 91);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(217, 20);
            this.txtApellidos.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(208, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblErrorContraseña);
            this.tabPage2.Controls.Add(this.lblErrorCorreo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtRepetirContraseña);
            this.tabPage2.Controls.Add(this.txtContraseña);
            this.tabPage2.Controls.Add(this.txtCorreo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Información de la Cuenta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblErrorContraseña
            // 
            this.lblErrorContraseña.AutoSize = true;
            this.lblErrorContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContraseña.Location = new System.Drawing.Point(435, 112);
            this.lblErrorContraseña.Name = "lblErrorContraseña";
            this.lblErrorContraseña.Size = new System.Drawing.Size(18, 24);
            this.lblErrorContraseña.TabIndex = 23;
            this.lblErrorContraseña.Text = "*";
            this.lblErrorContraseña.Visible = false;
            // 
            // lblErrorCorreo
            // 
            this.lblErrorCorreo.AutoSize = true;
            this.lblErrorCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCorreo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCorreo.Location = new System.Drawing.Point(435, 75);
            this.lblErrorCorreo.Name = "lblErrorCorreo";
            this.lblErrorCorreo.Size = new System.Drawing.Size(18, 24);
            this.lblErrorCorreo.TabIndex = 22;
            this.lblErrorCorreo.Text = "*";
            this.lblErrorCorreo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Vuelva a introducir la contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Correo Electrónico";
            // 
            // txtRepetirContraseña
            // 
            this.txtRepetirContraseña.Location = new System.Drawing.Point(203, 148);
            this.txtRepetirContraseña.Name = "txtRepetirContraseña";
            this.txtRepetirContraseña.PasswordChar = '*';
            this.txtRepetirContraseña.Size = new System.Drawing.Size(217, 20);
            this.txtRepetirContraseña.TabIndex = 18;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(203, 112);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(217, 20);
            this.txtContraseña.TabIndex = 17;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(203, 75);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(217, 20);
            this.txtCorreo.TabIndex = 16;
            // 
            // registrarseBTN
            // 
            this.registrarseBTN.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarseBTN.Location = new System.Drawing.Point(248, 282);
            this.registrarseBTN.Name = "registrarseBTN";
            this.registrarseBTN.Size = new System.Drawing.Size(124, 24);
            this.registrarseBTN.TabIndex = 1;
            this.registrarseBTN.Text = "Registrarse";
            this.registrarseBTN.UseVisualStyleBackColor = true;
            this.registrarseBTN.Click += new System.EventHandler(this.registrarseBTN_Click);
            // 
            // cancelarBTN
            // 
            this.cancelarBTN.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBTN.Location = new System.Drawing.Point(378, 282);
            this.cancelarBTN.Name = "cancelarBTN";
            this.cancelarBTN.Size = new System.Drawing.Size(124, 24);
            this.cancelarBTN.TabIndex = 2;
            this.cancelarBTN.Text = "Cancelar";
            this.cancelarBTN.UseVisualStyleBackColor = true;
            this.cancelarBTN.Click += new System.EventHandler(this.cancelarBTN_Click);
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcabiaLasHistoriasOcultas.Properties.Resources.FondoVentanas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 314);
            this.Controls.Add(this.cancelarBTN);
            this.Controls.Add(this.registrarseBTN);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button registrarseBTN;
        private System.Windows.Forms.Button cancelarBTN;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblErrorEdad;
        private System.Windows.Forms.Label lblErrorUsername;
        private System.Windows.Forms.Label lblErrorApellidos;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblErrorContraseña;
        private System.Windows.Forms.Label lblErrorCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRepetirContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
    }
}