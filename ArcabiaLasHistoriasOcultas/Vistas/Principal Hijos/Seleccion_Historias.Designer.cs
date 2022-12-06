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
            this.historias_sahir_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historias_sahir_btn
            // 
            this.historias_sahir_btn.Location = new System.Drawing.Point(56, 27);
            this.historias_sahir_btn.Name = "historias_sahir_btn";
            this.historias_sahir_btn.Size = new System.Drawing.Size(88, 160);
            this.historias_sahir_btn.TabIndex = 0;
            this.historias_sahir_btn.Tag = "Historia_1";
            this.historias_sahir_btn.Text = "Sahir";
            this.historias_sahir_btn.UseVisualStyleBackColor = true;
            this.historias_sahir_btn.Click += new System.EventHandler(this.historias_sahir_Click);
            // 
            // Seleccion_Historias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 605);
            this.Controls.Add(this.historias_sahir_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seleccion_Historias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion_Historias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button historias_sahir_btn;
    }
}