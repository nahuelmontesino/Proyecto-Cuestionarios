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
        private User _user = null;
        public AdminPanel(SetController setController, User user)
        {
            _setController = setController;
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
            triviaOptions.cmbSet.DataSource = _setController.GetAllSets().ToList();
            //TODO obtener las categorias disponibles directamente desde el source
            //triviaOptions1.cbmCategories = setController.GetAllCategories().ToList();
            //triviaOptions1.cbmCategories = setController.GetAllDifficulties().ToList();
        }
    }
}
