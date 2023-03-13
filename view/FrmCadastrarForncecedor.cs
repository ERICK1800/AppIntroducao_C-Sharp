using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add
using AppIntroducao.Class;

namespace AppIntroducao.view
{
    public partial class FrmCadastrarForncecedor : Form
    {
        public FrmCadastrarForncecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor s = new Fornecedor();
            s.RazaoSocial = txtRazaoSocial.Text;
            s.Email = txtEmail.Text;
            MessageBox.Show(s.cadastrar());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Fornecedor s = new Fornecedor();
            MessageBox.Show(s.listar());
        }

        private void btnPesquisarPorID_Click(object sender, EventArgs e)
        {
            Fornecedor s = new Fornecedor();
            if (txtid.Text != "")
            {
                if (s.pesquisarPorID(txtid.Text))
                {
                    MessageBox.Show("Registro encontrado");
                    txtRazaoSocial.Text = s.RazaoSocial;
                    txtEmail.Text = s.Email;
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Informe o ID");
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string msg = "Deseja realmente excluir?";
            string titulo = "Exclusão de registro";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;

            DialogResult res = MessageBox.Show(msg, titulo, btn);


            if (res == DialogResult.Yes)
            {
                Fornecedor s = new Fornecedor();
                MessageBox.Show(s.excluir(txtid.Text));
            }
            else
            {
                MessageBox.Show("Exclusão cancelada");
            }
        }
    }
}
