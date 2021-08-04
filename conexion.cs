using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNtec
{
    class conexion
    {
        public static MySqlConnection Conexcion()
        {
            string servidor = "192.168.89.30";
            string bd = "2021_novatec";
            string usuario = "kalvarez";
            string password = "53785590";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);

                return con;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }


    }
}
