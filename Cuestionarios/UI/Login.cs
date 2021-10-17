using Cuestionarios.Controllers;
using Cuestionarios.Models.Domain;
using Npgsql;
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
    public partial class Login : Form
    {
        private readonly UserController _userController;
        private readonly SetController _setController;
        private readonly QuestionController _questionController;
        private readonly SessionController _sessionController;

        public Login(UserController usrController, SetController setController, QuestionController questionController, SessionController sessionController)
        {
            _userController = usrController;
            _setController = setController;
            _questionController = questionController;
            _sessionController = sessionController;
            _userController.AddUser("p", "p", false);
            User u = _userController.GetUserByName("p");
            TimeSpan duration1 = new TimeSpan(0, 0, 23, 62);
            TimeSpan duration2 = new TimeSpan(0, 0, 10, 0);
            TimeSpan duration3 = new TimeSpan(0, 0, 15, 6);
            TimeSpan duration4 = new TimeSpan(0, 0, 23, 2);

            _sessionController.SaveSession(u, 12.0, duration1);
            _sessionController.SaveSession(u, 20.0, duration2);
            _sessionController.SaveSession(u, 45.0, duration3);
            _sessionController.SaveSession(u, 5.0, duration4);

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
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User usr = _userController.GetUserByName(txtuser.Text);

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
                        this.Hide();
                        AdminPanel admin = new AdminPanel(_setController, _questionController, _sessionController, usr);
                        admin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        Menu menu = new Menu(_setController, _questionController, _sessionController, usr);
                        menu.ShowDialog();
                        this.Close();
                    }                    
                }
            }
            catch (NpgsqlException exc)
            {
                MessageBox.Show("Error on the database operation: ", exc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unknown Error: ", exc.Message);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser(_setController, _questionController, _sessionController, _userController);
            newUser.ShowDialog();
            this.Close();
        }
    }
}
