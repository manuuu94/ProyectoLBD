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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            populateGridView();
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            button1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        }

        public void populateGridView()
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = proyecto1; USER ID = proyecto1;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECCIONAR_TIENDA_CLIENTES", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            /*añadir los parámetros*/
            comando.Parameters.Add("filas3", OracleType.Cursor).Direction = ParameterDirection.Output;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F1 = new Form2();
            F1.Show();
            this.Dispose();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
