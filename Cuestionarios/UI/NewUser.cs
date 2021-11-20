using Cuestionarios.Controllers;
using Npgsql;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class NewUser : Form
    {
        private UserController _usrController;
        private SetController _setController;
        private QuestionController _questController;
        private SessionController _sessionController;
        public NewUser(SetController _setController, QuestionController _questController, SessionController _sessionController, UserController _usrController)
        {
            this._sessionController = _sessionController;
            this._questController = _questController;
            this._setController = _setController;
            this._usrController = _usrController;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtuser.Text) && !string.IsNullOrEmpty(txtpass.Text))
                {
                    _usrController.AddUser(txtuser.Text, txtpass.Text);
                    MessageBox.Show("User added successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You must enter all fields");
                }
            }
            catch (NpgsqlException exc)
            {
                MessageBox.Show("Error on the database operation: ", exc.Message);
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unknown Error: ", exc.Message);
            }
        }

        private void brnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
