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
                txtAltura.Enabled = false;
                txtBase.Enabled = false;
                txtDiametro.Enabled = true;
                txtDiametro.Focus();
                txtAltura.Text = "";
                txtBase.Text = "";
                txtDiametro.Text = "";
            }
            else if (cboFigura.SelectedItem.ToString() == "Cubo" || cboFigura
                .SelectedItem.ToString() == "Tetraedro")
            {
                txtAltura.Enabled = true;
                txtBase.Enabled = true;
                txtDiametro.Enabled = false;
                txtBase.Focus();
                txtAltura.Text = "";
                txtBase.Text = "";
                txtDiametro.Text = "";

            }
        }
    }
}
