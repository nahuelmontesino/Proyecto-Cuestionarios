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
    public partial class LogOut : UserControl
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form someForm = (Form)this.Parent;
            someForm.Hide();
            Login login = new Login();
            login.ShowDialog();
            someForm.Close();
        }
    }
}
