
namespace UI.Components
{
    partial class Minimize
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minimize));
            this.pbMiniminize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniminize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMiniminize
            // 
            this.pbMiniminize.BackColor = System.Drawing.Color.Transparent;
            this.pbMiniminize.Image = ((System.Drawing.Image)(resources.GetObject("pbMiniminize.Image")));
            this.pbMiniminize.Location = new System.Drawing.Point(0, 0);
            this.pbMiniminize.Name = "pbMiniminize";
            this.pbMiniminize.Size = new System.Drawing.Size(38, 36);
            this.pbMiniminize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiniminize.TabIndex = 0;
            this.pbMiniminize.TabStop = false;
            this.pbMiniminize.Click += new System.EventHandler(this.pbMiniminize_Click);
            // 
            // Minimize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbMiniminize);
            this.Name = "Minimize";
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniminize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMiniminize;
    }
}
