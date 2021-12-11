using Cuestionarios.Controllers;
using Cuestionarios.Domain;
using Cuestionarios.DTOs;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class CreateGame : Form
    {
        private readonly SetController _setController;
        private readonly QuestionController _questionController;
        private readonly SessionController _sessionController;
        private SetDTO selectedSet;
        private readonly User _user;
        private readonly static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public CreateGame(SetController pSetController, QuestionController pQuestionController, SessionController pSessionController, User pUser)
        {
            _user = pUser;
            _sessionController = pSessionController;
            _setController = pSetController;
            _questionController = pQuestionController;
            InitializeComponent();
            // Load the sets into the comboBox
            cmbSet.DataSource = _setController.GetAllSets().ToList();
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
            this.Close();
        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategory.Enabled = true;
            selectedSet = _setController.GetSetByName(cmbSet.Text);

            cmbCategory.DataSource = _questionController.GetCategoriesOfSet(selectedSet.Name);
        }

        private void cmbDificulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            nupAmount.Enabled = true;

            btnNewGame.Enabled = true;

            this.nupAmount.Maximum = _questionController.GetNumberQuestions(selectedSet.Name, cmbCategory.Text, cmbDificulty.Text);
           
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            int maxAmount = _questionController.GetNumberQuestions(selectedSet.Name, cmbCategory.Text, cmbDificulty.Text);

            if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                if (nupAmount.Value >= maxAmount || e.KeyValue == 109)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDificulty.Enabled = true;

            cmbDificulty.DataSource = _questionController.GetDifficultiesOfCategory(selectedSet.Name, cmbCategory.Text);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                var questionsList = _questionController.GetQuestions(selectedSet.Name, cmbDificulty.Text, cmbCategory.Text, Decimal.ToInt32(nupAmount.Value)).ToList();
                this.Hide();
                Game game = new Game(questionsList, _sessionController, _user, cmbDificulty.Text, selectedSet);
                game.ShowDialog();
                this.Show();
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                logger.Debug(ex.ToString());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                logger.Debug(ex.ToString());
            }
        }
    }
}
