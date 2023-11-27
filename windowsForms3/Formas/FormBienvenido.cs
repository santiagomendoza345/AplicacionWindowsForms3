using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForms3.Formas
{
    public partial class FormBienvenido : Form
    {
        public FormBienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProductos home = new FormProductos();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTrabajadoresReal home = new FormTrabajadoresReal();
            home.Show();
        }
    }
}
