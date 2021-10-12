using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciopractico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";

            cotizacion = "Cotizacion del automovil para " + txtnombre.Text +"\r\n";
            //obtener costo inicial
            costo = Convert.ToDouble(txtcosto.Text);

            //seguros
            if(rbbasico.Checked ==true)
            {
                costo =costo+500000.0;
                cotizacion += "lleva seguro basico de 500000 \r\n";

            }
            if(rbterceros.Checked==true)
            {
                costo+=700000.0;
                cotizacion += "lleva seguro a terceros de 700000,0 \r\n";
            }
            if(rbtotal.Checked==true)
            {
                costo+=1200000.0;
                cotizacion += "lleva seuro talo de 1200000,0 \r\n";
            }

            //equipo
            if(chkacondicionado.Checked==true)
            {
                costo += 500000.0;
                cotizacion += "con aire acondicionado de 500000 \r\n";
            }
            if(chksonido.Checked==true)
            {
                costo += 800000.0;
                cotizacion += "con sistema de sonido de 800000 \r\n";
            }
            cotizacion += "el total a pagar es de " + costo.ToString();
            txtcotizacion.Text = cotizacion;
        }

        private void equipamiento_Enter(object sender, EventArgs e)
        {

        }
    }
}
