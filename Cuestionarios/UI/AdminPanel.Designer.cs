
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
            this.triviaOptions1 = new UI.TriviaOptions();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.logOut1 = new UI.LogOut();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // triviaOptions1
            // 
            this.triviaOptions1.BackColor = System.Drawing.Color.Transparent;
            this.triviaOptions1.Location = new System.Drawing.Point(36, 107);
            this.triviaOptions1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triviaOptions1.Name = "triviaOptions1";
            this.triviaOptions1.Size = new System.Drawing.Size(268, 170);
            this.triviaOptions1.TabIndex = 0;
            this.triviaOptions1.UseWaitCursor = true;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPanel.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.ForeColor = System.Drawing.Color.White;
            this.lblAdminPanel.Location = new System.Drawing.Point(206, 24);
            this.lblAdminPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(147, 28);
            this.lblAdminPanel.TabIndex = 3;
            this.lblAdminPanel.Text = "Admin Panel";
            this.lblAdminPanel.UseWaitCursor = true;
            // 
            // logOut1
            // 
            this.logOut1.BackColor = System.Drawing.Color.Transparent;
            this.logOut1.Location = new System.Drawing.Point(220, 297);
            this.logOut1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(111, 59);
            this.logOut1.TabIndex = 4;
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.BackColor = System.Drawing.Color.White;
            this.btnSaveQuestion.FlatAppearance.BorderSize = 0;
            this.btnSaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQuestion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnSaveQuestion.Location = new System.Drawing.Point(346, 116);
            this.btnSaveQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(151, 49);
            this.btnSaveQuestion.TabIndex = 19;
            this.btnSaveQuestion.Text = "Save Question";
            this.btnSaveQuestion.UseVisualStyleBackColor = false;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.White;
            this.btnDeleteQuestion.FlatAppearance.BorderSize = 0;
            this.btnDeleteQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(346, 195);
            this.btnDeleteQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(151, 49);
            this.btnDeleteQuestion.TabIndex = 20;
            this.btnDeleteQuestion.Text = "Delete Questions";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(543, 366);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnSaveQuestion);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.lblAdminPanel);
            this.Controls.Add(this.triviaOptions1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TriviaOptions triviaOptions1;
        private System.Windows.Forms.Label lblAdminPanel;
        private LogOut logOut1;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
    }
}