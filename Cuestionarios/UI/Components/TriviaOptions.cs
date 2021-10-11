using Cuestionarios.Controllers;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class TriviaOptions : UserControl
    {
        public SetController _setController;
        public QuestionController _questionController;

        public TriviaOptions()
        {
            InitializeComponent();
        }

        private void TriviaOptionsComponent_Load(object sender, EventArgs e)
        {
            /// Load the sets into the comboBox
            foreach (var item in _setController.GetAllSets())
            {
                cmbSet.Items.Add(item.Name.ToString());
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDificulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nupAmount_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
