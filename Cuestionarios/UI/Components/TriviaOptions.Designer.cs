
namespace UI
{
    partial class TriviaOptions
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
            this.lblSet = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDificulty = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbSet = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbDificulty = new System.Windows.Forms.ComboBox();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.ForeColor = System.Drawing.Color.White;
            this.lblSet.Location = new System.Drawing.Point(2, 10);
            this.lblSet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(31, 19);
            this.lblSet.TabIndex = 0;
            this.lblSet.Text = "Set";
            this.lblSet.UseWaitCursor = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(2, 50);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 19);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            this.lblCategory.UseWaitCursor = true;
            // 
            // lblDificulty
            // 
            this.lblDificulty.AutoSize = true;
            this.lblDificulty.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificulty.ForeColor = System.Drawing.Color.White;
            this.lblDificulty.Location = new System.Drawing.Point(2, 92);
            this.lblDificulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDificulty.Name = "lblDificulty";
            this.lblDificulty.Size = new System.Drawing.Size(66, 19);
            this.lblDificulty.TabIndex = 2;
            this.lblDificulty.Text = "Dificulty";
            this.lblDificulty.UseWaitCursor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(2, 134);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 19);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            this.lblAmount.UseWaitCursor = true;
            // 
            // cmbSet
            // 
            this.cmbSet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSet.FormattingEnabled = true;
            this.cmbSet.Location = new System.Drawing.Point(89, 10);
            this.cmbSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSet.Name = "cmbSet";
            this.cmbSet.Size = new System.Drawing.Size(159, 21);
            this.cmbSet.TabIndex = 4;
            this.cmbSet.UseWaitCursor = true;
            this.cmbSet.SelectedIndexChanged += new System.EventHandler(this.cmbSet_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(89, 50);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(159, 21);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.UseWaitCursor = true;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbDificulty
            // 
            this.cmbDificulty.FormattingEnabled = true;
            this.cmbDificulty.Location = new System.Drawing.Point(89, 92);
            this.cmbDificulty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDificulty.Name = "cmbDificulty";
            this.cmbDificulty.Size = new System.Drawing.Size(159, 21);
            this.cmbDificulty.TabIndex = 6;
            this.cmbDificulty.UseWaitCursor = true;
            this.cmbDificulty.SelectedIndexChanged += new System.EventHandler(this.cmbDificulty_SelectedIndexChanged);
            // 
            // nupAmount
            // 
            this.nupAmount.Location = new System.Drawing.Point(89, 132);
            this.nupAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(158, 20);
            this.nupAmount.TabIndex = 8;
            this.nupAmount.UseWaitCursor = true;
            this.nupAmount.ValueChanged += new System.EventHandler(this.nupAmount_ValueChanged);
            // 
            // TriviaOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.nupAmount);
            this.Controls.Add(this.cmbDificulty);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbSet);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDificulty);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSet);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TriviaOptions";
            this.Size = new System.Drawing.Size(268, 170);
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.TriviaOptionsComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDificulty;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbSet;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbDificulty;
        private System.Windows.Forms.NumericUpDown nupAmount;
    }
}
