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
    public partial class FormRegistrarse : Form
    {
        public FormRegistrarse()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool ContieneSoloNumeros(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d+$");
        }

        // Función para validar si una cadena contiene solo letras
        private bool ContieneSoloLetras(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
        private bool VerificarCodigoUnico(string codigo)
        {
            // Aquí puedes verificar si el código ya existe en el DataGridView o alguna otra fuente de datos
            // Por ejemplo, si el código ya está en el DataGridView, devuelve false, indicando que no es único
            // Aquí asumo que el DataGridView se llama dataGridView2
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Column8"].Value != null && row.Cells["Column8"].Value.ToString() == codigo)
                {
                    return false; // El código no es único
                }
            }

            // Verificar si el código tiene exactamente 6 caracteres
            return codigo.Length == 6;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string email = textBoxEmail.Text;
            string telefono = textTelefono.Text;
            string contraseña = textContraseña.Text;
            string nombres = textNombres.Text;
            string apellidos = textBoxApellidos.Text;
            string edad = textBoxEdad.Text;
            string codigo = textBoxCodigo.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(edad) ||
                string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(codigo) ||
                string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(nombres))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ContieneSoloNumeros(edad) || !ContieneSoloNumeros(telefono) ||  !ContieneSoloNumeros(codigo))
            {
                MessageBox.Show("Por favor, ingrese solo números en campos como Edad,  Teléfono y Codigo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ContieneSoloLetras(nombres) || !ContieneSoloLetras(apellidos))
            {
                MessageBox.Show("Por favor, ingrese solo letras en campos como Nombre y Apellidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!VerificarCodigoUnico(codigo))
            {
                MessageBox.Show("El código debe ser único y tener exactamente 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView2.Rows.Add(usuario, email, telefono, contraseña, nombres, apellidos, edad, codigo);

            EliminarDatos();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
            if (dataGridView2.SelectedRows.Count > 0)
            {
                
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    dataGridView2.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }
        private void EliminarDatos()
        {
            textBoxUsuario.Text = "";
            textBoxEmail.Text = "";
            textTelefono.Text = "";
            textContraseña.Text = "";
            textNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxEdad.Text = "";
            textBoxCodigo.Text = "";
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private bool passwordVisible = false;

        private void buttonMostrarContra_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                textContraseña.PasswordChar = '*';
                passwordVisible = false;
            }
            else
            {
                textContraseña.PasswordChar = '\0'; // Mostrar como texto normal
                passwordVisible = true;
            }
        }
    }
}
