using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace system_airplane
{
    public partial class Splash : Form
    {

        public Splash()
        {
            InitializeComponent();
<<<<<<< HEAD

            my_progress_bar();
        }

        private void progress_bar_ValueChanged(object sender, EventArgs e)
        {
           
        }

        public void my_progress_bar()
        {

=======
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;

            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                
                Login login = new Login();

                login.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
>>>>>>> 1538db826358f02ffff7f24fdf3c76c27cb60b3b
        }
    }

}
