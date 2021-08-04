using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNtec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            Admin lla = new Admin();
            Tutor1 lo = new Tutor1();
            Profesor lo1 = new Profesor();
            Lideres1 lo2 = new Lideres1();
            


            String usuario = txtc1.Text;
            String contrasena1 = txtc2.Text;
            String tipo = cmbtipo.Text;

            MySqlDataReader reader = null;
        




            string sql =  "SELECT CI, contrasena, tipo FROM Usuario WHERE CI = '" + usuario + "' AND Contrasena = '" + contrasena1 + "'AND tipo='"+tipo+"' ";
           






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
                        if (tipo == "administrador" )
                        {
                            lla.Show();
                            this.Hide();

                        }
                        else  if (tipo == "tutor")
                            {
                                lo.Show();
                            this.Hide();

                            }
                        else if (tipo == "lider")
                        {
                            lo2.Show();
                            this.Hide();


                        }
                        else if (tipo == "profesor")
                        {
                            lo1.Show();
                            this.Hide();


                        }
                    }
                    reader.Close();
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

       

        private void txtc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtc2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Login_Alumno la = new Login_Alumno();
            la.Show(); 
            this.Hide();

        }
    }
}
