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
    public partial class FrmCadastrarAluno : Form
    {
        public FrmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Aluno s = new Aluno();
            s.Nome = txtNome.Text;
            s.Email = txtEmail.Text;
            s.Idade = Int32.Parse(txtIdade.Text);
            MessageBox.Show(s.cadastrar());
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            Aluno s = new Aluno();
            MessageBox.Show(s.listar());
        }

        private void btnPesquisarPorID_Click_1(object sender, EventArgs e)
        {
            Aluno s = new Aluno();
            if (txtid.Text != "")
            {
                if (s.pesquisarPorID(txtid.Text))
                {
                    MessageBox.Show("Registro encontrado");
                    txtNome.Text = s.Nome;
                    txtEmail.Text = s.Email;
                    txtIdade.Text = s.Idade.ToString();
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

        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            string msg = "Deseja realmente excluir?";
            string titulo = "Exclusão de registro";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;

            DialogResult res = MessageBox.Show(msg, titulo, btn);


            if (res == DialogResult.Yes)
            {
                Aluno s = new Aluno();
                MessageBox.Show(s.excluir(txtid.Text));
            }
            else
            {
                MessageBox.Show("Exclusão cancelada");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string msg = "Deseja realmente alterar este registro?";
            string titulo = "Editar de registro";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;

            DialogResult res = MessageBox.Show(msg, titulo, btn);


            if (res == DialogResult.Yes)
            {
                Aluno s = new Aluno();
                s.Nome = txtNome.Text;
                s.Email = txtEmail.Text;
                s.Idade = Int32.Parse(txtIdade.Text);
                MessageBox.Show(s.editar(txtid.Text));
            }
            else
            {
                MessageBox.Show("Alteração cancelada");
            }
        }
    }
}
