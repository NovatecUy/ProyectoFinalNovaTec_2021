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
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            ////
            ///


            String ci = txt1.Text;
            String asignatura = txt2.Text;
            String grupo = txt3.Text;
            String observaciones = txt4.Text;
            String justificadas = txt5.Text;
            String injustificadas = txt6.Text;
            String hora = txt7.Text;
            String fecha = dtpfecha.Text;
            

            if (ci != "" && asignatura != "" && grupo != "" && observaciones != "" && justificadas != "" && injustificadas != "" && hora != "" && fecha !=  ""  + "")
            {

                string sql = "INSERT INTO PasaLista (CI, FKAsignatura, FKGrupo, Observaciones, Justificada, Injustificada, Hora, Fecha, FechaP) VALUES ('" + ci + "', '" + asignatura + "','" + grupo + "','" + observaciones + "','" + justificadas + "','" + injustificadas + "','" + hora + "','" + fecha + "', NOW()'" + ")";

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

