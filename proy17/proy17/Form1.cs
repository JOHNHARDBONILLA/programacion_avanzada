using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proy17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int Total = 0;
            if (chkpantalla.Checked == true)
                Total = Total + 400;
            if (chmouse.Checked == true)
                Total = Total + 20;
            if (chteclado.Checked == true)
                Total = Total + 18;
            MessageBox.Show("El Total es " + Total.ToString());
        }

        private void chkpantalla_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpantalla.Checked == true)
                lblmensaje.Text = "Monitor";
            else
                lblmensaje.Text = "";

                    }
    }
}
