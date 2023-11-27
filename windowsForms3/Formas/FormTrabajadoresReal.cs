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
    public partial class FormTrabajadoresReal : Form
    {
        public FormTrabajadoresReal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in dataGridView5.SelectedRows)
                {
                    dataGridView5.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
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
        private bool VerificarRFCRepetido(string rfc)
        {
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                if (row.Cells["Column6"].Value != null && row.Cells["Column6"].Value.ToString() == rfc)
                {
                    return false; // El RFC ya existe
                }
            }
            return true; // El RFC es único
        }
        private bool VerificarCURPRepetida(string curp)
        {
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                if (row.Cells["Column7"].Value != null && row.Cells["Column7"].Value.ToString() == curp)
                {
                    return false; // La CURP ya existe
                }
            }
            return true; // La CURP es única
        }
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = textnombre.Text;
            string apellidos = textapellidos.Text;
            string fecha_ingreso = textfechaingreso.Text;
            string edad = textedad.Text;
            string salario = textsalario.Text;
            string rfc = textrfc.Text;
            string curp = textcurp.Text;
            string telefono = texttelefono.Text;
            string prestamo = textprestamo.Text;
            string horario = texthorario.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(rfc) ||
                string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(curp) ||
                string.IsNullOrWhiteSpace(fecha_ingreso) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(edad) || string.IsNullOrWhiteSpace(prestamo) ||
                string.IsNullOrWhiteSpace(salario) || string.IsNullOrWhiteSpace(horario))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ContieneSoloNumeros(edad) || !ContieneSoloNumeros(salario) || !ContieneSoloNumeros(telefono) || !ContieneSoloNumeros(prestamo))
            {
                MessageBox.Show("Por favor, ingrese solo números en campos como Edad, Salario, Teléfono y Préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ContieneSoloLetras(nombre) || !ContieneSoloLetras(apellidos))
            {
                MessageBox.Show("Por favor, ingrese solo letras en campos como Nombre y Apellidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!VerificarRFCRepetido(rfc))
            {
                MessageBox.Show("El RFC ingresado ya existe. Ingrese un RFC único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!VerificarCURPRepetida(curp))
            {
                MessageBox.Show("La CURP ingresada ya existe. Ingrese una CURP única.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Los datos son válidos, procede a agregarlos al DataGridView
                dataGridView5.Rows.Add(nombre, apellidos, fecha_ingreso, edad, salario, rfc, curp, telefono, prestamo, horario);
                EliminarDatos();
            }


        }
        private void EliminarDatos()
        {
            textnombre.Text = "";
            textapellidos.Text = "";
            textfechaingreso.Text = "";
            textedad.Text = "";
            textsalario.Text = "";
            textrfc.Text = "";
            textcurp.Text = "";
            textprestamo.Text = "";
            texttelefono.Text = "";
            texthorario.Text = "";
        }


        private void textClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIngredientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSabor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFechacad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCalorias_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
