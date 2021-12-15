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
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alef_\OneDrive\Documentos\AirplaneDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);  
            passangerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void close_view_passanger_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void back_viewpassenger_Click(object sender, EventArgs e)
        {
            AddPassenger addpas = new AddPassenger();
            addpas.Show();
            this.Hide();
        }

        private void delete_button_login_Click(object sender, EventArgs e)
        {
           if(cpf_view.Text == "")
            {
                MessageBox.Show("Selecione o CPF do passageiro para Deletar");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PassengerTbl where PassCPF= " + cpf_view.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário deletado com sucesso!");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    Con.Close();
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void passangerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cpf_view.Text = passangerDGV.SelectedRows[0].Cells[0].Value.ToString();
            PnameTb.Text = passangerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PpassTb.Text = passangerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PaddTb.Text = passangerDGV.SelectedRows[0].Cells[3].Value.ToString();
            nmr_client_view.Text = passangerDGV.SelectedRows[0].Cells[6].Value.ToString();
            natCb.SelectedItem = passangerDGV.SelectedRows[0].Cells[4].Value.ToString();
            GendCb.SelectedItem = passangerDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void reset_button_view_Click(object sender, EventArgs e)
        {
            cpf_view.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddTb.Text = "";
            nmr_client_view.Text = "";
           natCb.SelectedItem = "";
            GendCb.SelectedItem = "";
        }

        private void update_passenger_view_Click(object sender, EventArgs e)
        {
            if (cpf_view.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" || PaddTb.Text == "")
            {
                MessageBox.Show("Procurando por informações");
            }else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengerTbl set PassName='"+PnameTb.Text+"', Passport="+ PpassTb.Text + ", PassAd='"+ PaddTb.Text + "', PassPhone="+ nmr_client_view.Text + " where PassCPF = "+cpf_view.Text+"";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário atualizado");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    Con.Close();
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
