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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Text = "LAVADOS";
            button2.Text = "TIENDA";
        }


/*
        public void servicio1()
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = 123; USER ID = MANUEL;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECCIONAR_SERVICIOS1", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("filas1", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            button1.Text = adaptador.SelectCommand.ToString();
            conexion.Close();
        }

        public void servicio2()
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = 123; USER ID = MANUEL;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECCIONAR_SERVICIOS2", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("filas1", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            button2.Text = adaptador.SelectCommand.ToString();
            conexion.Close();
        }
*/

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
        }
    }
}
