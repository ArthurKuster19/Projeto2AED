using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace system_airplane
{
    public partial class FlightTbl : Form
    {
        public FlightTbl()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alef_\OneDrive\Documentos\AirplaneDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void close_Flight_tbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void save_fly_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || Fsrc.Text == "" || FDest.Text == "" || FDate.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Informações inválidas");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "insert into FlightTbl values(" + FcodeTb.Text + ",'" + Fsrc.SelectedItem.ToString() + "', '" + FDest.SelectedItem.ToString() + "', '" + FDate.Value.ToString() + "'," + SeatNum.Text + " )";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Voo salvo");

                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                }

            }
        }

        private void View_fly_Click(object sender, EventArgs e)
        {
            ViewFlights view = new ViewFlights();
            view.Show();
            this.Hide();
        }

        private void reset_button_new_fly_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            SeatNum.Text = "";
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }

}
