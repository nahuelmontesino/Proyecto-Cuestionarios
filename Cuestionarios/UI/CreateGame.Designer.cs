
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
            this.triviaOptionsComponent1 = new UI.TriviaOptions(user);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            this.SuspendLayout();
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
            this.minimizeBox.TabIndex = 10;
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
            this.btnNewGame.Location = new System.Drawing.Point(346, 116);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(122, 49);
            this.btnNewGame.TabIndex = 17;
            this.btnNewGame.Text = "Start Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            // 
            // lblCreateGame
            // 
            this.lblCreateGame.AutoSize = true;
            this.lblCreateGame.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateGame.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateGame.ForeColor = System.Drawing.Color.White;
            this.lblCreateGame.Location = new System.Drawing.Point(200, 35);
            this.lblCreateGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateGame.Name = "lblCreateGame";
            this.lblCreateGame.Size = new System.Drawing.Size(150, 28);
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
            this.btnBack.Location = new System.Drawing.Point(436, 318);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 37);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // triviaOptionsComponent1
            // 
            this.triviaOptionsComponent1.BackColor = System.Drawing.Color.Transparent;
            this.triviaOptionsComponent1.Location = new System.Drawing.Point(36, 107);
            this.triviaOptionsComponent1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triviaOptionsComponent1.Name = "triviaOptionsComponent1";
            this.triviaOptionsComponent1.Size = new System.Drawing.Size(268, 169);
            this.triviaOptionsComponent1.TabIndex = 13;
            this.triviaOptionsComponent1.UseWaitCursor = true;
            // 
            // CreateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(543, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCreateGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.triviaOptionsComponent1);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.minimizeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateGame";
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.PictureBox exitBox;
        private TriviaOptions triviaOptionsComponent1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblCreateGame;
        private System.Windows.Forms.Button btnBack;
    }
}