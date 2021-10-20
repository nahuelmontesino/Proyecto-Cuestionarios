using Cuestionarios.Controllers;
using Cuestionarios.Models.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class TriviaOptions : UserControl
    {
        private readonly SetController _setController;
        private readonly QuestionController _questionController;
        private readonly SourceController _sourceController;
        public Set setSelected;
        public string categorySelected;
        public string difficultySelected;
        private bool isAdmin;

        public TriviaOptions()
        {
            _setController = new SetController();
            _questionController = new QuestionController();
            _sourceController = new SourceController();
            InitializeComponent();
        }

        private void TriviaOptionsComponent_Load(object sender, EventArgs e)
        {
            cmbSet.DataSource = _setController.GetAllSets().ToList();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDificulty.Enabled = true;
            categorySelected = cmbCategory.SelectedValue.ToString();

            if (!isAdmin)
            {
                cmbCategory.DataSource = _questionController.GetDifficultiesOfCategory(setSelected, categorySelected);
            }
        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategory.Enabled = true;
            cmbDificulty.Enabled = isAdmin;
            nupAmount.Enabled = isAdmin;

            var set = _setController.GetSetByName(cmbSet.Text);
            setSelected = set;

            cmbCategory.DataSource = isAdmin ? _sourceController.GetAllCategories(set.Name).ToList() : _questionController.GetCategoriesOfSet(set);
            cmbDificulty.DataSource = isAdmin ? _sourceController.GetAllDifficulties(set.Name).ToList() : null;
        }

        private void cmbDificulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            nupAmount.Enabled = true;
            difficultySelected = cmbDificulty.SelectedValue.ToString();
        }

        private void nupAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
    }
}
