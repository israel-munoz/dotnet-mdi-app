using System;
using System.Windows.Forms;

namespace Container
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
