using Cuestionarios.Controllers;
using Cuestionarios.Models.Domain;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Menu : Form
    {
        private readonly SetController _setController;
        private readonly QuestionController _questController;
        private SessionController _sessionController;
        private User user;

        public Menu(User user)
        {
            this.user = user;
            InitializeComponent();
            lblUserData.Text = user.Username;
            if (user.Admin)
            {
                btnGameManager.Show();
            }
            else
            {
                btnGameManager.Hide();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            CreateGame createGame = new CreateGame(_setController, _questController, user);
            createGame.Owner = this;
            createGame.ShowDialog();
            this.Close();
        }

        private void btnGameManager_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(user);
            adminPanel.Owner = this;
            adminPanel.ShowDialog();
            this.Close();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            _sessionController = new SessionController();
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
