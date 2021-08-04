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
    public partial class Tutor : Form
    {
        public Tutor()
        {
            InitializeComponent();
        }

        private void Llamar()
        {
            string sql = "SELECT CI, FKAsignatura, FKGrupo, Observaciones, Justificada, Injustificada, Hora, Fecha, FechaP From PasaLista"; MySqlConnection con = conexion.Conexcion();
            con.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter lolo = new MySqlDataAdapter();
                lolo.SelectCommand = comando;
                DataTable registros = new DataTable();
                lolo.Fill(registros);
                dgvtutor.DataSource = registros;

            }
            finally
            {
                con.Close();

            }
        }




        private void Tutor_Load(object sender, EventArgs e)
        {
            Llamar();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {







        }
    }
}
