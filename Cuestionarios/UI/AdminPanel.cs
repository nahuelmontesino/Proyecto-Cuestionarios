using Cuestionarios.Controllers;
using Cuestionarios.DTOs;
using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminPanel : Form
    {
        private readonly SetController _setController;
        private readonly SourceController _sourceController;
        private readonly QuestionController _questionController;
        private readonly SessionController _sessionController;
        private readonly UserDTO _user;
        private SetDTO setSelected;
        private int minAmountQuestions;
        private int maxAmountQuestions;

        private readonly static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public AdminPanel(SetController pSetController, SessionController pSessionController, QuestionController pQuestionController, UserDTO pUser, SourceController pSourceController)
        {
            _sessionController = pSessionController;
            _questionController = pQuestionController;
            _setController = pSetController;
            _sourceController = pSourceController;
            _user = pUser;
            InitializeComponent();
            
            cmbSet.DataSource = _setController.GetAllSets().ToList();
            setSelected = _setController.GetSetByName(cmbSet.Text);

            minAmountQuestions = 10;
            maxAmountQuestions = _questionController.GetNumberQuestions(setSelected.Name, cmbCategory.Text, cmbDificulty.Text);

            btnRemoveQuestions.Enabled = maxAmountQuestions > 0;
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategory.Enabled = true;
            cmbDificulty.Enabled = true;
            nupAmount.Enabled = true;

            cmbCategory.Items.Clear();

            setSelected = _setController.GetSetByName(cmbSet.Text);

            cmbCategory.DataSource = _sourceController.GetAllCategories(setSelected.Name).ToList();
            
            cmbDificulty.DataSource = _sourceController.GetAllDifficulties(setSelected.Name).ToList();

        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (nupAmount.Value < minAmountQuestions)
            {
                MessageBox.Show("The minimum number of questions is: " + minAmountQuestions);

                nupAmount.Value = minAmountQuestions;

                return;
            }

            try
            {
                _questionController.LoadQuestions(setSelected.Name, cmbDificulty.Text, cmbCategory.Text, decimal.ToInt32(nupAmount.Value));

                MessageBox.Show("Questions saved successfully");

                maxAmountQuestions = _questionController.GetNumberQuestions(setSelected.Name, cmbCategory.Text, cmbDificulty.Text);

                btnRemoveQuestions.Enabled = maxAmountQuestions > 0;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                logger.Debug("The API doesn't have enough questions for your query:" + ex.StackTrace);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                logger.Debug(ex.ToString());
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Debug(ex.ToString);  
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(_setController, _questionController, _sessionController, _user);
            menu.ShowDialog();
            this.Show();
        }

        private void btnRemoveQuestions_Click(object sender, EventArgs e)
        {
            if (nupAmount.Value > maxAmountQuestions)
            {
                MessageBox.Show("The maximum number of questions to remove is: " + maxAmountQuestions);

                nupAmount.Value = maxAmountQuestions;

                return;
            }

            try
            {
                _questionController.RemoveQuestions(setSelected.Name, cmbDificulty.Text, cmbCategory.Text, decimal.ToInt32(nupAmount.Value));

                MessageBox.Show(decimal.ToInt32(nupAmount.Value) + " questions were successfully removed");

                maxAmountQuestions = _questionController.GetNumberQuestions(setSelected.Name, cmbCategory.Text, cmbDificulty.Text);

                btnRemoveQuestions.Enabled = maxAmountQuestions > 0;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Debug(ex.ToString);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxAmountQuestions = _questionController.GetNumberQuestions(setSelected.Name, cmbCategory.Text, cmbDificulty.Text);

            btnRemoveQuestions.Enabled = maxAmountQuestions > 0;
        }

        private void cmbDificulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxAmountQuestions = _questionController.GetNumberQuestions(setSelected.Name, cmbCategory.Text, cmbDificulty.Text);

            btnRemoveQuestions.Enabled = maxAmountQuestions > 0;
        }
    }
}
