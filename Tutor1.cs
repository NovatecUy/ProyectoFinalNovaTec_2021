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
    public partial class Tutor1 : Form
    {

        public Tutor1()
    {
        InitializeComponent();
    }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Tutor lla = new Tutor();
            lla.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

