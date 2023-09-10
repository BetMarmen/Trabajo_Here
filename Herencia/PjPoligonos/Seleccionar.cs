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
    public partial class Seleccionar : Form
    {
        public Seleccionar()
        {
            InitializeComponent();
        }

        private void btnFigBi_Click(object sender, EventArgs e)
        {
            FigBidimencionales figBidimencionales = new FigBidimencionales();
            figBidimencionales.ShowDialog();
        }

        private void btnFigTri_Click(object sender, EventArgs e)
        {
            FigTridimencionales figTridimencionales = new FigTridimencionales();
            figTridimencionales.ShowDialog();
        }
    }
}
