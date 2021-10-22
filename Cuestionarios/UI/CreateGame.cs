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
        private readonly QuestionController _questionController;
        private readonly SessionController _sessionController;
        private Set selectedSet;
        private readonly User _user = null;
        public CreateGame(SetController setController, QuestionController questionController, SessionController sessionController, User user)
        {
            _user = user;
            _sessionController = sessionController;
            _setController = setController;
            _questionController = questionController;
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
            Menu menu = new Menu(_setController, _questionController, _sessionController, _user);
            menu.ShowDialog();
            this.Close();
        }

        private void CreateGame_Load(object sender, EventArgs e)
        {
            btnNewGame.Enabled = false;

            // Load the sets into the comboBox
            cmbSet.DataSource = _setController.GetAllSets().ToList();
        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategory.Enabled = true;
            selectedSet = _setController.GetSetByName(cmbSet.Text);

            cmbCategory.DataSource = _questionController.GetCategoriesOfSet(selectedSet);
        }

        private void cmbDificulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            nupAmount.Enabled = true;

            btnNewGame.Enabled = true;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDificulty.Enabled = true;

            cmbDificulty.DataSource = _questionController.GetDifficultiesOfCategory(selectedSet, cmbCategory.Text);
        }
    }
}
