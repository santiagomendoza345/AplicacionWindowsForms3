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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
        private bool VerificarClaveUnica(string clave)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["claveColumn"].Value != null && row.Cells["claveColumn"].Value.ToString() == clave)
                {
                    return false; // La clave ya existe
                }
            }
            return true; // La clave es única
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textnombreProducto.Text;
            string fechaCaducidad = textFechacad.Text;
            string contenido = textContenido.Text;
            string precio = textPrecio.Text;
            string calorias = textCalorias.Text;
            string marca = textMarca.Text;
            string sabor = textSabor.Text;
            string ingredientes = textIngredientes.Text;
            string clave = textClave.Text;

            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(fechaCaducidad) ||
                string.IsNullOrWhiteSpace(contenido) || string.IsNullOrWhiteSpace(precio) ||
                string.IsNullOrWhiteSpace(calorias) || string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(sabor) || string.IsNullOrWhiteSpace(ingredientes) ||
                string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ContieneSoloNumeros(fechaCaducidad) || !ContieneSoloNumeros(contenido) || !ContieneSoloNumeros(precio) || !ContieneSoloNumeros(calorias))
            {
                MessageBox.Show("Por favor, ingrese solo números en campos como Fecha de Caducidad, Contenido, Precio y Calorias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ContieneSoloLetras(nombre) || !ContieneSoloLetras(marca) || !ContieneSoloLetras(sabor) || !ContieneSoloLetras(ingredientes))
            {
                MessageBox.Show("Por favor, ingrese solo letras en campos como Nombre, Marca, Sabor, Ingredientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!VerificarClaveUnica(clave))
            {
                MessageBox.Show("La clave ingresada ya existe. Ingrese una clave única.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Agregar los datos al DataGridView si no hay campos vacíos
                dataGridView1.Rows.Add(nombre, fechaCaducidad, contenido, precio, marca, sabor, ingredientes, clave, calorias);
                LimpiarCampos();
            }
        }

        // Evento asociado al clic del botón "Eliminar"
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay filas seleccionadas en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada y eliminarla
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        // Método para limpiar los campos de texto
        private void LimpiarCampos()
        {
            textnombreProducto.Text = "";
            textFechacad.Text = "";
            textContenido.Text = "";
            textPrecio.Text = "";
            textCalorias.Text = "";
            textMarca.Text = "";
            textSabor.Text = "";
            textIngredientes.Text = "";
            textClave.Text = "";
        }

        private void textnombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFechacad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCalorias_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSabor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIngredientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada y eliminarla
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }
    }
    }

