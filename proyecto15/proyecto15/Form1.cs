﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = txtNombre.Text + " es el Nombre, saludo";
        }
    }
}
