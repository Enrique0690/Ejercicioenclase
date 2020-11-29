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
    public partial class Fsumatoria : Form
    {
        public Fsumatoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int re=0;
            int inicio = int.Parse(txtinicio.Text);
            int fin = int.Parse(txtfin.Text);
            sumatoria(inicio,fin,re);
            lbrespuesta.Text="La respuesta es : "+re;
        }
        void sumatoria(int inicio, int fin, int re)
        {
            int op;
            for(int i=inicio;i<=fin;i++)
            {
                op = (2 ^ (i + 1) - 2 ^ (i))/i+1;
                re = re+op;
            }

        }
    }
}
