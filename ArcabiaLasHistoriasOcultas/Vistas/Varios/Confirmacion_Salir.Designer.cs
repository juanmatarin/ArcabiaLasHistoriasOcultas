namespace ArcabiaLasHistoriasOcultas.Vistas.Varios
{
    partial class Confirmacion_Salir
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
            this.siBTN = new System.Windows.Forms.Button();
            this.NoBTN = new System.Windows.Forms.Button();
            this.salirLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siBTN
            // 
            this.siBTN.Location = new System.Drawing.Point(50, 162);
            this.siBTN.Name = "siBTN";
            this.siBTN.Size = new System.Drawing.Size(147, 82);
            this.siBTN.TabIndex = 0;
            this.siBTN.Text = "Si";
            this.siBTN.UseVisualStyleBackColor = true;
            this.siBTN.Click += new System.EventHandler(this.siBTN_Click);
            // 
            // NoBTN
            // 
            this.NoBTN.Location = new System.Drawing.Point(277, 162);
            this.NoBTN.Name = "NoBTN";
            this.NoBTN.Size = new System.Drawing.Size(147, 82);
            this.NoBTN.TabIndex = 1;
            this.NoBTN.Text = "No";
            this.NoBTN.UseVisualStyleBackColor = true;
            this.NoBTN.Click += new System.EventHandler(this.NoBTN_Click);
            // 
            // salirLBL
            // 
            this.salirLBL.AutoSize = true;
            this.salirLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirLBL.Location = new System.Drawing.Point(15, 73);
            this.salirLBL.Name = "salirLBL";
            this.salirLBL.Size = new System.Drawing.Size(449, 37);
            this.salirLBL.TabIndex = 2;
            this.salirLBL.Text = "¿Está seguro que quiere salir?";
            // 
            // Confirmacion_Salir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 265);
            this.Controls.Add(this.salirLBL);
            this.Controls.Add(this.NoBTN);
            this.Controls.Add(this.siBTN);
            this.Name = "Confirmacion_Salir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmacion_Salir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button siBTN;
        private System.Windows.Forms.Button NoBTN;
        private System.Windows.Forms.Label salirLBL;
    }
}