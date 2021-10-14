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
        private User user = null;
        public CreateGame(SetController setControler, QuestionController questionController, User user)
        {
            this.user = user;
            InitializeComponent();
            triviaOptionsComponent1._setController = setControler;
            triviaOptionsComponent1._questionController = questionController;
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
            Menu menu = new Menu(this.user);
            menu.ShowDialog();
            this.Close();
        }
    }
}
