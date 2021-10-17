using Cuestionarios.Controllers;
using Cuestionarios.Models.Domain;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Menu : Form
    {
        private SetController _setController;
        private QuestionController _questController;
        private SessionController _sessionController;
        private User user;

        public Menu(SetController _setController, QuestionController _questController, SessionController _sessionController, User user)
        {
            this.user = user;
            this._sessionController = _sessionController;
            this._questController = _questController;
            this._setController = _setController;            
            InitializeComponent();
            lblUserData.Text = user.Username;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            CreateGame createGame = new CreateGame(_setController, _questController, _sessionController, user);
            createGame.Owner = this;
            createGame.ShowDialog();
            this.Close();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            Score score = new Score(_sessionController, user);
            this.Hide();
            score.ShowDialog();
            this.Close();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
