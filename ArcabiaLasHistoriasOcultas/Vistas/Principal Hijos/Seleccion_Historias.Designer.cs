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
            this.VolverBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(851, 619);
            this.panel.TabIndex = 0;
            // 
            // VolverBTN
            // 
            this.VolverBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBTN.Location = new System.Drawing.Point(739, 637);
            this.VolverBTN.Name = "VolverBTN";
            this.VolverBTN.Size = new System.Drawing.Size(124, 45);
            this.VolverBTN.TabIndex = 1;
            this.VolverBTN.Text = "Volver";
            this.VolverBTN.UseVisualStyleBackColor = true;
            this.VolverBTN.Click += new System.EventHandler(this.VolverBTN_Click);
            // 
            // Seleccion_Historias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 698);
            this.Controls.Add(this.VolverBTN);
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
        private System.Windows.Forms.Button VolverBTN;
    }
}