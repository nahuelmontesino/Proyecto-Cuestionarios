using System;
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
            someForm.Close();
        }
    }
}
