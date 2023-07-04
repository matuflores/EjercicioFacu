using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFacu.Windows
{
    public partial class AreaVolumen : Form
    {
        public AreaVolumen()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double altura, radio, generatriz;
            double area, volumen;

            ValidarDatos();//valido que los datos ingresados sean NUMEROS

            altura = double.Parse(textBoxAltura.Text);
            radio = double.Parse(textBoxRadio.Text);

            generatriz = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radio, 2));
            labelGeneratriz.Text = generatriz.ToString();

            area = Math.PI * radio * (radio + generatriz);
            volumen = (Math.PI * Math.Pow(radio, 2) * altura) / 3;

            MessageBox.Show($"Dada la altura y el radio, el area es: {area} y su volumen {volumen}");

            listBoxResultado.Items.Add($"Con una altura de {altura} y un radio de {radio} obtenemos:");
            listBoxResultado.Items.Add($"Generatriz: {generatriz}");
            listBoxResultado.Items.Add($"Area: {area}");
            listBoxResultado.Items.Add($"Volumen: {volumen}");
            listBoxResultado.Items.Add(" ");
            textBoxAltura.Clear();
            textBoxRadio.Clear();
            labelGeneratriz.Text = "0";
            textBoxAltura.Focus();

        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if ( !double.TryParse(textBoxAltura.Text, out double altura) )
            {
                valido = false;
                errorProvider1.SetError(textBoxAltura, "Valor mal ingresado");
            }
            if (!double.TryParse(textBoxRadio.Text, out double radio))
            {
                valido = false;
                errorProvider1.SetError(textBoxRadio, "Valor mal ingresado");
            }
            return valido;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            textBoxAltura.Clear();
            textBoxRadio.Clear();
            labelGeneratriz.Text = "0";
            listBoxResultado.Items.Clear();
            textBoxAltura.Focus();
        }
    }
}
