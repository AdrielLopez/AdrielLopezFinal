using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulos.BL;

namespace Triangulos.Windows
{
    public partial class FrmTriangulosAE : Form
    {
        public FrmTriangulosAE()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (triangulo == null)
                {
                    triangulo = new Triangulo();
                }
                triangulo.Lado1 = double.Parse(txtLado1.Text);
                triangulo.Lado2 = double.Parse(txtLado2.Text);
                triangulo.Lado3 = double.Parse(txtLado3.Text);
                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            double Lado1 = 0;
            double Lado2 = 0;
            double Lado3 = 0;
            if (!double.TryParse(txtLado1.Text, out Lado1))
            {
                valido = false;
                errorProvider1.SetError(txtLado1, "Dato mal ingresado");
            }
            else if (Lado1 <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLado1, "Dato mal ingresado");

            }
            if (!double.TryParse(txtLado2.Text, out Lado2))
            {
                valido = false;
                errorProvider1.SetError(txtLado2, "Dato mal ingresado");
            }
            else if (Lado2 <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLado2, "Dato mal ingresado");

            }
            if (!double.TryParse(txtLado3.Text, out Lado3))
            {
                valido = false;
                errorProvider1.SetError(txtLado3, "Dato mal ingresado");
            }
            else if (Lado3 <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLado3, "Dato mal ingresado");

            }
            if (NoEsTriangulo(Lado1, Lado2, Lado3))
            {
                valido = false;
                errorProvider1.SetError(txtLado1, "No es un triangulo");

            }
            
            return valido;
            
        }

        private bool NoEsTriangulo(double lado1, double lado2, double lado3)
        {
            return lado1 > (lado2 + lado3) || lado2 > (lado1 + lado3) || lado3 > (lado2 + lado1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Triangulo triangulo;

        public Triangulo GetTriangulo()
        {
            return triangulo;
        }

        public void SetTriangulo(Triangulo triangulo)
        {
            this.triangulo = triangulo;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (triangulo != null)
            {
                txtLado1.Text = triangulo.Lado1.ToString();
                txtLado2.Text = triangulo.Lado2.ToString();
                txtLado3.Text = triangulo.Lado3.ToString();
            }
        }
    }
}
