using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("este es un ejemplo para menu");

        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);

            double r = a + b;
            lblResultado.Text = r.ToString();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);

            double r = a - b;
            lblResultado.Text = r.ToString();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);

            double r = a * b;
            lblResultado.Text = r.ToString();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);

            double r = a / b;
            lblResultado.Text = r.ToString();
        }
    }
}
