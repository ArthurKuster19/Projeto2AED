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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }

        private void close_view_fly_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_to_save_fly_Click(object sender, EventArgs e)
        {
            FlightTbl fly = new FlightTbl();
            fly.Show();
            this.Hide();
        }

        private void reset_inputs_Click(object sender, EventArgs e)
        {
            Fcode.Text = "";
            Seatnum.Text = "";

;        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alef_\OneDrive\Documentos\AirplaneDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Fcode.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
            SrcCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
            DstCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
            Seatnum.Text = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void delete_button_list_fly_Click(object sender, EventArgs e)
        {
            if (Fcode.Text == "")
            {
                MessageBox.Show("Selecione o voo para Deletar");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FlightTbl where Fcode= " + Fcode.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Voo deletado com sucesso!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    Con.Close();
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void att_view_fly_Click(object sender, EventArgs e)
        {
            if (Fcode.Text == "" || Seatnum.Text == "")
            {
                MessageBox.Show("Procurando por informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FlightTbl set Fsrc='" + SrcCb.SelectedItem.ToString() + "', FDest='" + DstCb.SelectedItem.ToString() + "',  Fcap=" + Seatnum.Text + " where FCode = " + Fcode.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("voo atualizado");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    Con.Close();
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
