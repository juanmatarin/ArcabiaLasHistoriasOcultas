namespace ArcabiaLasHistoriasOcultas.Vistas.Principal_Hijos
{
    partial class Bienvenida_Conectado
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
            this.salirBTN = new System.Windows.Forms.Button();
            this.cargarPartidaBTN = new System.Windows.Forms.Button();
            this.continuarPartidaBTN = new System.Windows.Forms.Button();
            this.nuevaPartidaBTN = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLblUsuario = new System.Windows.Forms.ToolStripSplitButton();
            this.tuPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salirBTN
            // 
            this.salirBTN.Location = new System.Drawing.Point(545, 295);
            this.salirBTN.Name = "salirBTN";
            this.salirBTN.Size = new System.Drawing.Size(146, 82);
            this.salirBTN.TabIndex = 11;
            this.salirBTN.Text = "Salir del Juego";
            this.salirBTN.UseVisualStyleBackColor = true;
            // 
            // cargarPartidaBTN
            // 
            this.cargarPartidaBTN.Location = new System.Drawing.Point(393, 295);
            this.cargarPartidaBTN.Name = "cargarPartidaBTN";
            this.cargarPartidaBTN.Size = new System.Drawing.Size(146, 82);
            this.cargarPartidaBTN.TabIndex = 10;
            this.cargarPartidaBTN.Text = "Cargar Partida";
            this.cargarPartidaBTN.UseVisualStyleBackColor = true;
            // 
            // continuarPartidaBTN
            // 
            this.continuarPartidaBTN.Location = new System.Drawing.Point(241, 295);
            this.continuarPartidaBTN.Name = "continuarPartidaBTN";
            this.continuarPartidaBTN.Size = new System.Drawing.Size(146, 82);
            this.continuarPartidaBTN.TabIndex = 9;
            this.continuarPartidaBTN.Text = "Continuar Partida";
            this.continuarPartidaBTN.UseVisualStyleBackColor = true;
            // 
            // nuevaPartidaBTN
            // 
            this.nuevaPartidaBTN.Location = new System.Drawing.Point(89, 295);
            this.nuevaPartidaBTN.Name = "nuevaPartidaBTN";
            this.nuevaPartidaBTN.Size = new System.Drawing.Size(146, 82);
            this.nuevaPartidaBTN.TabIndex = 8;
            this.nuevaPartidaBTN.Text = "Nueva Partida";
            this.nuevaPartidaBTN.UseVisualStyleBackColor = true;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(77, 161);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(665, 55);
            this.titulo.TabIndex = 7;
            this.titulo.Text = "Arcabia: Las Historias Ocultas";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblUsuario,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
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
            this.tuPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tuPerfilToolStripMenuItem.Text = "Tu perfil";
            this.tuPerfilToolStripMenuItem.Click += new System.EventHandler(this.tuPerfilToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Location = new System.Drawing.Point(264, 70);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(0, 13);
            this.labelBienvenido.TabIndex = 14;
            // 
            // Bienvenida_Conectado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.salirBTN);
            this.Controls.Add(this.cargarPartidaBTN);
            this.Controls.Add(this.continuarPartidaBTN);
            this.Controls.Add(this.nuevaPartidaBTN);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenida_Conectado";
            this.Text = "Bienvenido_Conectado";
            this.Load += new System.EventHandler(this.Bienvenida_Conectado_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button salirBTN;
        private System.Windows.Forms.Button cargarPartidaBTN;
        private System.Windows.Forms.Button continuarPartidaBTN;
        private System.Windows.Forms.Button nuevaPartidaBTN;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.ToolStripSplitButton toolStripLblUsuario;
        private System.Windows.Forms.ToolStripMenuItem tuPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}