namespace Snake_v0._5
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.puntuacion = new System.Windows.Forms.Label();
            this.fruta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // puntuacion
            // 
            this.puntuacion.AutoSize = true;
            this.puntuacion.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacion.Location = new System.Drawing.Point(835, 9);
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.Size = new System.Drawing.Size(194, 27);
            this.puntuacion.TabIndex = 0;
            this.puntuacion.Text = "PUNTUACION: 0";
            // 
            // fruta
            // 
            this.fruta.AutoSize = true;
            this.fruta.BackColor = System.Drawing.Color.DarkRed;
            this.fruta.Location = new System.Drawing.Point(403, 275);
            this.fruta.MaximumSize = new System.Drawing.Size(18, 18);
            this.fruta.MinimumSize = new System.Drawing.Size(18, 18);
            this.fruta.Name = "fruta";
            this.fruta.Size = new System.Drawing.Size(18, 18);
            this.fruta.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.fruta);
            this.Controls.Add(this.puntuacion);
            this.Font = new System.Drawing.Font("Courier New", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label puntuacion;
        private System.Windows.Forms.Label fruta;
    }
}