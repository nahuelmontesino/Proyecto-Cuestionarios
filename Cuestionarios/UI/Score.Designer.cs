﻿
using Cuestionarios.Domain;

namespace UI
{
    partial class Score
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score));
            this.lblScores = new System.Windows.Forms.Label();
            this.scoreGridView = new System.Windows.Forms.DataGridView();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.brnAtras = new System.Windows.Forms.Button();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scoreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.White;
            this.lblScores.Location = new System.Drawing.Point(224, 33);
            this.lblScores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(81, 28);
            this.lblScores.TabIndex = 4;
            this.lblScores.Text = "Scores";
            this.lblScores.UseWaitCursor = true;
            // 
            // scoreGridView
            // 
            this.scoreGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scoreGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.scoreGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.scoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scoreGridView.Location = new System.Drawing.Point(27, 72);
            this.scoreGridView.Margin = new System.Windows.Forms.Padding(2);
            this.scoreGridView.Name = "scoreGridView";
            this.scoreGridView.RowHeadersWidth = 51;
            this.scoreGridView.RowTemplate.Height = 24;
            this.scoreGridView.Size = new System.Drawing.Size(490, 236);
            this.scoreGridView.TabIndex = 5;
            // 
            // minimizeBox
            // 
            this.minimizeBox.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(486, 0);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(26, 18);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBox.TabIndex = 25;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // exitBox
            // 
            this.exitBox.BackColor = System.Drawing.Color.Transparent;
            this.exitBox.Image = ((System.Drawing.Image)(resources.GetObject("exitBox.Image")));
            this.exitBox.Location = new System.Drawing.Point(516, 0);
            this.exitBox.Margin = new System.Windows.Forms.Padding(2);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(26, 18);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBox.TabIndex = 24;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // brnAtras
            // 
            this.brnAtras.BackColor = System.Drawing.Color.White;
            this.brnAtras.FlatAppearance.BorderSize = 0;
            this.brnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnAtras.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnAtras.ForeColor = System.Drawing.Color.Black;
            this.brnAtras.Location = new System.Drawing.Point(381, 317);
            this.brnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.brnAtras.Name = "brnAtras";
            this.brnAtras.Size = new System.Drawing.Size(151, 38);
            this.brnAtras.TabIndex = 26;
            this.brnAtras.Text = "Back";
            this.brnAtras.UseVisualStyleBackColor = false;
            this.brnAtras.Click += new System.EventHandler(this.brnAtras_Click);
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(Cuestionarios.Domain.Session);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(543, 366);
            this.Controls.Add(this.brnAtras);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.scoreGridView);
            this.Controls.Add(this.lblScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score";
            ((System.ComponentModel.ISupportInitialize)(this.scoreGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.DataGridView scoreGridView;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.Button brnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
    }
}