
namespace UI
{
    partial class CreateGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGame));
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblCreateGame = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbDificulty = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSet = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDificulty = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeBox
            // 
            this.minimizeBox.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(648, 0);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(35, 22);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBox.TabIndex = 10;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // exitBox
            // 
            this.exitBox.BackColor = System.Drawing.Color.Transparent;
            this.exitBox.Image = ((System.Drawing.Image)(resources.GetObject("exitBox.Image")));
            this.exitBox.Location = new System.Drawing.Point(688, 0);
            this.exitBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(35, 22);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBox.TabIndex = 11;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.White;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(496, 193);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(163, 60);
            this.btnNewGame.TabIndex = 17;
            this.btnNewGame.Text = "Start Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblCreateGame
            // 
            this.lblCreateGame.AutoSize = true;
            this.lblCreateGame.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateGame.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateGame.ForeColor = System.Drawing.Color.White;
            this.lblCreateGame.Location = new System.Drawing.Point(267, 43);
            this.lblCreateGame.Name = "lblCreateGame";
            this.lblCreateGame.Size = new System.Drawing.Size(187, 35);
            this.lblCreateGame.TabIndex = 19;
            this.lblCreateGame.Text = "Create Game";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(581, 391);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 46);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // nupAmount
            // 
            this.nupAmount.Enabled = false;
            this.nupAmount.Location = new System.Drawing.Point(229, 295);
            this.nupAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(211, 22);
            this.nupAmount.TabIndex = 38;
            this.nupAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // cmbDificulty
            // 
            this.cmbDificulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDificulty.Enabled = false;
            this.cmbDificulty.FormattingEnabled = true;
            this.cmbDificulty.Location = new System.Drawing.Point(229, 247);
            this.cmbDificulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDificulty.Name = "cmbDificulty";
            this.cmbDificulty.Size = new System.Drawing.Size(211, 24);
            this.cmbDificulty.TabIndex = 37;
            this.cmbDificulty.SelectedIndexChanged += new System.EventHandler(this.cmbDificulty_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Enabled = false;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(229, 196);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(211, 24);
            this.cmbCategory.TabIndex = 36;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbSet
            // 
            this.cmbSet.DisplayMember = "Name";
            this.cmbSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSet.FormattingEnabled = true;
            this.cmbSet.Location = new System.Drawing.Point(229, 146);
            this.cmbSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSet.Name = "cmbSet";
            this.cmbSet.Size = new System.Drawing.Size(211, 24);
            this.cmbSet.TabIndex = 35;
            this.cmbSet.SelectedIndexChanged += new System.EventHandler(this.cmbSet_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(115, 292);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(81, 24);
            this.lblAmount.TabIndex = 34;
            this.lblAmount.Text = "Amount";
            // 
            // lblDificulty
            // 
            this.lblDificulty.AutoSize = true;
            this.lblDificulty.BackColor = System.Drawing.Color.Transparent;
            this.lblDificulty.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificulty.ForeColor = System.Drawing.Color.White;
            this.lblDificulty.Location = new System.Drawing.Point(115, 244);
            this.lblDificulty.Name = "lblDificulty";
            this.lblDificulty.Size = new System.Drawing.Size(82, 24);
            this.lblDificulty.TabIndex = 33;
            this.lblDificulty.Text = "Dificulty";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(115, 193);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 24);
            this.lblCategory.TabIndex = 32;
            this.lblCategory.Text = "Category";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.BackColor = System.Drawing.Color.Transparent;
            this.lblSet.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.ForeColor = System.Drawing.Color.Transparent;
            this.lblSet.Location = new System.Drawing.Point(115, 143);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(38, 24);
            this.lblSet.TabIndex = 31;
            this.lblSet.Text = "Set";
            // 
            // CreateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.nupAmount);
            this.Controls.Add(this.cmbDificulty);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbSet);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDificulty);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCreateGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.minimizeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateGame";
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblCreateGame;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.NumericUpDown nupAmount;
        public System.Windows.Forms.ComboBox cmbDificulty;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.ComboBox cmbSet;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDificulty;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSet;
    }
}