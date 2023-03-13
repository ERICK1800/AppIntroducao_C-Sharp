
namespace AppIntroducao
{
	partial class FormPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemProdutoCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemProdutoListar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemProdutoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemClienteCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemClienteListar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemClienteSair = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcaoComponetes = new System.Windows.Forms.ToolStripMenuItem();
            this.opcaoCalculosBasicos = new System.Windows.Forms.ToolStripMenuItem();
            this.opcaoComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.CcomboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.cConexãoEInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cConexãoEInsertFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cConexãoEInsertFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProduto,
            this.menuCliente,
            this.categoriaToolStripMenuItem,
            this.setorToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.exemploToolStripMenuItem,
            this.ItemSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProduto
            // 
            this.menuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemProdutoCadastrar,
            this.ItemProdutoListar,
            this.ItemProdutoSair});
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(62, 20);
            this.menuProduto.Text = "Produto";
            // 
            // ItemProdutoCadastrar
            // 
            this.ItemProdutoCadastrar.Name = "ItemProdutoCadastrar";
            this.ItemProdutoCadastrar.Size = new System.Drawing.Size(124, 22);
            this.ItemProdutoCadastrar.Text = "Cadastrar";
            this.ItemProdutoCadastrar.Click += new System.EventHandler(this.ItemProdutoCadastrar_Click);
            // 
            // ItemProdutoListar
            // 
            this.ItemProdutoListar.Name = "ItemProdutoListar";
            this.ItemProdutoListar.Size = new System.Drawing.Size(124, 22);
            this.ItemProdutoListar.Text = "Listar";
            this.ItemProdutoListar.Click += new System.EventHandler(this.ItemProdutoListar_Click);
            // 
            // ItemProdutoSair
            // 
            this.ItemProdutoSair.Name = "ItemProdutoSair";
            this.ItemProdutoSair.Size = new System.Drawing.Size(124, 22);
            this.ItemProdutoSair.Text = "Sair";
            this.ItemProdutoSair.Click += new System.EventHandler(this.ItemProdutoSair_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemClienteCadastrar,
            this.ItemClienteListar,
            this.ItemClienteSair});
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(56, 20);
            this.menuCliente.Text = "Cliente";
            // 
            // ItemClienteCadastrar
            // 
            this.ItemClienteCadastrar.Name = "ItemClienteCadastrar";
            this.ItemClienteCadastrar.Size = new System.Drawing.Size(180, 22);
            this.ItemClienteCadastrar.Text = "Cadastrar";
            this.ItemClienteCadastrar.Click += new System.EventHandler(this.ItemClienteCadastrar_Click);
            // 
            // ItemClienteListar
            // 
            this.ItemClienteListar.Name = "ItemClienteListar";
            this.ItemClienteListar.Size = new System.Drawing.Size(180, 22);
            this.ItemClienteListar.Text = "Listar";
            this.ItemClienteListar.Click += new System.EventHandler(this.ItemClienteListar_Click);
            // 
            // ItemClienteSair
            // 
            this.ItemClienteSair.Name = "ItemClienteSair";
            this.ItemClienteSair.Size = new System.Drawing.Size(180, 22);
            this.ItemClienteSair.Text = "Sair";
            this.ItemClienteSair.Click += new System.EventHandler(this.ItemClienteSair_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // setorToolStripMenuItem
            // 
            this.setorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.setorToolStripMenuItem.Name = "setorToolStripMenuItem";
            this.setorToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.setorToolStripMenuItem.Text = "Setor";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // exemploToolStripMenuItem
            // 
            this.exemploToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcaoComponetes,
            this.opcaoCalculosBasicos,
            this.opcaoComboBox,
            this.CcomboBox,
            this.cConexãoEInsertToolStripMenuItem,
            this.cConexãoEInsertFornecedorToolStripMenuItem,
            this.cConexãoEInsertFuncionárioToolStripMenuItem});
            this.exemploToolStripMenuItem.Name = "exemploToolStripMenuItem";
            this.exemploToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.exemploToolStripMenuItem.Text = "\\";
            // 
            // opcaoComponetes
            // 
            this.opcaoComponetes.Name = "opcaoComponetes";
            this.opcaoComponetes.Size = new System.Drawing.Size(257, 22);
            this.opcaoComponetes.Text = "Componetes Basicos";
            this.opcaoComponetes.Click += new System.EventHandler(this.opcaoComponetes_Click);
            // 
            // opcaoCalculosBasicos
            // 
            this.opcaoCalculosBasicos.Name = "opcaoCalculosBasicos";
            this.opcaoCalculosBasicos.Size = new System.Drawing.Size(257, 22);
            this.opcaoCalculosBasicos.Text = "C# - cálculos básicos";
            this.opcaoCalculosBasicos.Click += new System.EventHandler(this.opcaoCalculosBasicos_Click);
            // 
            // opcaoComboBox
            // 
            this.opcaoComboBox.Name = "opcaoComboBox";
            this.opcaoComboBox.Size = new System.Drawing.Size(257, 22);
            this.opcaoComboBox.Text = "ComboBox";
            this.opcaoComboBox.Click += new System.EventHandler(this.opcaoComboBox_Click);
            // 
            // CcomboBox
            // 
            this.CcomboBox.Name = "CcomboBox";
            this.CcomboBox.Size = new System.Drawing.Size(257, 22);
            this.CcomboBox.Text = "C# - comboBox";
            this.CcomboBox.Click += new System.EventHandler(this.CcomboBox_Click);
            // 
            // cConexãoEInsertToolStripMenuItem
            // 
            this.cConexãoEInsertToolStripMenuItem.Name = "cConexãoEInsertToolStripMenuItem";
            this.cConexãoEInsertToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.cConexãoEInsertToolStripMenuItem.Text = "C# - conexão e insert - Cliente";
            this.cConexãoEInsertToolStripMenuItem.Click += new System.EventHandler(this.cConexãoEInsertToolStripMenuItem_Click);
            // 
            // cConexãoEInsertFornecedorToolStripMenuItem
            // 
            this.cConexãoEInsertFornecedorToolStripMenuItem.Name = "cConexãoEInsertFornecedorToolStripMenuItem";
            this.cConexãoEInsertFornecedorToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.cConexãoEInsertFornecedorToolStripMenuItem.Text = "C# - conexão e insert - Fornecedor";
            this.cConexãoEInsertFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cConexãoEInsertFornecedorToolStripMenuItem_Click);
            // 
            // cConexãoEInsertFuncionárioToolStripMenuItem
            // 
            this.cConexãoEInsertFuncionárioToolStripMenuItem.Name = "cConexãoEInsertFuncionárioToolStripMenuItem";
            this.cConexãoEInsertFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.cConexãoEInsertFuncionárioToolStripMenuItem.Text = "C# - select listar simples";
            this.cConexãoEInsertFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cConexãoEInsertFuncionárioToolStripMenuItem_Click);
            // 
            // ItemSair
            // 
            this.ItemSair.Name = "ItemSair";
            this.ItemSair.Size = new System.Drawing.Size(38, 20);
            this.ItemSair.Text = "Sair";
            this.ItemSair.Click += new System.EventHandler(this.ItemSair_Click);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuProduto;
		private System.Windows.Forms.ToolStripMenuItem ItemProdutoCadastrar;
		private System.Windows.Forms.ToolStripMenuItem ItemProdutoListar;
		private System.Windows.Forms.ToolStripMenuItem ItemProdutoSair;
		private System.Windows.Forms.ToolStripMenuItem menuCliente;
		private System.Windows.Forms.ToolStripMenuItem ItemClienteCadastrar;
		private System.Windows.Forms.ToolStripMenuItem ItemClienteListar;
		private System.Windows.Forms.ToolStripMenuItem ItemClienteSair;
		private System.Windows.Forms.ToolStripMenuItem ItemSair;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcaoComponetes;
        private System.Windows.Forms.ToolStripMenuItem opcaoCalculosBasicos;
        private System.Windows.Forms.ToolStripMenuItem opcaoComboBox;
        private System.Windows.Forms.ToolStripMenuItem CcomboBox;
        private System.Windows.Forms.ToolStripMenuItem setorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cConexãoEInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cConexãoEInsertFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cConexãoEInsertFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
    }
}

