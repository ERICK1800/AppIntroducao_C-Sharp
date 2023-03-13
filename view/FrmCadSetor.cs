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
    public partial class FrmCadSetor : Form
    {
        public FrmCadSetor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Setor s = new Setor();
            s.Descricao = txtDescricao.Text;
            s.Ramal = Int32.Parse(txtRamal.Text);
            MessageBox.Show(s.cadastrar());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Setor s = new Setor();
            MessageBox.Show(s.listar());
        }

        private void btnPesquisarPorID_Click(object sender, EventArgs e)
        {
            Setor s = new Setor();
            if (txtid.Text != "")
            {
                if (s.pesquisarPorID(txtid.Text))
                {
                    MessageBox.Show("Registro encontrado");
                    txtDescricao.Text = s.Descricao;
                    txtRamal.Text = s.Ramal.ToString();
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


            if(res == DialogResult.Yes)
            {
                Setor s = new Setor();
                MessageBox.Show(s.excluir(txtid.Text));
            }
            else
            {
                MessageBox.Show("Exclusão cancelada");
            }
        }
    }
}
