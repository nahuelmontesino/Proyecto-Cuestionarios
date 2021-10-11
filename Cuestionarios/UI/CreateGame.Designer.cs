
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
            this.btnHighScore = new System.Windows.Forms.Button();
            this.lblCreateGame = new System.Windows.Forms.Label();
            this.logOutComponent1 = new UI.LogOut();
            this.triviaOptionsComponent1 = new UI.TriviaOptions();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeBox
            // 
            this.minimizeBox.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(648, 0);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(34, 22);
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
            this.btnNewGame.Location = new System.Drawing.Point(168, 332);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(163, 60);
            this.btnNewGame.TabIndex = 17;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.BackColor = System.Drawing.Color.White;
            this.btnHighScore.FlatAppearance.BorderSize = 0;
            this.btnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighScore.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScore.ForeColor = System.Drawing.Color.Black;
            this.btnHighScore.Location = new System.Drawing.Point(366, 332);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(160, 60);
            this.btnHighScore.TabIndex = 18;
            this.btnHighScore.Text = "High Score";
            this.btnHighScore.UseVisualStyleBackColor = false;
            // 
            // lblCreateGame
            // 
            this.lblCreateGame.AutoSize = true;
            this.lblCreateGame.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateGame.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateGame.ForeColor = System.Drawing.Color.White;
            this.lblCreateGame.Location = new System.Drawing.Point(12, 9);
            this.lblCreateGame.Name = "lblCreateGame";
            this.lblCreateGame.Size = new System.Drawing.Size(187, 35);
            this.lblCreateGame.TabIndex = 19;
            this.lblCreateGame.Text = "Create Game";
            this.lblCreateGame.Click += new System.EventHandler(this.label1_Click);
            // 
            // logOutComponent1
            // 
            this.logOutComponent1.BackColor = System.Drawing.Color.Transparent;
            this.logOutComponent1.Location = new System.Drawing.Point(573, 39);
            this.logOutComponent1.Name = "logOutComponent1";
            this.logOutComponent1.Size = new System.Drawing.Size(129, 75);
            this.logOutComponent1.TabIndex = 14;
            // 
            // triviaOptionsComponent1
            // 
            this.triviaOptionsComponent1.BackColor = System.Drawing.Color.Transparent;
            this.triviaOptionsComponent1.Location = new System.Drawing.Point(168, 95);
            this.triviaOptionsComponent1.Name = "triviaOptionsComponent1";
            this.triviaOptionsComponent1.Size = new System.Drawing.Size(358, 208);
            this.triviaOptionsComponent1.TabIndex = 13;
            this.triviaOptionsComponent1.UseWaitCursor = true;
            // 
            // CreateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.lblCreateGame);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.logOutComponent1);
            this.Controls.Add(this.triviaOptionsComponent1);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.minimizeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateGame";
            this.Load += new System.EventHandler(this.CreateGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.PictureBox exitBox;
        private TriviaOptions triviaOptionsComponent1;
        private LogOut logOutComponent1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Label lblCreateGame;
    }
}