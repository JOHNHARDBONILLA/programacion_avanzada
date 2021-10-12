using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercico20
{
    public partial class Form2 : Form
    {
        private string comentario;
        public Form2(string amensaje)
        {
            InitializeComponent();
            labelmensaje.Text = amensaje;
        }
        public string Comentario
        {
            set
            {
                comentario = value;
                lblcomentario.Text = comentario;
                    }
        }
    }
}
