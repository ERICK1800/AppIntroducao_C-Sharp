using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppIntroducao.view;

namespace AppIntroducao
{
	public partial class FormPrincipal : Form
	{
		public FormPrincipal()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
		}

		private void ItemProdutoSair_Click(object sender, EventArgs e)
		{
			string msg = "Deseja realmente sair?";
			string titulo = "Saindo da aplicação";
			MessageBoxButtons btns = MessageBoxButtons.YesNo;

			DialogResult dialogo = MessageBox.Show(msg, titulo, btns);

			if (dialogo == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void ItemClienteSair_Click(object sender, EventArgs e)
		{
			string msg = "Deseja realmente sair?";
			string titulo = "Saindo da aplicação";
			MessageBoxButtons btns = MessageBoxButtons.YesNo;

			DialogResult dialogo = MessageBox.Show(msg, titulo, btns);

			if (dialogo == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void ItemProdutoCadastrar_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<FormProdutoCadastrar>().Count() > 0)
			{
				Application.OpenForms.OfType<FormProdutoCadastrar>().First().Focus();
			}
			else 
			{ 
				FormProdutoCadastrar form = new FormProdutoCadastrar();
				form.Show();
			}
		}

		private void ItemProdutoListar_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<FormProdutoListar>().Count() > 0)
			{
				Application.OpenForms.OfType<FormProdutoListar>().First().Focus();
			}
			else
			{
				FormProdutoListar form = new FormProdutoListar();
				form.Show();
			}
		}

		private void ItemClienteCadastrar_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<FormClienteCadastrar>().Count() > 0)
			{
				Application.OpenForms.OfType<FormClienteCadastrar>().First().Focus();
			}
			else
			{
				FormClienteCadastrar form = new FormClienteCadastrar();
				form.Show();
			}
		}

		private void ItemClienteListar_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<FormClienteListar>().Count() > 0)
			{
				Application.OpenForms.OfType<FormClienteListar>().First().Focus();
			}
			else
			{
				FormClienteListar form = new FormClienteListar();
				form.Show();
			}
		}

		private void ItemSair_Click(object sender, EventArgs e)
		{
			string msg = "Deseja realmente sair?";
			string titulo = "Saindo da aplicação";
			MessageBoxButtons btns = MessageBoxButtons.YesNo;

			DialogResult dialogo = MessageBox.Show(msg, titulo, btns);

			if (dialogo == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

        private void opcaoComponetes_Click(object sender, EventArgs e)
        {
			if (Application.OpenForms.OfType<FrmComponetes>().Count() > 0)
			{
				Application.OpenForms.OfType<FrmComponetes>().First().Focus();
			}
			else
			{
				FrmComponetes form = new FrmComponetes();
				form.Show();
			}
		}

        private void opcaoCalculosBasicos_Click(object sender, EventArgs e)
        {
			if (Application.OpenForms.OfType<FrmCalculaosBasicos>().Count() > 0)
			{
				Application.OpenForms.OfType<FrmCalculaosBasicos>().First().Focus();
			}
			else
			{
				FrmCalculaosBasicos form = new FrmCalculaosBasicos();
				form.Show();
			}
		}

        private void opcaoComboBox_Click(object sender, EventArgs e)
        {
			if (Application.OpenForms.OfType<FrmComboBox>().Count() > 0)
			{
				Application.OpenForms.OfType<FrmComboBox>().First().Focus();
			}
			else
			{
				FrmComboBox form = new FrmComboBox();
				form.Show();
			}
		}

        private void CcomboBox_Click(object sender, EventArgs e)
        {
			if (Application.OpenForms.OfType<FrmComboComCalculo>().Count() > 0)
			{
				Application.OpenForms.OfType<FrmComboComCalculo>().First().Focus();
			}
			else
			{
				FrmComboComCalculo form = new FrmComboComCalculo();
				form.Show();
			}
		}

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (Application.OpenForms.OfType<FrmCadSetor>().Count() > 0)
			{
				Application.OpenForms.OfType<FrmCadSetor>().First().Focus();
			}
			else
			{
				FrmCadSetor form = new FrmCadSetor();
				form.Show();
			}
		}

        private void cConexãoEInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (Application.OpenForms.OfType<FrmCadastrarCliente>().Count() > 0)
			{
				Application.OpenForms.OfType<FrmCadastrarCliente>().First().Focus();
			}
			else
			{
				FrmCadastrarCliente form = new FrmCadastrarCliente();
				form.Show();
			}
		}

        private void cConexãoEInsertFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (Application.OpenForms.OfType<FrmCadastrarForncecedor>().Count() > 0)
			{
				Application.OpenForms.OfType<FrmCadastrarForncecedor>().First().Focus();
			}
			else
			{
				FrmCadastrarForncecedor form = new FrmCadastrarForncecedor();
				form.Show();
			}
		}

        private void cConexãoEInsertFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (Application.OpenForms.OfType<FrmCadastrarFuncionario>().Count() > 0)
			{
				Application.OpenForms.OfType<FrmCadastrarFuncionario>().First().Focus();
			}
			else
			{
				FrmCadastrarFuncionario form = new FrmCadastrarFuncionario();
				form.Show();
			}
		}

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (Application.OpenForms.OfType<FrmCadastrarAluno>().Count() > 0)
			{
				Application.OpenForms.OfType<FrmCadastrarAluno>().First().Focus();
			}
			else
			{
				FrmCadastrarAluno form = new FrmCadastrarAluno();
				form.Show();
			}
		}
    }
}
