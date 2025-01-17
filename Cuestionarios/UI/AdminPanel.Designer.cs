﻿
namespace UI
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbDificulty = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSet = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDificulty = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            this.btnRemoveQuestions = new System.Windows.Forms.Button();
            this.logOutComponent = new UI.LogOut();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPanel.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.ForeColor = System.Drawing.Color.White;
            this.lblAdminPanel.Location = new System.Drawing.Point(275, 30);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(182, 35);
            this.lblAdminPanel.TabIndex = 3;
            this.lblAdminPanel.Text = "Admin Panel";
            this.lblAdminPanel.UseWaitCursor = true;
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.BackColor = System.Drawing.Color.White;
            this.btnSaveQuestion.FlatAppearance.BorderSize = 0;
            this.btnSaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQuestion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnSaveQuestion.Location = new System.Drawing.Point(481, 157);
            this.btnSaveQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(201, 60);
            this.btnSaveQuestion.TabIndex = 19;
            this.btnSaveQuestion.Text = "Save Questions";
            this.btnSaveQuestion.UseVisualStyleBackColor = false;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
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
            this.exitBox.TabIndex = 22;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
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
            this.minimizeBox.TabIndex = 21;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // nupAmount
            // 
            this.nupAmount.Enabled = false;
            this.nupAmount.Location = new System.Drawing.Point(205, 293);
            this.nupAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(211, 22);
            this.nupAmount.TabIndex = 30;
            this.nupAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmbDificulty
            // 
            this.cmbDificulty.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDificulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDificulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDificulty.FormattingEnabled = true;
            this.cmbDificulty.Location = new System.Drawing.Point(205, 244);
            this.cmbDificulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDificulty.Name = "cmbDificulty";
            this.cmbDificulty.Size = new System.Drawing.Size(211, 24);
            this.cmbDificulty.TabIndex = 29;
            this.cmbDificulty.SelectedIndexChanged += new System.EventHandler(this.cmbDificulty_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(205, 193);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(211, 24);
            this.cmbCategory.TabIndex = 28;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbSet
            // 
            this.cmbSet.DisplayMember = "Name";
            this.cmbSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSet.FormattingEnabled = true;
            this.cmbSet.Location = new System.Drawing.Point(205, 143);
            this.cmbSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSet.Name = "cmbSet";
            this.cmbSet.Size = new System.Drawing.Size(211, 24);
            this.cmbSet.TabIndex = 27;
            this.cmbSet.SelectedIndexChanged += new System.EventHandler(this.cmbSet_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(91, 289);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(81, 24);
            this.lblAmount.TabIndex = 26;
            this.lblAmount.Text = "Amount";
            // 
            // lblDificulty
            // 
            this.lblDificulty.AutoSize = true;
            this.lblDificulty.BackColor = System.Drawing.Color.Transparent;
            this.lblDificulty.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificulty.ForeColor = System.Drawing.Color.White;
            this.lblDificulty.Location = new System.Drawing.Point(91, 241);
            this.lblDificulty.Name = "lblDificulty";
            this.lblDificulty.Size = new System.Drawing.Size(82, 24);
            this.lblDificulty.TabIndex = 25;
            this.lblDificulty.Text = "Dificulty";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(89, 190);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 24);
            this.lblCategory.TabIndex = 24;
            this.lblCategory.Text = "Category";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.BackColor = System.Drawing.Color.Transparent;
            this.lblSet.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.ForeColor = System.Drawing.Color.Transparent;
            this.lblSet.Location = new System.Drawing.Point(89, 140);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(38, 24);
            this.lblSet.TabIndex = 23;
            this.lblSet.Text = "Set";
            // 
            // btnRemoveQuestions
            // 
            this.btnRemoveQuestions.BackColor = System.Drawing.Color.White;
            this.btnRemoveQuestions.Enabled = false;
            this.btnRemoveQuestions.FlatAppearance.BorderSize = 0;
            this.btnRemoveQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveQuestions.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveQuestions.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveQuestions.Location = new System.Drawing.Point(481, 244);
            this.btnRemoveQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveQuestions.Name = "btnRemoveQuestions";
            this.btnRemoveQuestions.Size = new System.Drawing.Size(201, 60);
            this.btnRemoveQuestions.TabIndex = 32;
            this.btnRemoveQuestions.Text = "Remove Questions";
            this.btnRemoveQuestions.UseVisualStyleBackColor = false;
            this.btnRemoveQuestions.Click += new System.EventHandler(this.btnRemoveQuestions_Click);
            // 
            // logOutComponent
            // 
            this.logOutComponent.BackColor = System.Drawing.Color.Transparent;
            this.logOutComponent.Location = new System.Drawing.Point(12, 364);
            this.logOutComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutComponent.Name = "logOutComponent";
            this.logOutComponent.Size = new System.Drawing.Size(129, 75);
            this.logOutComponent.TabIndex = 31;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.btnRemoveQuestions);
            this.Controls.Add(this.logOutComponent);
            this.Controls.Add(this.nupAmount);
            this.Controls.Add(this.cmbDificulty);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbSet);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDificulty);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.btnSaveQuestion);
            this.Controls.Add(this.lblAdminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox minimizeBox;
        private LogOut logOut1;
        public System.Windows.Forms.NumericUpDown nupAmount;
        public System.Windows.Forms.ComboBox cmbDificulty;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.ComboBox cmbSet;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDificulty;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSet;
        private LogOut logOutComponent;
        private System.Windows.Forms.Button btnRemoveQuestions;
    }
}