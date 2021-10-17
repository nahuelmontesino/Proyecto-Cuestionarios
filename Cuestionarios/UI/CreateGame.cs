using Cuestionarios.Controllers;
using Cuestionarios.Models.Domain;
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
    public partial class CreateGame : Form
    {
        private readonly SetController _setController;
        private readonly QuestionController _questController;
        private SessionController _sessionController;
        private User user = null;
        public CreateGame(SetController _setController, QuestionController _questController, SessionController _sessionController, User user)
        {
            this.user = user;
            this._sessionController = _sessionController;
            this._setController = _setController;
            this._questController = _questController;
            InitializeComponent();
            triviaOptionsComponent1._setController = _setController;
            triviaOptionsComponent1._questionController = _questController;
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(_setController, _questController, _sessionController, this.user);
            menu.ShowDialog();
            this.Close();
        }
    }
}
