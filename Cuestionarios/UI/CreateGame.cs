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
        private readonly SessionController _sessionController;
        private User _user = null;
        public CreateGame(SetController setController, QuestionController questController, SessionController sessionController, User user)
        {
            _user = user;
            _sessionController = sessionController;
            _setController = setController;
            _questController = questController;
            InitializeComponent();
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
            Menu menu = new Menu(_setController, _questController, _sessionController, _user);
            menu.ShowDialog();
            this.Close();
        }

        private void CreateGame_Load(object sender, EventArgs e)
        {
            triviaOptions.cmbSet.DataSource = _setController.GetAllSets().ToList();
            //TODO obtener las categorias disponibles una vez obtenido el set
            //triviaOptions.cmbCategory.DataSource = _questController.GetCategoriesOfSet();
            //triviaOptions1.cbmCategories = setController.GetAllDifficulties().ToList();
        }
    }
}
