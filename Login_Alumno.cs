using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNtec
{
    public partial class Login_Alumno : Form
    {
        public Login_Alumno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
        }

        public void login(string ci)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Alumno ll = new Alumno();

            String cedula = txtc1.Text;
            MySqlDataReader reader = null;


            string sql = "SELECT CI FROM Usuario WHERE CI = '" + cedula + "' ";



            MySqlConnection con = conexion.Conexcion();
            con.Open();



            try
            {

                MySqlCommand comando = new MySqlCommand(sql, con);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        txtc1.Text = reader.GetString(0);
                        MessageBox.Show("Usuario correcto");
                        ll.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
    }

