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
    public partial class FrmCalculaosBasicos : Form
    {
        public FrmCalculaosBasicos()
        {
            InitializeComponent();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
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

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor1.Text) + int.Parse(txtValor2.Text);

            lblResultado.Text = txtNome.Text + ", a soma dos seus valores é igual a " + Convert.ToString(valor);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor1.Text) - int.Parse(txtValor2.Text);

            lblResultado.Text = txtNome.Text + ", a subtração dos seus valores é igual a " + Convert.ToString(valor);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor1.Text) / int.Parse(txtValor2.Text);

            lblResultado.Text = txtNome.Text + ", a divisão dos seus valores é igual a " + Convert.ToString(valor);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor1.Text) * int.Parse(txtValor2.Text);

            lblResultado.Text = txtNome.Text + ", a multiplicação dos seus valores é igual a " + Convert.ToString(valor);
        }
    }
}
