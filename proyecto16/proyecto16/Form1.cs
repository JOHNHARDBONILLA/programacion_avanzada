using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresultado.Text = "";
            tbA.Text = "0";
            tbB.Text = "0";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);

            double r = a + b;
            lblresultado.Text = r.ToString();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);

            double r = a * b;
            lblresultado.Text = r.ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);

            double r = a - b;
            lblresultado.Text = r.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);

            double r = a / b;
            lblresultado.Text = r.ToString();
        }
    }
}
