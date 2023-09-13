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
    public partial class FigBidimencionales : Form
    {
        public FigBidimencionales()
        {
            InitializeComponent();
        }

        FigurasBidimencionales obj = new FigurasBidimencionales();



        private void cboFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampos();
        }
        private void validarCampos()
        {
            if (cboFigura.SelectedItem.ToString() == "Circulo" )
            {

                txtBase.Enabled = false;
                txtDiametro.Enabled = true;
                txtDiametro.Focus();

                txtBase.Text = "";
                txtDiametro.Text = "";
            }
            else if (cboFigura.SelectedItem.ToString() == "Cuadrado")
            {

                txtBase.Text = "";
                txtDiametro.Text = "";

                txtBase.Enabled = true;
                txtDiametro.Enabled = false;
                txtBase.Focus();

            }
            else if (cboFigura.SelectedItem.ToString() == "Triángulo")
            {
                FigBiTriangulo figBiTriangulo = new FigBiTriangulo();
                figBiTriangulo.ShowDialog();
                txtBase.Enabled = false;

            }
        }

       

      


        private void tntCalcular_Click(object sender, EventArgs e)
        {
         
         
            Operaciones();
          

        }

        public void Operaciones()
        {

            if (cboOpcion.SelectedItem == null || String.IsNullOrWhiteSpace(txtDiametro.Text) && String.IsNullOrWhiteSpace(txtBase.Text))
            {
                MessageBox.Show("Error, por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (cboOpcion.SelectedItem.ToString() == "Área" && cboFigura.SelectedItem.ToString() == "Circulo")
            {
                obj.DiametroCir = Convert.ToDouble(txtDiametro.Text);
                txtResultado.Text = obj.CalcularArea(cboFigura.SelectedItem.ToString()).ToString();

            }
            else if (cboOpcion.SelectedItem.ToString() == "Área" && cboFigura.SelectedItem.ToString() == "Cuadrado")
            {
                obj.LadoCuad = Convert.ToDouble(txtBase.Text);
                txtResultado.Text = obj.CalcularArea(cboFigura.SelectedItem.ToString()).ToString();

            }
            else if (cboOpcion.SelectedItem.ToString() == "Perímetro" && cboFigura.SelectedItem.ToString() == "Circulo")
            {
                obj.DiametroCir = Convert.ToDouble(txtDiametro.Text);
                txtResultado.Text = obj.CalcularPerimetro(cboFigura.SelectedItem.ToString()).ToString();

            }
            else if (cboOpcion.SelectedItem.ToString() == "Perímetro" && cboFigura.SelectedItem.ToString() == "Cuadrado")
            {
                obj.LadoCuad = Convert.ToDouble(txtBase.Text);
                txtResultado.Text = obj.CalcularPerimetro(cboFigura.SelectedItem.ToString()).ToString();

            }
            else
            {
                MessageBox.Show("Error seleccione que desea calcular");
            }
        }
    }
}
