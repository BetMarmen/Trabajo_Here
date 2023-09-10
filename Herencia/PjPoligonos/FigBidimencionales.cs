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



      

        private void cboFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
           validarCampos();
        }
        private void validarCampos()
        {
            if (cboFigura.SelectedItem.ToString() == "Circulo")
            {
                txtAltura.Enabled = false;
                txtBase.Enabled = false;
                txtDiametro.Enabled = true;
                txtDiametro.Focus();
                txtAltura.Text = "";
                txtBase.Text = "";
                txtDiametro.Text = "";
            }
            else if (cboFigura.SelectedItem.ToString() == "Cuadrado" || cboFigura
                .SelectedItem.ToString() == "Triángulo")
            {
                txtAltura.Text = "";
                txtBase.Text = "";
                txtDiametro.Text = "";
                txtAltura.Enabled = true;
                txtBase.Enabled = true;
                txtDiametro.Enabled = false;
                txtBase.Focus();

            }
        }
    }
}
