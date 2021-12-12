using Cuestionarios.Controllers;
using Npgsql;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class NewUser : Form
    {
        private UserController _userController;

        public NewUser( UserController pUserController)
        {
            this._userController = pUserController;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtuser.Text) && !string.IsNullOrEmpty(txtpass.Text))
                {
                    _userController.AddUser(txtuser.Text, txtpass.Text);
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

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.UseSystemPasswordChar = false;
            }
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
    }
}
