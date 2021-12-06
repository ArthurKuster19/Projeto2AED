using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_airplane
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void close_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void text_input_login_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void text_input_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
