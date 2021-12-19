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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void close_home_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void show_flys_Click(object sender, EventArgs e)
        {
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        private void show_passenger_Click(object sender, EventArgs e)
        {
            AddPassenger passanger = new AddPassenger();
            passanger.Show();
            this.Hide();
        }

        private void show_tickets_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            this.Hide();
        }

        private void show_cancel_Click(object sender, EventArgs e)
        {
            CancellationTbl cancelar = new CancellationTbl();
            cancelar.Show();
            this.Hide();
        }
    }
}
