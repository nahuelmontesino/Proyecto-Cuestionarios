using Cuestionarios.Controllers;
using Cuestionarios.Domain;
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
        private Set setSelected;
        private User _user = null;
        private readonly static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public AdminPanel(SetController setController, SessionController sessionController, QuestionController questionController, User user, SourceController sourceController)
        {
            _sessionController = sessionController;
            _questionController = questionController;
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

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            cmbSet.DataSource = _setController.GetAllSets().ToList();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            try
            {
                _questionController.LoadQuestions(setSelected, cmbDificulty.Text, cmbCategory.Text, decimal.ToInt32(nupAmount.Value));

                MessageBox.Show("Questions saved successfully");
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
    }
}
