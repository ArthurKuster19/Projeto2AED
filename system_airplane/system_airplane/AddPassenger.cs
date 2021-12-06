﻿using System;
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
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alef_\OneDrive\Documentos\AirplaneDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void close_add_passanger_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_new_passenger_Click(object sender, EventArgs e)
        {

            if (text_input_login.Text == "" || nameClient.Text == "" || nmr_passaport.Text == "" || end_passport.Text == "" || nmr_client.Text == "" || nat_passenger.Text == ""
                || gen_passenger.Text == "")
            {
                MessageBox.Show("Informações inválidas");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "insert into PassengerTbl values(" + text_input_login.Text + ",'" + nameClient.Text + "', " + nmr_passaport.Text + ", '" + end_passport.Text + "', '" + nat_passenger.SelectedItem.ToString() + "', '" + gen_passenger.SelectedItem.ToString() + "', " + nmr_client.Text + " )";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Passageiro salvo");

                    Con.Close();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                }
                
            }
            
        }
    }
}
