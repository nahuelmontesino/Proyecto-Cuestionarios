
namespace UI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnGameManager = new System.Windows.Forms.Button();
            this.logOutComponent1 = new UI.LogOut();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.lblGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGameManager
            // 
            this.btnGameManager.BackColor = System.Drawing.Color.White;
            this.btnGameManager.FlatAppearance.BorderSize = 0;
            this.btnGameManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameManager.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameManager.ForeColor = System.Drawing.Color.Black;
            this.btnGameManager.Location = new System.Drawing.Point(37, 155);
            this.btnGameManager.Margin = new System.Windows.Forms.Padding(2);
            this.btnGameManager.Name = "btnGameManager";
            this.btnGameManager.Size = new System.Drawing.Size(271, 49);
            this.btnGameManager.TabIndex = 19;
            this.btnGameManager.Text = "Game Manager";
            this.btnGameManager.UseVisualStyleBackColor = false;
            this.btnGameManager.Click += new System.EventHandler(this.btnGameManager_Click);
            // 
            // logOutComponent1
            // 
            this.logOutComponent1.BackColor = System.Drawing.Color.Transparent;
            this.logOutComponent1.Location = new System.Drawing.Point(211, 11);
            this.logOutComponent1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOutComponent1.Name = "logOutComponent1";
            this.logOutComponent1.Size = new System.Drawing.Size(97, 61);
            this.logOutComponent1.TabIndex = 20;
            this.logOutComponent1.Load += new System.EventHandler(this.logOutComponent1_Load);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.White;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(37, 85);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(271, 49);
            this.btnNewGame.TabIndex = 21;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.BackColor = System.Drawing.Color.White;
            this.btnHighScore.FlatAppearance.BorderSize = 0;
            this.btnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighScore.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScore.ForeColor = System.Drawing.Color.Black;
            this.btnHighScore.Location = new System.Drawing.Point(37, 229);
            this.btnHighScore.Margin = new System.Windows.Forms.Padding(2);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(271, 49);
            this.btnHighScore.TabIndex = 22;
            this.btnHighScore.Text = "High Score";
            this.btnHighScore.UseVisualStyleBackColor = false;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Transparent;
            this.lblGame.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.White;
            this.lblGame.Location = new System.Drawing.Point(32, 19);
            this.lblGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(75, 28);
            this.lblGame.TabIndex = 23;
            this.lblGame.Text = "Menu";
            this.lblGame.UseWaitCursor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(348, 312);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.logOutComponent1);
            this.Controls.Add(this.btnGameManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameManager;
        private LogOut logOutComponent1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Label lblGame;
    }
}