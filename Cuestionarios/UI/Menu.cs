using Cuestionarios.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Menu : Form
    {
        private readonly SetController _setController;
        private readonly QuestionController _questController;

        public Menu()
        {
            InitializeComponent();
        }

        private void logOutComponent1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            CreateGame createGame = new CreateGame(_setController, _questController);
            createGame.Owner = this;
            createGame.Show();
            this.Hide();
        }

        private void btnGameManager_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Owner = this;
            adminPanel.Show();
            this.Hide();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            Score score = new Score();
            score.Owner = this;
            score.Show();
            this.Hide();
        }
    }
}
