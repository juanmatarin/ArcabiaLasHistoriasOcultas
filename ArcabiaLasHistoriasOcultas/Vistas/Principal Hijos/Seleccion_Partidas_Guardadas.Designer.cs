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
            this.SuspendLayout();
            // 
            // seleccionarBTN
            // 
            this.seleccionarBTN.Location = new System.Drawing.Point(567, 446);
            this.seleccionarBTN.Name = "seleccionarBTN";
            this.seleccionarBTN.Size = new System.Drawing.Size(144, 65);
            this.seleccionarBTN.TabIndex = 0;
            this.seleccionarBTN.Text = "Seleccionar";
            this.seleccionarBTN.UseVisualStyleBackColor = true;
            this.seleccionarBTN.Click += new System.EventHandler(this.seleccionarBTN_Click);
            // 
            // PartidasLST
            // 
            this.PartidasLST.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartidasLST.FormattingEnabled = true;
            this.PartidasLST.ItemHeight = 31;
            this.PartidasLST.Location = new System.Drawing.Point(161, 76);
            this.PartidasLST.Name = "PartidasLST";
            this.PartidasLST.Size = new System.Drawing.Size(700, 345);
            this.PartidasLST.TabIndex = 1;
            // 
            // volverBTN
            // 
            this.volverBTN.Location = new System.Drawing.Point(717, 446);
            this.volverBTN.Name = "volverBTN";
            this.volverBTN.Size = new System.Drawing.Size(144, 65);
            this.volverBTN.TabIndex = 2;
            this.volverBTN.Text = "Volver";
            this.volverBTN.UseVisualStyleBackColor = true;
            this.volverBTN.Click += new System.EventHandler(this.volverBTN_Click);
            // 
            // Seleccion_Partidas_Guardadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 605);
            this.Controls.Add(this.volverBTN);
            this.Controls.Add(this.PartidasLST);
            this.Controls.Add(this.seleccionarBTN);
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
    }
}