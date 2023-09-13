using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjPoligonos
{
    public partial class FigBiTriangulo : Form
    {
        public FigBiTriangulo()
        {
            InitializeComponent();
        }
        FigurasBidimencionales obj = new FigurasBidimencionales();

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            RealizarCalculos();

        }
        private void RealizarCalculos()
        {
            if (cboOpcion.SelectedItem == null || String.IsNullOrWhiteSpace(txtLado1.Text) || String.IsNullOrWhiteSpace(txtLado2.Text)
                || String.IsNullOrWhiteSpace(txtLado3.Text))
            {
                MessageBox.Show("Error, por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (cboOpcion.SelectedItem.ToString() == "Área")
            {
                obj.Lado1Tri = Convert.ToDouble(txtLado1.Text);
                obj.Lado2Tri = Convert.ToDouble(txtLado2.Text);
                obj.Lado3Tri = Convert.ToDouble(txtLado3.Text);
                txtResultado.Text = obj.CalcularAreaTriangulo().ToString();

            }

            else if (cboOpcion.SelectedItem.ToString() == "Perímetro")
            {

                obj.Lado1Tri = Convert.ToDouble(txtLado1.Text);
                obj.Lado2Tri = Convert.ToDouble(txtLado2.Text);
                obj.Lado3Tri = Convert.ToDouble(txtLado3.Text);
                txtResultado.Text = obj.CalcularPerimetroTriangulo().ToString();



            }

        }
    }
}
