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
    public partial class FormTrabajadores : Form
    {
        public FormTrabajadores()
        {
            InitializeComponent();
        }

        private void buttonRegistrarTrabajador_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreTrabajo.Text.Trim();
            string apellidos = textBoxApellidosTrabaj.Text.Trim();
            string fecha_ingreso = dateTimePickerFechaIngreso.Text.Trim();
            string salario = textSalario.Text.Trim();
            string horario = textHorario.Text.Trim();
            string prestamo = textPrestamo.Text.Trim();
            string curp = textCURP.Text.Trim();
            string rfc = textRFC.Text.Trim();
            string telefono = textTelefonotrabajo.Text.Trim();
            string edad = textBoxEdadTrabajo.Text.Trim();

            // Verificar campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(fecha_ingreso)
                || string.IsNullOrEmpty(salario) || string.IsNullOrEmpty(horario) || string.IsNullOrEmpty(prestamo)
                || string.IsNullOrEmpty(curp) || string.IsNullOrEmpty(rfc) || string.IsNullOrEmpty(telefono)
                || string.IsNullOrEmpty(edad))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Verificar caracteres no deseados (solo como ejemplo)
            if (nombre.Contains("$") || apellidos.Contains("$") || telefono.Contains("$"))
            {
                MessageBox.Show("Por favor, evite usar el símbolo '$' en los campos.");
                return;
            }

            // Agregar datos al DataGridView
            dataGridView3.Rows.Add(nombre, apellidos, fecha_ingreso, salario, horario, prestamo, curp, rfc, telefono, edad);

            // Limpiar campos después de agregar
            LimpiarCampos();
        }

        private void buttonEliminarTrabajador_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView3.SelectedRows)
                {
                    dataGridView3.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void LimpiarCampos()
        {
            textBoxNombreTrabajo.Text = "";
            textBoxApellidosTrabaj.Text = "";
            dateTimePickerFechaIngreso.Text = "";
            textSalario.Text = "";
            textHorario.Text = "";
            textPrestamo.Text = "";
            textCURP.Text = "";
            textRFC.Text = "";
            textTelefonotrabajo.Text = "";
            textBoxEdadTrabajo.Text = "";
        }
    }
}

