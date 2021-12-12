using Cuestionarios.Controllers;
using Cuestionarios.DTOs;
using Npgsql;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        private readonly UserController _userController;
        private readonly SetController _setController;
        private readonly QuestionController _questionController;
        private readonly SessionController _sessionController;
        private readonly SourceController _sourceController;
        private readonly static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public Login(UserController pUserController, SetController pSetController, QuestionController pQuestionController, SessionController pSessionController, SourceController pSourceController)
        {
            _userController = pUserController;
            _setController = pSetController;
            _questionController = pQuestionController;
            _sessionController = pSessionController;
            _sourceController = pSourceController;

            InitializeComponent();
        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "User")
            {
                txtuser.Text = "";
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "User";
            }
        }

        private void texpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void texpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UserDTO usr = _userController.GetUserByName(txtuser.Text);

                if (usr == null)
                {
                    MessageBox.Show("Couldn't log in: incorrect username");
                }
                else if (usr.Password != txtpass.Text)
                {
                    MessageBox.Show("Couldn't log in: incorrect password");
                }
                else
                {
                    if(usr.Admin)
                    {
                        AdminPanel admin = new AdminPanel(_setController, _sessionController, _questionController, usr, _sourceController);
                        Hide();
                        admin.ShowDialog();
                        Show();
                    }
                    else
                    {
                        Hide();
                        Menu menu = new Menu(_setController, _questionController, _sessionController, usr);
                        menu.ShowDialog();
                        Show();
                    }                    
                }
            }
            catch (NpgsqlException ex)
            {
                logger.Debug(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                logger.Debug(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            NewUser newUser = new NewUser(_userController);
            newUser.ShowDialog();
            Show();
        }
    }
}
