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

    public partial class FigTridimencionales : Form
    {
        //Instanciamiento de la clase Figuras Tridimensionales
        FigurasTridemensionales objA = new();
        public FigTridimencionales()
        {
            InitializeComponent();
        }

        private void cboFigura_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void cboFigura_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            validarCampos();
        }
        private void validarCampos()
        {
            if (cboFigura.SelectedItem.ToString() == "Esfera")
            {

                txtLado.Enabled = false;
                txtDiametro.Enabled = true;
                txtDiametro.Focus();

                txtLado.Text = "";
                txtDiametro.Text = "";
            }
            else if (cboFigura.SelectedItem.ToString() == "Cubo" || cboFigura
                .SelectedItem.ToString() == "Tetraedro")
            {

                txtLado.Enabled = true;
                txtDiametro.Enabled = false;
                txtLado.Focus();

                txtLado.Text = "";
                txtDiametro.Text = "";

            }
        }

        private void tntCalcular_Click(object sender, EventArgs e)
        {
            RealizarCalculos();
        }
        //al realizar los cambios no me aparecian los cambios, habia que inicializar en el evento de seleccion de figura
        private void cboFigura_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            validarCampos();
        }

        public void RealizarCalculos()
        {
            if (cboOpcion.SelectedItem == null || String.IsNullOrWhiteSpace(txtDiametro.Text) && String.IsNullOrWhiteSpace(txtLado.Text))
            {
                MessageBox.Show("Error, por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
             else if (cboFigura.SelectedItem.ToString() == "Esfera")
             {
                objA.DiametroEsf = double.Parse(txtDiametro.Text);

             }
            else if (cboFigura.SelectedItem.ToString() == "Cubo")
            {
                objA.LadoCubo = double.Parse(txtLado.Text);
            }
            else if (cboFigura.SelectedItem.ToString() == "Tetraedro")
            {
                objA.LadoTetra = double.Parse(txtLado.Text);
            }
             
             else if (cboOpcion.SelectedItem.ToString() == "Área")
            {
               
                txtResultado.Text = objA.CalcularArea(cboFigura.SelectedItem.ToString()).ToString();

            }
            else if (cboOpcion.SelectedItem.ToString() == "Volumen")
            {
                txtResultado.Text = objA.CalcularVolumen(cboFigura.SelectedItem.ToString()).ToString();


            }
        }
    }
}
