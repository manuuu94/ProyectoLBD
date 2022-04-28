using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLBD
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent(); 
            button1.Text = "VER LAVADOS ADMIN."; /*Form8*/
            button3.Text = "VER TIENDA ADMIN."; /*Form9*/
            button2.Text = "VER REGISTROS";  /*Form10*/
            button4.Text = "VER CLIENTES"; /*Form5*/
            button5.Text = "VER FACTURAS TIENDA"; /*Form11*/
            button6.Text = "VER FACTURAS LAVADOS"; /*Form12*/
            button7.Text = "VER CAFETERIA"; /*Form13*/
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
            F8.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9();
            F9.Show();
            this.Dispose();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            this.Dispose();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form10 F10 = new Form10();
            F10.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 F11 = new Form11();
            F11.Show();
            this.Dispose();


        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            Form13 F13 = new Form13();
            F13.Show();
            this.Dispose();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            Form12 F12 = new Form12();
            F12.Show();
            this.Dispose();

        }
    }
}
