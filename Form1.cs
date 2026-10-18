using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPlanilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            double salarioBruto;

            // Validacion: el nombre no puede quedar vacio
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese el nombre del empleado.",
                    "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            // Validacion: el salario debe ser un numero mayor que cero
            if (!double.TryParse(txtSalarioBruto.Text, out salarioBruto) || salarioBruto <= 0)
            {
                MessageBox.Show("Ingrese un salario bruto valido mayor que cero.",
                    "Dato invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalarioBruto.Focus();
                txtSalarioBruto.SelectAll();
                return;
            }

            Empleado empleado = new Empleado(nombre, cedula, salarioBruto);

            double seguroSocial = empleado.CalcularSeguroSocial();
            double seguroEducativo = empleado.CalcularSeguroEducativo();
            double salarioNeto = empleado.CalcularSalarioNeto();

            lbSeguroSocial.Text = "Seguro Social: " + seguroSocial.ToString("F2");
            lbSeguroEducativo.Text = "Seguro Educativo: " + seguroEducativo.ToString("F2");
            lbSalarioNeto.Text = "Salario Neto: " + salarioNeto.ToString("F2");
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtSalarioBruto.Clear();
            lbSeguroSocial.Text = "";
            lbSeguroEducativo.Text = "";
            lbSalarioNeto.Text = "";
            txtNombre.Focus();
        }
    }
}
