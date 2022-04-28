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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            populateGridView();
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            button2.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        }

        public void populateGridView()
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = proyecto1; USER ID = proyecto1;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECCIONAR_TIENDA_ADMIN", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            /*añadir los parámetros*/
            comando.Parameters.Add("filas5", OracleType.Cursor).Direction = ParameterDirection.Output;
            /*si hay mas parametros se usa el comando cuantas veces sea necesario*/
            /*adaptador para ajustar de Oracle a C#. Convierte informacion en la base al tipo de info en C# */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            /*seleccionamos el la variable que tiene la data de Oracle */
            adaptador.SelectCommand = comando;

            /*crear los datos en forma de tabla para mostrar como filas */
            DataTable tabla = new DataTable();
            /* llena la tabla con lo que el adaptador obtiene de Oracle */
            adaptador.Fill(tabla);
            /*se le indica al objeto gridview que se llene con la info de tabla */
            dataGridView1.DataSource = tabla;
            /*siempre cerrar la conexion */
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.Show();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = proyecto1; USER ID = proyecto1;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("INSERTARPROYECTO.INSERTARTIENDA", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("nombreProducto", OracleType.VarChar).Value = textBox1.Text;
            comando.Parameters.Add("precio", OracleType.VarChar).Value = textBox2.Text;
            comando.Parameters.Add("cantidad", OracleType.VarChar).Value = textBox3.Text;
            comando.Parameters.Add("idServicio", OracleType.VarChar).Value = 0;
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto insertado");
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = proyecto1; USER ID = proyecto1;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("ELIMINARPROYECTO.ELIMINARTIENDA", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idProducto", OracleType.Number).Value = Convert.ToInt32(textBox6.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto Eliminado");
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = proyecto1; USER ID = proyecto1;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("MODIFICARPROYECTO.MODIFICARTIENDA", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idProducto", OracleType.Number).Value = Convert.ToInt32(textBox6.Text);
            comando.Parameters.Add("nombreProducto", OracleType.VarChar).Value = textBox1.Text;
            comando.Parameters.Add("precio", OracleType.Number).Value = Convert.ToInt32(textBox2.Text);
            comando.Parameters.Add("cantidad", OracleType.Number).Value = Convert.ToInt32(textBox3.Text);
            comando.Parameters.Add("idServicio", OracleType.Number).Value =0;
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto Actualizado");
            conexion.Close();
        }
    }
}
