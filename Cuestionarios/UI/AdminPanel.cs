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
    public partial class AdminPanel : Form
    {
        private readonly SetController _setController;
        private readonly QuestionController _questController;
        private SessionController _sessionController;
        private User user = null;
        public AdminPanel(SetController _setController, QuestionController _questController, SessionController _sessionController, User user)
        {
            this._setController = _setController;
            this._questController = _questController;
            this._sessionController = _sessionController;
            this.user = user;
            InitializeComponent();
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
