using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicioenclase.Formularios
{
    public partial class Ffactorial : Form
    {
        public Ffactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int calcular = int.Parse(txtNumero.Text);
            string cad = Ejercicioenclase.Clases.Factorial.Factoriales(calcular);
            this.txtRespuesta.Text = cad;
        }
    }
}
