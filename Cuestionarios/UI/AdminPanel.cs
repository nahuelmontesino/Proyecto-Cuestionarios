using Cuestionarios.Controllers;
using Cuestionarios.Models.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminPanel : Form
    {
        private readonly SetController _setController;
        private readonly SourceController _sourceController;
        private User _user = null;
        public AdminPanel(SetController setController, SourceController sourceController, User user)
        {
            _setController = setController;
            _sourceController = sourceController;
            _user = user;
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
