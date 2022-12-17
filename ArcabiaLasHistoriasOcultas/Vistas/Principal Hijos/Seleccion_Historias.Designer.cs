namespace ArcabiaLasHistoriasOcultas.Vistas
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
            this.barraLateral = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(2, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(626, 423);
            this.panel.TabIndex = 0;
            // 
            // barraLateral
            // 
            this.barraLateral.Location = new System.Drawing.Point(631, 0);
            this.barraLateral.Name = "barraLateral";
            this.barraLateral.Size = new System.Drawing.Size(19, 423);
            this.barraLateral.TabIndex = 0;
            // 
            // Seleccion_Historias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 423);
            this.Controls.Add(this.barraLateral);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seleccion_Historias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion_Historias";
            this.Load += new System.EventHandler(this.Seleccion_Historias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.VScrollBar barraLateral;
    }
}