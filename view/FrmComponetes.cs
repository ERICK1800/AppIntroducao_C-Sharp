using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppIntroducao.view
{
    public partial class FrmComponetes : Form
    {
        public FrmComponetes()
        {
            InitializeComponent();
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor1.Text) + int.Parse(txtValor2.Text);

            lblResultado.Text = "Seu resultado é " + Convert.ToString(valor);
        }
    }
}
