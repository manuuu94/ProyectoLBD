using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLBD
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = proyecto; USER ID = proyecto;");
            conexion.Open();
            OracleCommand loguear = new OracleCommand("SELECT * from USUARIOS WHERE USUARIO = :usuario AND CONTRASEñA = :contraseña", conexion);

            loguear.Parameters.AddWithValue(":usuario", textBox3.Text);
            loguear.Parameters.AddWithValue(":contraseña", textBox4.Text);

            OracleDataReader lector = loguear.ExecuteReader();

            if (lector.Read())
            {

                Form7 F1 = new Form7();
                conexion.Close();
                F1.Show();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
