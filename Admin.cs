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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btningresar_Click(object sender, EventArgs e)
        {

            String ci = txt2.Text;
            String contrasena = txt2.Text;
            String nombre = txt3.Text;
            String apellido = txt4.Text;
            String calle = txt5.Text;
            String ciudad = txt6.Text;
            String numero = txt7.Text;
            String creadopor = txt8.Text;
            String tipo = txt9.Text;
           // String fecha = txt10.Text;

            if (ci != "" && contrasena != "" && nombre != "" && apellido != "" && calle != "" && ciudad != "" && numero != "" && creadopor != "" && tipo != ""  + "")
            {

                string sql = "INSERT INTO usuario (CI, Contrasena, Nombre, Apellido, Calle, Ciudad, Numero, Creadopor,Tipo, Fecha) VALUES ('" + ci + "', '" + contrasena + "','" + nombre + "','" + apellido + "','" + calle + "','" + ciudad + "','" + numero + "','" + creadopor + "','" + tipo + "','"  + "')";

                MySqlConnection con = conexion.Conexcion();
                con.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, con);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void Llamar()
        {
            string sql = "SELECT CI, Contrasena, Nombre, Apellido, Calle, Ciudad, Numero, CreadoPor, Tipo, Fecha From Usuario";
            MySqlConnection con = conexion.Conexcion();
            con.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter lolo = new MySqlDataAdapter();
                lolo.SelectCommand = comando;
                DataTable registros = new DataTable();
                lolo.Fill(registros);
                dgvadmin.DataSource = registros;

            }
            finally
            {
                con.Close();

            }
        }


        private void Admin_Load(object sender, EventArgs e)
        {
            Llamar();




        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            //Actualizar
            String ci = txt2.Text;
            String contrasena = txt2.Text;
            String nombre = txt3.Text;
            String apellido = txt4.Text;
            String calle = txt5.Text;
            String ciudad = txt6.Text;
            String numero = txt7.Text;
            String creadopor = txt8.Text;
            String tipo = txt9.Text;

            string sql = "UPDATE usuario SET CI='" + ci + "', Contrasena='" + contrasena + "', Nombre='" + nombre + "', Apellido='" +apellido + "', Calle='" + calle + "', Ciudad='" + ciudad + "', Numero='" + numero + "', CreadoPor='" + creadopor + "', Tipo='" + tipo+"' WHERE CI='" + ci + "'";

            MySqlConnection con = conexion.Conexcion();
            con.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro modificado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //Eliminar
            String ci = txt2.Text;
           

            string sql = "DELETE FROM usuario WHERE codigo='" + ci + "'";

            MySqlConnection con = conexion.Conexcion();
            con.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }




        }

        private void dgvadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    




        }
    












            
    





