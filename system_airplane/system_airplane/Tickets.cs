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
    public partial class Tickets : Form
    {

        public Tickets()
        {
            InitializeComponent();
        }

        private void close_tickets_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alef_\OneDrive\Documentos\AirplaneDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void fillpassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassCPF from PassengerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassCPF", typeof(string));
            dt.Load(rdr);
            PidCb.ValueMember = "PassCPF";
            PidCb.DataSource = dt;
            Con.Close();
        }

        private void fillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FCode.ValueMember = "Fcode";
            FCode.DataSource = dt;
            Con.Close();
        }

        string pname, ppass, pnat;

        private void fetchpassenger()
        {
            Con.Open();
            string query = "select * from PassengerTbl where PassCPF = "+PidCb.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassNat"].ToString();
                PNameTb.Text = pname;
                PPassTb.Text = ppass;
                PNatTb.Text = pnat;
            }
            Con.Close();
        }

        private void save_ticket_Click(object sender, EventArgs e)
        {
            if (Tid.Text == "" || PNameTb.Text == "")
            {
                MessageBox.Show("Informações inválidas");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "insert into TicketTbl values('" + Tid.Text + "','" + FCode.SelectedValue.ToString() + "', '" + PidCb.SelectedValue.ToString() + "', '" + PNameTb.Text + "', '" + PPassTb.Text + "', '" + PNatTb.Text + "', " + PAmtTb.Text + " )";


                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ticket salvo");

                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                }

            }
        }

        private void Resete_ticket_Click(object sender, EventArgs e)
        {
            PNameTb.Text = "";
            PPassTb.Text = "";
            PNatTb.Text = "";
            PAmtTb.Text = "";
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            fillpassenger();
            fillFlightCode();
            populate();

        }

        private void PidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpassenger();
        }
    }
}
