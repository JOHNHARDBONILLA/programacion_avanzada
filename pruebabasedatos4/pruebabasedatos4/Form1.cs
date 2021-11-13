using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace pruebabasedatos4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion =new SqlConnection("server=DESKTOP-FC3D69I; database=base1; integrated security=true");
            conexion.Open();
            string cod = textBox1.Text;
            string cadena = "select descripcion, precio from articulos where codigo=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label4.Text = registro["descripcion"].ToString();
                label5.Text = registro["precio"].ToString();
            }
            else
                MessageBox.Show("No existe un artículo con el codigo ingresado");
            conexion.Close();
        }
    }
}
