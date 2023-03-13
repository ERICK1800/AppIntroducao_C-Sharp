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
    public partial class FrmCadastrarCliente : Form
    {
        public FrmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente s = new Cliente();
            s.Nome = txtNome.Text;
            s.Email = txtEmail.Text;
            s.Telefone = txtTelefone.Text;
            MessageBox.Show(s.cadastrar());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Cliente s = new Cliente();
            MessageBox.Show(s.listar()); 
        }

        private void btnPesquisarPorID_Click(object sender, EventArgs e)
        {
            Cliente s = new Cliente();
            if (txtid.Text != "")
            {
                if (s.pesquisarPorID(txtid.Text))
                {
                    MessageBox.Show("Registro encontrado");
                    txtNome.Text = s.Nome;
                    txtEmail.Text = s.Email;
                    txtTelefone.Text = s.Telefone.ToString();
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
                Cliente s = new Cliente();
                MessageBox.Show(s.excluir(txtid.Text));
            }
            else
            {
                MessageBox.Show("Exclusão cancelada");
            }
        }
    }
}
