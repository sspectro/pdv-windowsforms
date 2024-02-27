namespace pdv_windowsforms
{
    partial class Principal
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
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.img01Carrinho = new System.Windows.Forms.PictureBox();
            this.MenuCadFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovLancarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovEntradasSaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasSaídasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01Carrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuProdutos,
            this.MenuMovimentacoes,
            this.MenuRelatorios,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadFuncionario,
            this.MenuCadClientes,
            this.MenuCadUsuarios,
            this.MenuCadFornecedor});
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(71, 20);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdProdutos,
            this.MenuProdEstoque});
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(67, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMovFluxoDeCaixa,
            this.MenuMovLancarVenda,
            this.MenuMovEntradasSaidas,
            this.MenuMovDespesas});
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(104, 20);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.entradasSaídasToolStripMenuItem1,
            this.despesasToolStripMenuItem1});
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::pdv_windowsforms.Properties.Resources.Despesas;
            this.pictureBox5.Location = new System.Drawing.Point(437, 45);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(219, 147);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::pdv_windowsforms.Properties.Resources.green_2084561_1280;
            this.pictureBox4.Location = new System.Drawing.Point(108, 221);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(219, 147);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::pdv_windowsforms.Properties.Resources.cash_1501280;
            this.pictureBox3.Location = new System.Drawing.Point(437, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(219, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // img01Carrinho
            // 
            this.img01Carrinho.Image = global::pdv_windowsforms.Properties.Resources.empty_cart_10423297;
            this.img01Carrinho.Location = new System.Drawing.Point(108, 45);
            this.img01Carrinho.Name = "img01Carrinho";
            this.img01Carrinho.Size = new System.Drawing.Size(219, 147);
            this.img01Carrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img01Carrinho.TabIndex = 1;
            this.img01Carrinho.TabStop = false;
            // 
            // MenuCadFuncionario
            // 
            this.MenuCadFuncionario.Name = "MenuCadFuncionario";
            this.MenuCadFuncionario.Size = new System.Drawing.Size(180, 22);
            this.MenuCadFuncionario.Text = "Funcionários";
            // 
            // MenuCadClientes
            // 
            this.MenuCadClientes.Name = "MenuCadClientes";
            this.MenuCadClientes.Size = new System.Drawing.Size(180, 22);
            this.MenuCadClientes.Text = "Clientes";
            // 
            // MenuCadUsuarios
            // 
            this.MenuCadUsuarios.Name = "MenuCadUsuarios";
            this.MenuCadUsuarios.Size = new System.Drawing.Size(180, 22);
            this.MenuCadUsuarios.Text = "Usuários";
            // 
            // MenuCadFornecedor
            // 
            this.MenuCadFornecedor.Name = "MenuCadFornecedor";
            this.MenuCadFornecedor.Size = new System.Drawing.Size(180, 22);
            this.MenuCadFornecedor.Text = "Fornecedor";
            // 
            // MenuProdProdutos
            // 
            this.MenuProdProdutos.Name = "MenuProdProdutos";
            this.MenuProdProdutos.Size = new System.Drawing.Size(180, 22);
            this.MenuProdProdutos.Text = "Produtos";
            // 
            // MenuProdEstoque
            // 
            this.MenuProdEstoque.Name = "MenuProdEstoque";
            this.MenuProdEstoque.Size = new System.Drawing.Size(180, 22);
            this.MenuProdEstoque.Text = "Estoque";
            // 
            // MenuMovFluxoDeCaixa
            // 
            this.MenuMovFluxoDeCaixa.Name = "MenuMovFluxoDeCaixa";
            this.MenuMovFluxoDeCaixa.Size = new System.Drawing.Size(180, 22);
            this.MenuMovFluxoDeCaixa.Text = "Fluxo de caixa";
            // 
            // MenuMovLancarVenda
            // 
            this.MenuMovLancarVenda.Name = "MenuMovLancarVenda";
            this.MenuMovLancarVenda.Size = new System.Drawing.Size(180, 22);
            this.MenuMovLancarVenda.Text = "Lançar Venda";
            // 
            // MenuMovEntradasSaidas
            // 
            this.MenuMovEntradasSaidas.Name = "MenuMovEntradasSaidas";
            this.MenuMovEntradasSaidas.Size = new System.Drawing.Size(180, 22);
            this.MenuMovEntradasSaidas.Text = "Entradas / Saídas";
            // 
            // MenuMovDespesas
            // 
            this.MenuMovDespesas.Name = "MenuMovDespesas";
            this.MenuMovDespesas.Size = new System.Drawing.Size(180, 22);
            this.MenuMovDespesas.Text = "Despesas";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentos";
            // 
            // entradasSaídasToolStripMenuItem1
            // 
            this.entradasSaídasToolStripMenuItem1.Name = "entradasSaídasToolStripMenuItem1";
            this.entradasSaídasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.entradasSaídasToolStripMenuItem1.Text = "Entradas / Saídas";
            // 
            // despesasToolStripMenuItem1
            // 
            this.despesasToolStripMenuItem1.Name = "despesasToolStripMenuItem1";
            this.despesasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.despesasToolStripMenuItem1.Text = "Despesas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.img01Carrinho);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01Carrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01Carrinho;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem MenuCadFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuCadClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuCadUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuCadFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuProdProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuProdEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuMovFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuMovLancarVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuMovEntradasSaidas;
        private System.Windows.Forms.ToolStripMenuItem MenuMovDespesas;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasSaídasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem1;
    }
}

