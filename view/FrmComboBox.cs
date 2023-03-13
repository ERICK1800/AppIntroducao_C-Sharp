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
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cboDropDownList.Items.Add(txtPalavra.Text);
            txtPalavra.Clear();
            txtPalavra.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cboDropDownList.SelectedIndex < 0)
            //if (cboDropDownList.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item selecionado", "Combobox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cboDropDownList.Items.RemoveAt(cboDropDownList.SelectedIndex);
                //lblPosItem.Text = "";
                lblPosItem.Clear();
                lblTextoSel.Clear();
                lblTotal.Clear();
            }
        }

        private void btnLimparComboBox_Click(object sender, EventArgs e)
        {
            cboDropDownList.Items.Clear();
            limpar();
        }

        private void btnLimparPalavra_Click(object sender, EventArgs e)
        {
            cboDropDownList.SelectedIndex = -1;
            limpar();
        }

        private void cboDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDropDownList.SelectedIndex != -1)
            {
                lblPosItem.Text = cboDropDownList.SelectedIndex.ToString();
                lblTotal.Text = cboDropDownList.Items.Count.ToString();
                lblTextoSel.Text = cboDropDownList.SelectedItem.ToString();
            }
        }

        private void txtPalavra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnAdicionar_Click(sender, e);
            }
        }

        private void limpar()
        {
            txtPalavra.Clear();
            lblPosItem.Text = "";
            lblTextoSel.Clear();
            lblTotal.Clear();
        }
    }
}
