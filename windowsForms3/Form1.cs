using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowsForms3.Formas;

namespace windowsForms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistrarse home = new FormRegistrarse();
            home.Show();
        }

        private bool ValidarCredenciales(string usuario, string contraseña)
        {
            return usuario == "Santiago_123" && contraseña == "cbtis2022";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textContra.Text;

            if (ValidarCredenciales(usuario, contraseña))
            {
                FormBienvenido home = new FormBienvenido();
                home.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Por favor, verifica el usuario y la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool passwordVisible = false;

        private void buttonMostrarCont_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                textContra.PasswordChar = '*';
                passwordVisible = false;
            }
            else
            {
                textContra.PasswordChar = '\0'; // Mostrar como texto normal
                passwordVisible = true;
            }
        }
    }
}
