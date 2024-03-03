# PDV Completo em C#

>Projeto de PDV completo em C# com MySql.
> Nem todas as configura��es est�o iguais as do v�deo.
>>Projeto desenvolvido no curso - Youtube [PDV Completo em C#](https://www.youtube.com/@PortalZatecSistemas)

## Ambiente de Desenvolvimento
    C#, Windows, Microsoft Visual Studio, xampp, MySql

## Documenta��o
- [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- [Adicionar chave ssh github](https://docs.github.com/pt/authentication/connecting-to-github-with-ssh/checking-for-existing-ssh-keys)
- [freepik - Icons gr�tis](https://br.freepik.com/icone)
- [pixabay.com - Imagens e icons](https://pixabay.com/pt/vectors/)
- [icoconverter.com - converter para icons](https://www.icoconverter.com/)
- [canva.com cria��o de artes](https://www.canva.com/)
- [xampp](https://www.apachefriends.org/pt_br/download.html)
- [Nuget package MySql.Data](https://www.nuget.org/packages/MySql.Data/8.3.0?_src=template)



## Desenvolvimento
1. <span style="color:383E42"><b>Preparando ambiente</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>
    
    - Criar projeto - Aplicativo do Windows Forms(.NET Framework)
    - Editar/Criar README e colocar estrutura b�sica
    - Criar diret�rio readmeImages e colocar imagens para uso no README.md
    - Editar/Criar `gitignore` e colocar configura��o para `csharp,dotnetcore,windows,visualstudio`
        >Use o site [gitignore.io](https://www.toptal.com/developers/gitignore/)

    </p>

    </details> 

    ---


2. <span style="color:383E42"><b>Cria��o e Configura��o Form Principal</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>


    - Adicionar item - MenuStrip - ao form
    - Adicionar Itens no menu - Cadastros, Produtos, Movimenta��es, Relat�rios e Sair
        ````
        Alterar propriedade `Names` dos menus: MenuCadastros, MenuProdutos, MenuMovimentacoes, MenuRelatorios, MenuSair
        `````
    - Adicionar 4 PictureBox
        ```
        Incluir imagem na propriedade image do item img01 - Utilizar op��o de import - Arquivo de recursos de projeto
        Inclus�o das imagens form Principal - picturebox 2, 3, 4
        ```
    - Configurando Menu e Propriedade `name`
    
        Cadastros( name "MenuCadastros"): 
        ````
        Funcion�rios(name "MenuCadFuncionarios"), Clientes(name "MenuCadClientes"), Usu�rios(name "MenuCadUsuarios"), Fornecedor(name "MenuCadFornecedor")
        ````
        Produtos(name "MenuProdutos"): 
        ````
        Produtos(name "MenuProdProdutos"), Estoque(name "MenuProdEstoque")
        ````
        Movimenta��es(name "MenuMovimentacoes"): 
        ````
        Fluxo de caixa(name "MenuMovFluxoDeCaixa"), Lan�ar venda(name "MenuMovLancarVenda"), Entradas / Sa�das(name "MenuMovEntradasSaidas"), Despesas(name "MenuMovDespesas")
        ````
        Relat�rios(name "MenuRelatorios"): 
        ````
        Produtos(name "MenuRelProdutos"), Vendas(name "MenuRelVendas"), Movimentos(name "MenuRelMovimentos"), Entradas / Sa�das(name "MenuRelEntradasSa�das"), Despesas(name "MenuRelDespesas")
        ````
        Sair(name "MenuSairPrincipal")

    - Cria��o evento Click Menu Sair(MenuSairPrincipal):
        ````cs
        private void MenuSairPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ````


    </p>

    </details> 

    ---


3. <span style="color:383E42"><b>Cria��o Pasta cadastro e Form Cadastro(frmCadastro)</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Adicionar uma nova pasta "cadastro" ao projeto - Adicionar novo form frmCadastro na pasta criada

    - Criar evento Click do Submenu Funcion�rios(MenuCadFuncionario - do Menu Cadastros)
        ````cs
        private void MenuCadFuncionario_Click(object sender, EventArgs e)
        {
            cadastro.frmCadastro frm=new cadastro.frmCadastro();

            frm.ShowDialog();
        }
        ````
    - Renomea��o dos nomes dos forms, propriedade `Name`
        ````
        Novo nome FrmPrincipal e FrmCadastro
        ````

    - Altera��o �cone do form principal e cadastro
        ```
        Selecionar �cone na propriedade `Icon` do formul�rio
        ```
    - Inclus�o dos labels no FrmCadastro:
        ````
        Nome, Telefone, Endere�o, CPF, Cargo e Foto
        ````
    - Inclus�o dos TextBox do FrmCadastro:
        ````
        Nome, Telefone, Endere�o, CPF
        txtNome, txtTelefone, txtcEndereco, txtCPF
        ````
    - Inclus�o ComboBox do FrmCadastro:
        ````
        Cargo
        cmboxCadFuncCargo
        ````
    - Inclus�o PictureBox do FrmCadastro:
        ````
        Foto
        pictboxFoto
        ````
    - Inclus�o DataGridView do FrmCadastro: 
      Desabilitar inclus�o pelo componente
        ````
        dtgridListFuncionarios
        ````
    - Adicionar bot�es: 
        ````
        Novo(btnNovo), Salvar(btnSalvar), Editar(btnEditar), Excluir(btnExcluir)
        ````

    </p>

    </details> 

    ---


4. <span style="color:383E42"><b>Instalar o Xampp, Criar Database e Tabelas </b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - [Coorrigir problema alerta ao instalar](https://www.youtube.com/watch?v=JDn4vzT9C38)
    - Criar database `pdv`
    - Criar tabela `funcionarios`:
        ````
        id - int - AI(auto Incremente)
        nome - varchar - 80
        cpf - varchar - 20
        telefone - varchar - 20
        cargo - varchar - 30
        endereco -  varchar - 300
        foto - longblob
        ````
    - Instalar via Nuget package `Mysql.Data` 

    </p>

    </details> 

    ---


5. <span style="color:383E42"><b>Crir Classe de Conex�o</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    Criar classe `Conexao.cs`
    ````cs
    using MySql.Data.MySqlClient;
    using System;
    using System.Windows.Forms;

    namespace pdv_windowsforms
    {
        internal class Conexao
        {
            //Para uso em servidor local
            public string conec = "server=localhost;uid=root;pwd=;database=pdv;port=;";


            public MySqlConnection con = null;

            public void abrirConexao()
            {
                try
                {
                    con = new MySqlConnection(conec);
                    con.Open();
                }catch (Exception ex)
                {
                    //Ao inves do throw ex; usar o messageBox, assim o sistema pode ser usado mesmo dando erro ao abrir o BD
                    MessageBox.Show("Erro de conexao com o Banco de Dados"+ex.Message);
                }
            }

            public void fecharConexao()
            {
                try
                {
                    con = new MySqlConnection(conec);
                    con.Close();
                    con.Dispose();//derruba algumas conexoes abertas
                    con.ClearAllPoolsAsync();//Metodo de limpeza
                }catch(Exception ex)
                {
                    //Ao inves do throw ex; usar o messageBox, assim o sistema pode ser usado mesmo dando erro ao abrir o BD
                    MessageBox.Show("Erro de conexao com o Banco de Dados" + ex.Message);
                }
            }
        }
    }

    ````

    </p>

    </details> 

    ---

6. <span style="color:383E42"><b>----------</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>



    </p>

    </details> 

    ---



## Meta
><span style="color:383E42"><b>Cristiano Mendon�a Gueivara</b> </span>
>
>>[<img src="readmeImages/githubIcon.png">](https://github.com/sspectro "Meu perfil no github")
>
>><a href="https://linkedin.com/in/cristiano-m-gueivara/"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white"></a> 
>
>>[<img src="https://sspectro.github.io/images/cristiano.jpg" height="25" width="25"> - Minha P�gina Github](https://sspectro.github.io/#home "Minha P�gina no github")<br>



><span style="color:383E42"><b>Licen�a:</b> </span> Distribu�do sobre a licen�a `Software Livre`. Veja Licen�a **[MIT](https://opensource.org/license/mit/)**.