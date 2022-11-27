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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // seleccionarBTN
            // 
            this.seleccionarBTN.Location = new System.Drawing.Point(717, 448);
            this.seleccionarBTN.Name = "seleccionarBTN";
            this.seleccionarBTN.Size = new System.Drawing.Size(144, 65);
            this.seleccionarBTN.TabIndex = 0;
            this.seleccionarBTN.Text = "Seleccionar";
            this.seleccionarBTN.UseVisualStyleBackColor = true;
            this.seleccionarBTN.Click += new System.EventHandler(this.seleccionarBTN_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(161, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(700, 345);
            this.listBox1.TabIndex = 1;
            // 
            // Seleccion_Partidas_Guardadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 605);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.seleccionarBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seleccion_Partidas_Guardadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion_Partidas_Guardadas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button seleccionarBTN;
        private System.Windows.Forms.ListBox listBox1;
    }
}