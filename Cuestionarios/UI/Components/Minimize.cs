using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Components
{
    public partial class Minimize : UserControl
    {
        public Minimize()
        {
            InitializeComponent();
        }

        private void pbMiniminize_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }
    }
}
