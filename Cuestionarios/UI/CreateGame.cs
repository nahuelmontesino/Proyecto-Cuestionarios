using Cuestionarios.Controllers;
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
        private readonly UserDTO _user;
        private readonly static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private SetDTO selectedSet;
        private int maxAmountQuestions;
        private int minAmountQuestions;

        public CreateGame(SetController pSetController, QuestionController pQuestionController, SessionController pSessionController, UserDTO pUser)
        {
            _user = pUser;
            _sessionController = pSessionController;
            _setController = pSetController;
            _questionController = pQuestionController;
            InitializeComponent();
            // Load the sets into the comboBox
            cmbSet.DataSource = _setController.GetAllSets().ToList();
            maxAmountQuestions = _questionController.GetNumberQuestions(selectedSet.Name, cmbCategory.Text, cmbDificulty.Text);
            minAmountQuestions = 10;
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSet = _setController.GetSetByName(cmbSet.Text);
            cmbCategory.DataSource = _questionController.GetCategoriesOfSet(selectedSet.Name);
        }

        private void cmbDificulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            nupAmount.Enabled = true;

            btnNewGame.Enabled = true;

            maxAmountQuestions = _questionController.GetNumberQuestions(selectedSet.Name, cmbCategory.Text, cmbDificulty.Text);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDificulty.Enabled = true;

            cmbDificulty.DataSource = _questionController.GetDifficultiesOfCategory(selectedSet.Name, cmbCategory.Text);

            maxAmountQuestions = _questionController.GetNumberQuestions(selectedSet.Name, cmbCategory.Text, cmbDificulty.Text);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (nupAmount.Value > maxAmountQuestions)
            {
                MessageBox.Show("The maximum number of questions is: " + maxAmountQuestions);

                nupAmount.Value = maxAmountQuestions;
            }
            else if (nupAmount.Value < minAmountQuestions)
            {
                MessageBox.Show("The minimum number of questions is: " + minAmountQuestions);

                nupAmount.Value = minAmountQuestions;
            }
            else
            {
                try
                {
                    var questionsList = _questionController.GetQuestions(selectedSet.Name, cmbDificulty.Text, cmbCategory.Text, Decimal.ToInt32(nupAmount.Value)).ToList();
                    Hide();
                    Game game = new Game(questionsList, _sessionController, _user, cmbDificulty.Text, selectedSet);
                    game.ShowDialog();
                    Show();
                }
                catch (InvalidOperationException ex)
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
}
