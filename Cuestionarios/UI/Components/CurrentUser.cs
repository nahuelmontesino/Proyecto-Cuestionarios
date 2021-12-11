using System;
using System.Windows.Forms;

namespace UI
{
    public partial class CurrentUser : UserControl
    {
        public CurrentUser(string userName)
        {
            InitializeComponent();
            this.lblUserData.Text = userName;
        }
    }
}
