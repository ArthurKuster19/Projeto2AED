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

        private void fillpassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassCPF from PassengerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassCPF", typeof(int));
            dt.Load(rdr);
            PidCb.ValueMember = "PassCPF";
            PidCb.DataSource = dt;
            Con.Close();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            fillpassenger();
        }
    }
}
