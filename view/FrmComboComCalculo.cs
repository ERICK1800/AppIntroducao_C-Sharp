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
    public partial class FrmComboComCalculo : Form
    {
        public FrmComboComCalculo()
        {
            InitializeComponent();
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

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (cboDropDownList.Text == "Adição")
            {
                int valor = int.Parse(txtValor1.Text) + int.Parse(txtValor2.Text);
                lblResultado.Text = "Você escolheu a operação Adição, o resultado é " + Convert.ToString(valor);
                lblPosItem.Text = "Posição da Operação: 1";
            }
            else if (cboDropDownList.Text == "Subtração")
            {
                int valor = int.Parse(txtValor1.Text) - int.Parse(txtValor2.Text);
                lblResultado.Text = "Você escolheu a operação Subtração, o resultado é " + Convert.ToString(valor);
                lblPosItem.Text = "Posição da Operação: 2";
            }
            else if (cboDropDownList.Text == "Multiplicação")
            {
                int valor = int.Parse(txtValor1.Text) * int.Parse(txtValor2.Text);
                lblResultado.Text = "Você escolheu a operação Multiplicação, o resultado é " + Convert.ToString(valor);
                lblPosItem.Text = "Posição da Operação: 3";
            }
            else if (cboDropDownList.Text == "Divisão")
            {
                float valor = float.Parse(txtValor1.Text) / float.Parse(txtValor2.Text);
                lblResultado.Text = "Você escolheu a operação Divisão, o resultado é " + Convert.ToString(valor);
                lblPosItem.Text = "Posição da Operação: 4";
            }
            else if (cboDropDownList.Text == "Divisão de Resto - MOD")
            {
                int valor = int.Parse(txtValor1.Text) % int.Parse(txtValor2.Text);
                lblResultado.Text = "Você escolheu a operação Divisão de Resto - MOD, o resultado é " + Convert.ToString(valor);
                lblPosItem.Text = "Posição da Operação: 5";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado aqui";
            lblPosItem.Text = "Posição da Operação:";
            txtValor1.Clear();
            txtValor2.Clear();
        }
    }
}
