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

        private void reset_button_login_Click(object sender, EventArgs e)
        {
            text_input_login.Text = "";
            text_input_password.Text = "";
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (text_input_login.Text == "" || text_input_password.Text == "")
            {
                MessageBox.Show("Campos obigratórios");
            }
            else if (text_input_login.Text == "admin" && text_input_password.Text == "admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Usuário inválido");

            }
        }
    }
}
