# PDV Completo em C#

>Projeto de PDV completo em C# com MySql.
> Nem todas as configura��es est�o iguais as dos v�deos. 
> Nos v�deos � criado um outro projeto(Moderno) para cria��o do design.
> Em seguida � transferido os arquivos do pdv para o novo projeto. Por�m n�o fa�o isso.
> `A parte de design eu crio direto neste projeto.`
>>Projeto desenvolvido Canal - Youtube [PDV Completo em C#](https://www.youtube.com/@PortalZatecSistemas)

## Ambiente de Desenvolvimento e Tecnologias
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
- [Erro MySql incluir imagem] `MySql.Data.MySqlClient.MySqlException: 'Packets larger than max_allowed_packet are not allowed.`



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
        data - date
        endereco -  varchar - 300
        foto - longblob
        ````
    - Instalar via Nuget package `Mysql.Data` 

    </p>

    </details> 

    ---


5. <span style="color:383E42"><b>Criar Classe de Conex�o</b></span>
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

6. <span style="color:383E42"><b>Criar C�digo B�sico Op��o de Salvar FrmFuncionario</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Criar bot�o Foto
        ````
        btnOpenDialog
        ````
    - Excluir label do campo foto FrmFuncionario
    - Criar evento click do btnSalvar FrmFuncionar
    - Criar evento click do btnOpenDialog FrmFuncionario
    - Criar fun��o img() FrmFuncionario
    - Criar fun��o limparFoto()
    - C�digo resultante:
        ````cs
        using MySql.Data.MySqlClient;
        using System;
        using System.IO;
        using System.Windows.Forms;

        namespace pdv_windowsforms.cadastro
        {
            public partial class FrmFuncionario : Form
            {
                Conexao con = new Conexao();
                String sql;
                MySqlCommand cmd;

                String foto;

                public FrmFuncionario()
                {
                    InitializeComponent();
                }

                private void btnSalvar_Click(object sender, EventArgs e)
                {

                    con.abrirConexao();
                    sql = "insert into funcionarios(nome, cpf, endereco, telefone, cargo, data, foto) values(@nome, @cpf, @endereco, @telefone, @cargo, curDate(), @foto)";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                    cmd.Parameters.AddWithValue("@foto", img());//img() m�todo criado para tratar imagem para o database


                    cmd.ExecuteNonQuery();
                    con.fecharConexao();
                }

                private void FrmCadastro_Load(object sender, EventArgs e)
                {


                }

                private void btnOpenDialog_Click(object sender, EventArgs e)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    //dialog.Filter = "Arquivos(*.jpg)|*.jpg | Arquivos(*.png)| *.png;| All (*.*) | *.*"; //Mostra um de cada vez
                    dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png"; //Mostra jpg e png
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        foto = dialog.FileName.ToString();//pegando caminho da imagem
                        pictboxFoto.ImageLocation = foto; //Jogando caminho da imgem para comonente img para exibir no form
                        //alterouImagem = "sim"; //para uso editar alterando imagem
                    }
                }

                private byte[] img()//Este metodo � padr�o, serve sempre que desejar enviar imagem para o banco de dados
                {
                    byte[] imagem_byte = null;
                    if(foto == "") //a string foto, nuca vai estar vazia, porque no metodo LimparFoto() foi passado o caminho de uma imagem
                    {
                        return null;
                    }

                    //usar o FileStream para enviar imagem para o BD e tres par�metros local(foto), tipo de imagem(FileMode), tipo de acesso(FileAcess)
                    FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);//padr�o
                    BinaryReader br = new BinaryReader(fs);//serve para trabalhar com FileStream

                    imagem_byte = br.ReadBytes((int)fs.Length);

                    return imagem_byte;

                }
                private void limparFoto()
                {
                    pictboxFoto.Image = Properties.Resources.perfil; //Aqui coloca a imagem sem foto na picutre do form
                    foto = "img/sem_foto.jpg"; //atribuido um caminho de foto (assim esta imagem tem que estar na pasta debug
                }
            }
        }

        ````



    </p>

    </details> 

    ---


7. <span style="color:383E42"><b>Valida��o para `Nome` e `CPF` FrmFuncionario - Inclus�o M�scara </b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Valida��o `txtNome`
        ````cs
        //Tratar dados
        if(txtNome.Text.ToString().Trim() == "")
        {
            MessageBox.Show("Preencha o campo nome", "Cadastro funcion�rios", MessageBox.ok, MessageBoxIcon.Warning);
            txtNome.Text = "";
            txtNome.Focus();
            return;
        }
        ````
    - Valida��o `txtCpf`
    Exclus�o do `txtCPF` do FrmFuncionario e inclus�o do MaskedTextBox `txtCpf`
        ````cs
        if(txtCpf.Text == "   ,   ,   -" || txtCpf.Text.Length < 14)
        {
            MessageBox.Show("Preencha o campo CPF", "Cadastro funcion�rios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCpf.Text = "";
            txtCpf.Focus();
            return;
        }
        ````
    - Exclus�o `txtTelefone` e inclus�o de campo MaskedTextBox `txtTelefone`
    
    - Incluir pasta `img` na pasta debug do projeto
        A imagem que � inclu�da via fun��o `limpaFoto()` deve ficar na pasta `debug`
        ````
        pdv-windowsforms\bin\Debug
        ````
    - Incluir chamada da fun��o `limpaFoto` no evento load do `FrmCadastro`
        Fun��o inclui foto padr�o para o campo foto.
        Obs.: Incluir imagem uma vez via propriedade Image do campo para, constar nos resources. Evitando erros.
        ````cs
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            limparFoto();

        }
        ````


    </p>

    </details> 

    ---

8. <span style="color:383E42"><b>Criar Fun��es para Limpar, Habilitar/Desabilitar Campos FrmCadastro</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Alterar nome `btnOpenDialog`para `btnFoto`
    - Criar fun��o `habilitarCampos`
        ````cs
        private void habilitarCampos()
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            btnCancelar.Enabled = true;
            btnFoto.Enabled = true;
            btnNovo.Enabled = false;
        }
        ````
    - Criar fun��o `limparCampos`
        ````cs
        private void limparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            
        }
        ````
    - Criar fun��o `desabilitarCampos`
        ````cs
        private void desabilitarCampos()
        {
            txtNome.Enabled=false;
            txtCpf.Enabled=false;
            txtEndereco.Enabled=false;
            txtTelefone.Enabled=false;
            cbCargo.Enabled=false;
        }
        ````
    - Criar envento `btnNovo_Click` bot�o `Novo` form FrmCadastro
        ````cs
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }
        ````
    - Incluir em evento click do bot�o `Salvar` FrmCadastro:
        ````cs
        limparFoto();

        MessageBox.Show("Registro Salvao com Sucesso!","Cadastro funcion�rio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        btnNovo.Enabled = true;
        btnSalvar.Enabled = false;
        btnEditar.Enabled = false;
        btnExcluir.Enabled = false;

        limparCampos();
        desabilitarCampos();
        ````



    </p>

    </details> 

    ---


9. <span style="color:383E42"><b>Criar Fun��o `listar()` formatarGD()</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Criar fun��o `listar()` para trazer os dados para o `datagrid` FrmFuncionario
        ````cs
        private void listar()
        {
            con.abrirConexao();
            sql = "select * from funcionarios order by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dtgridListFuncionarios.DataSource = dataTable;
            con.fecharConexao();
        }
        ````

    - Incluir chamada m�todo `listar()` no evento load do FrmCadastro e evento click de btnSalvar
        FrmCadastro_Load
        ````cs
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            limparFoto();
            listar();

        }
        ````
        btnSalvar_Click
        ````cs
        //...
        limparFoto();
        listar();
        //...
        ````
    - Criar m�todo para formatar grid `dtgridListFuncionarios` e incluir chamad no m�todo `listar()`
        ````cs
        private void formatarGD()
        {
            dtgridListFuncionarios.Columns[0].HeaderText = "ID";
            dtgridListFuncionarios.Columns[1].HeaderText = "Nome";
            dtgridListFuncionarios.Columns[2].HeaderText = "CPF";
            dtgridListFuncionarios.Columns[3].HeaderText = "Telefone";
            dtgridListFuncionarios.Columns[4].HeaderText = "Cargo";
            dtgridListFuncionarios.Columns[5].HeaderText = "Data";
            dtgridListFuncionarios.Columns[6].HeaderText = "Endere�o";
            dtgridListFuncionarios.Columns[7].HeaderText = "Imagem";

            dtgridListFuncionarios.Columns[0].Width = 50;
            dtgridListFuncionarios.Columns[6].Width = 50;
            dtgridListFuncionarios.Columns[0].Visible = false;
            dtgridListFuncionarios.Columns[7].Visible = false;
        }
        ````


    </p>

    </details> 

    ---


10. <span style="color:383E42"><b>Capturar Validar Dados e Exibir Imagem do dataGrid `dtgridListFuncionarios`</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Criar evento para duplo click na celula grid `dtgridListFuncionarios`
        Trata imagem
        ````cs
        private void dtgridListFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                habilitarCampos();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;

                txtNome.Text = dtgridListFuncionarios.CurrentRow.Cells[1].Value.ToString();
                txtCpf.Text = dtgridListFuncionarios.CurrentRow.Cells[2].Value.ToString();
                txtTelefone.Text = dtgridListFuncionarios.CurrentRow.Cells[3].Value.ToString();
                cbCargo.Text = dtgridListFuncionarios.CurrentRow.Cells[4].Value.ToString();
                txtEndereco.Text = dtgridListFuncionarios.CurrentRow.Cells[6].Value.ToString();

                if (dtgridListFuncionarios.CurrentRow.Cells[7].Value != DBNull.Value)
                {
                    //Criada var byte[] imagem para receber convertido em byte o que vem da grid
                    byte[] imagem = (byte[])dtgridListFuncionarios.Rows[e.RowIndex].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imagem);

                    // O componente Image sempre pede um System.Drawing ent�o...
                    // Passando o memorystream no objeto que ele recebe um System.Drawing e seu parametro FromStream
                    pictboxFoto.Image = System.Drawing.Image.FromStream(ms);
                }
                else
                {
                    pictboxFoto.Image = Properties.Resources.sem_foto2; //Aqui coloca a imagem sem foto na picture do form
                }

            }else
            {
                return;
            }
        ````
    - Colocar foco campo nome evento click `btnNovo` FrmFuncionario
        ````cs
        txtNome.Focus();
        ````
    - Configurar ordem dos campos para sele��o/edi��o propridade `TabIndex`
    - Cria��o evento click bot�o cancelar btnCancelar
        ````cs
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;

            desabilitarCampos();
            limparCampos();

        }
        ````
    - Incluir chamada m�todo limparCampos() ao evento click do bot�o Novo
        ````cs
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos() ;
            txtNome.Focus();
        }
        ````
 

    </p>

    </details> 

    ---


11. <span style="color:383E42"><b>Cria��o evento click Bot�o Editar e Excluir FrmFuncionario</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Erro MySql incluir imagem `MySql.Data.MySqlClient.MySqlException: 'Packets larger than max_allowed_packet are not allowed.`
        Solu��o [Altere o arquivo my.ini - max_allowed_packet=500M](https://stackoverflow.com/questions/8062496/how-to-change-max-allowed-packet-size)
    
    - Cria��o vari�veis `id` e `cpfAntigo`
        ````cs
        String id = "";
        String cpfAntigo = "";
        ````
    - Criar evento click do bot�o `Editar`
        ````cs
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome.", "Cadastro funcion�rios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if(txtCpf.Text == "   ,   ,   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF.", "Cadastro funcion�rios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            //Bot�o Editar
            if(alterouImagem == "sim")
            {
                con.abrirConexao();
                sql = "update funcionarios set nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco, foto = @foto where id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@foto", img());//img() m�todo criado para tratar imagem para o database
            }else if(alterouImagem == "n�o")
            {
                con.abrirConexao();
                sql = "update funcionarios set nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco where id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);

            }

            //Verifica se CPF j� existe
            if(txtCpf.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("Select * from funcionarios where cpf = @cpf", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cpf",txtCpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF j� registrado", "Cadastro de Funcion�rios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCpf.Text = "";
                    txtCpf.Focus();
                    return;
                }

            }

            cmd.ExecuteNonQuery();
            con.fecharConexao();
            listar();

            MessageBox.Show("Registro Editado com sucesso!", "Cadastro de Funcion�rios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            desabilitarCampos();
            limparCampos();
            limparFoto();
            alterouImagem = "n�o";

        }
        ````
    - Cria��o do evento click do bot�o `Excluir`
        ````cs
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente Excluir!", "Exclus�o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {

                con.abrirConexao();
                sql = "delete from funcionarios where id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.fecharConexao();
                listar();
                MessageBox.Show("Registro Exlu�do com sucesso!", "Cadastro de Funcion�rios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled=true;
                btnEditar.Enabled=false;
                btnExcluir.Enabled=false;
                btnSalvar.Enabled=false;
                desabilitarCampos();
                limparCampos();
                limparFoto();

            }
        }
        ````

    </p>

    </details> 

    ---


12. <span style="color:383E42"><b>ComboBox `cbCargo`: Cria��o Tabela `cargos`, Fun��o `listarCargos`</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Cria��o Tabela `cargos` e inclus�o de dados
        - id - int - autoincrement
        - cargo- varchar
        ````sql
        INSERT INTO `cargos` (`id`, `nome`) VALUES (NULL, 'Motorista');
        ````

    - Criar Fun��o `listarCargos`
        ````cs
        private void listarCargos()
        {
            con.abrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbCargo.DataSource = dt;
            //cbCargo.ValueMember = "id";
            //Carrega pelo nome 
            cbCargo.DisplayMember = "cargo";
            con.fecharConexao();

        }
        ````


    </p>

    </details> 

    ---

13. <span style="color:383E42"><b>Criar Form Cargo, Formatar Grid e Criar C�digo do Bot�o Salvar</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Configurar texto inicial no cbCargo no evento Load FrmFuncionario
        ````cs
        cbCargo.Text = "Selecione o Cargo";
        ````
    - Configurar propriedade SelectionMode do datagrid como `FullRowSelect`
        Com isso ser� selecionada toda linha ao clicar em uma c�lula na tabela

    - Criar novo formul�rio FrmCargo - Copiar campos e bot�es do `FrmFuncionario` e deixar somente os campos abaixo
        Campos:
        - Label Cargo: lblCargo
        - TextBox: txtCargo
        - DataGrid: dtgridListCargos
        Bot�es:
        - Novo: btnNovo
        - Salvar: btnSalvar
        - Cancelar: btnCancelar
        - Editar: btnEditar
        - Excluir: btnExcluir

    
    - Incluir vari�veis no FrmCargo
        ````cs
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        string id = "";

        ````

    - Incluir fun��o formatarGD()
        ````cs
        private void formatarGD()
        {
            dtgridListCargos.Columns[0].HeaderText = "ID";
            dtgridListCargos.Columns[1].HeaderText = "Cargo";

            dtgridListCargos.Columns[0].Width = 50;
            dtgridListCargos.Columns[1].Width = 50;
            dtgridListCargos.Columns[0].Visible = false;
        }
        ````
    - Criar evento click bot�o salvar FrmCargo
        ````cs
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Tratar dados
            if (txtCargo.Text.ToString().Trim() == "" || txtCargo.Text.Length < 2)
            {
                MessageBox.Show("Preencha o campo Cargo com pelo menos 2 letras", "Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }

            con.abrirConexao();
            sql = "insert into cargos(cargo) values(@cargo)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);


            cmd.ExecuteNonQuery();
            con.fecharConexao();



            listar();

            MessageBox.Show("Registro Salvao com Sucesso!", "Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }
        ````
    - Criar fun��o listar() e incluir chamada no evento Load do FrmCargo
        ````cs
        private void listar()
        {
            con.abrirConexao();
            sql = "select * from cargos order by cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dtgridListCargos.DataSource = dataTable;
            con.fecharConexao();

            formatarGD();
        }
        ````
    - Incluir Cadastro cargos no menu Form principal e criar evento click
        ````cs
        private void MenuCadCargos_Click(object sender, EventArgs e)
        {
            cadastro.FrmCargo frmCargo = new cadastro.FrmCargo();
            frmCargo.ShowDialog();
        }
        ````
    - Incluir fun��o formatarGD()
        ````cs
        private void formatarGD()
        {
            dtgridListCargos.Columns[0].HeaderText = "ID";
            dtgridListCargos.Columns[1].HeaderText = "Cargo";

            dtgridListCargos.Columns[0].Width = 50;
            dtgridListCargos.Columns[1].Width = 50;
            dtgridListCargos.Columns[0].Visible = false;
        }
        ````


    </p>

    </details> 

    ---


14. <span style="color:383E42"><b>Incluir as Fun��es/Eventos dos Bot�es do FrmCargo</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>
 
    - Criar c�digo do evento click do btnCancelar 
        ````cs
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }
        ````
    - C�digo evento click `btnEditar`
        ````cs
                private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Cargo.", "Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }

            con.abrirConexao();

            //Verifica se Cargo j� existe
            if (txtCargo.Text != cargoAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("Select * from cargos where cargo = @cargo", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cargo", txtCargo.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cargo j� registrado", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCargo.Text = "";
                    txtCargo.Focus();
                    return;
                }

            }

            //Bot�o Editar
            sql = "update cargos set cargo = @cargo where id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);

            cmd.ExecuteNonQuery();
            con.fecharConexao();
            listar();

            MessageBox.Show("Registro Editado com sucesso!", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            txtCargo.Text = "";
        }
        ````
    - C�digo evento duplo click `dtgridListCargos`
        ````cs
                private void dtgridListCargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;

                id = dtgridListCargos.CurrentRow.Cells[0].Value.ToString();
                txtCargo.Text = dtgridListCargos.CurrentRow.Cells[1].Value.ToString();
            }
        }
        ````
    - C�digo evento click `btnExcluir`
        ````cs
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente Excluir o cargo!", "Exclus�o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {

                con.abrirConexao();
                sql = "delete from cargos where id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.fecharConexao();
                listar();
                MessageBox.Show("Cargo Exlu�do com sucesso!", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                txtCargo.Text = "";

            }
        }
        ````
    - Cria��o campo data tabela `cargos`
        `Tipo Date - N�o nulo`
    - Inclus�o do campo `data` no evento click `btnSalvar`
        ````cs
        //...
        sql = "insert into cargos(cargo, data) values(@cargo, curDate())";
        //...
        ````
    - Incluir configura��o inicial bot�es e campo texto evento Load FrmCadastro
        ````cs
        //...
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            txtCargo.Enabled = false;
        //...
        ````
    - Habilitar btnSalvar click do bot�o `Novo`
        ````cs
        //...
        btnSalvar.Enabled = true;
        //...
        ````

    - Edi��o das mensagens de alerta ao editar e excluir cargo

    - Inclus�o do cargo clicado na grid a vari�vel `cargoAntigo`
        ````cs
        //...
        cargoAntigo = dtgridListCargos.CurrentRow.Cells[1].Value.ToString();//N�o necess�rio, pois este valor j� est� no txtCargo.Text
        /...
        ````



    </p>

    </details> 

    ---


15. <span style="color:383E42"><b>Criando Form Cliente - Importando Database de Script SQL</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>
    
    - Importando datase do script:
        Excluir tabelas do banco de dados `pdv` ou excluir o banco e recriar
        Estando no banco de dados via phpMyAdmin menu Importar
        Escolher arquivo baixado do curso
        Op��es:
        - Conjunto de caracteres do arquivo: utf-8
        - Formato: SQL
        - Modo de compatibilidade SQL: NONE

    - Criar formul�rio Clientes (FrmCliente):
        > `StartPosition - CenterScreen`
        >><img src="readmeImages/projectImages/FrmCliente.png">
    

    - Criar vari�veis do form
    - Criar o fun��o `formatarGD`
        Formata a datagridList
        ````cs
        private void formatarGD()
        {
            dtgridListClientes.Columns[0].HeaderText = "ID";
            dtgridListClientes.Columns[1].HeaderText = "C�digo";
            dtgridListClientes.Columns[2].HeaderText = "Nome";
            dtgridListClientes.Columns[3].HeaderText = "CPF";
            dtgridListClientes.Columns[4].HeaderText = "Em Aberto";
            dtgridListClientes.Columns[5].HeaderText = "Telefone";
            dtgridListClientes.Columns[6].HeaderText = "Email";
            dtgridListClientes.Columns[7].HeaderText = "Desbloqueado";
            dtgridListClientes.Columns[8].HeaderText = "Status";
            dtgridListClientes.Columns[9].HeaderText = "Endere�o";
            dtgridListClientes.Columns[10].HeaderText = "Funcion�rio";
            dtgridListClientes.Columns[11].HeaderText = "igm";
            dtgridListClientes.Columns[12].HeaderText = "Data";
            //dtgridListClientes.Columns[0].Width = 50;
            dtgridListClientes.Columns[0].Visible = false;
            dtgridListClientes.Columns[11].Visible = false;
            dtgridListClientes.Columns[4].DefaultCellStyle.Format = "c2";


        }
        ````
    - Criar fun��o `listar`
        Preenche o datagridList com dados da tabela de clientes
        ````cs
        private void listar()
        {
            con.abrirConexao();
            sql = "select * from clientes order by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgridListClientes.DataSource = dt;
            con.fecharConexao();

            formatarGD();
        }
        ````
    - Criar fun��o `habilitarCampos`
        ````cs
        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            cblInadimplente.Enabled = true;
            txtValorAberto.Enabled = true;
            txtNome.Focus();
        }
        ````
    - Criar fun��o `desabilitarCampos`
        ````cs
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            cblInadimplente.Enabled = false;
            txtValorAberto.Enabled = false;
        }
        ````
    - Criar fun��o `limparCampos`
        ````cs
        private void limparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            cblInadimplente.SelectedIndex = 0;
        }
        ````
    - Criar fun��o `buscarPNome`
    - Criar fun��o `buscarCpf`
    - Criar fun��o `ultimoIdCliente`
    - Criar fun��o `img`
        Este m�todo � padr�o, serve para enviar um imagem para o banco de dados.
    - Criar fun��o `limparFoto`
 
    </p>

    </details> 

    ---


16. <span style="color:383E42"><b>Design das Telas/Forms</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Remover o menu menuStrip1 do Form1.
    - Adicionar um Panel ao form Form1 - `panelMenu`
        ````
        - Dock a esquerda - BackColor: ControlDarkDark  
          Size: 220; 615
        ````
    - Adicionar Panel panelLogo ao Form1
        ````
        - Dock: Top
          BackColor: ControlDark
          Size: 811; 100
        ````
    - Adicionar um button btnProduto ao Form1
        ````
        - Dock: Top
        - Size: 220; 60
        - FlatStyle: Flat
        - FlatAppearance - BorderSize: 0
        - ForeColor: Gainsboro
        - Image: Icone de produto
        - ImageAlign: MiddleLeft
        - TextImageRelation: ImageBeforeText
        - Text: Produto
        - BckColor: 51; 51; 64
        ````
    - Copiar bot�o 5x - Selecionar todos os bot�es e configurar
        ````
        - Padding - Left: 12
        ````
    - Nomear bot�es adicionados: `- Usu�rios - Clientes - Movimenta��o - Cargos, Relat�rios e Funcion�rios`
        ````
        - Dock: Top
        - Size: 220; 60
        - FlatStyle: Flat
        - FlatAppearance - BorderSize: 0
        - ForeColor: Gainsboro
        - Image: Icone apropriado
        - ImageAlign: MiddleLeft
        - TextImageRelation: ImageBeforeText
        - Text: Texto referente ao bot�o
        - BckColor: 51; 51; 64
        ````
    - Criar classe `pdv-windowsforms/ThemeColor.cs`:
        Fun��o changeColorBrightness: Altera cor passada como par�metro e sua intensidade. Usado para alterar a  cor do panelTitleBar e panelLogo (BackColor)
        ````cs
        using System;
        using System.Collections.Generic;
        using System.Drawing;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace pdv_windowsforms
        {
            class ThemeColor
            {
                public static Color primaryColor { get; set; }
                public static Color secondaryColor { get; set; }

                public static List<string> colorList = new List<string>()
                {
                    "#3F5185",
                    "#009688",
                    "#0D421D",
                    "#906720",
                    "#009688",
                    "#FF5722",
                    "#607D88",
                    "#FF9800",
                    "#9C27B0",
                    "#2196F3",
                    "#EA676C",
                    "#E41A4A",
                    "#EF937E",
                    "#F37521",
                    "#A12059",
                    "#126881",
                    "#009488",
                    "#364D5B",
                    "#0094BC",
                    "#E4126B",
                    "#43B76E",
                    "#009688",
                    "#A21D1D",
                    "#5146A7",
                    "#46A769",
                    "#B71C46",
                };

                public static Color changeColorBrightness(Color color, double correctionFactor)
                {
                    double red = color.R;
                    double green = color.G;
                    double blue = color.B;

                    //if correctio factor is less than 0, darken color
                    if (correctionFactor < 0)
                    {
                        correctionFactor = 1 + correctionFactor;
                        red *= correctionFactor;
                        green *= correctionFactor;
                        blue *= correctionFactor;
                    }
                    //If correction factor is greater than zero, lighten color.
                    else
                    {
                        red = (255 - red) * correctionFactor + red;
                        green = (255 - green) * correctionFactor + green;
                        blue = (255 - blue) * correctionFactor + blue;
                    }
                    return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
                }
            }//
        }
        ````
    - Inclus�o de campos no Form1:
        ````cs
        public partial class FrmPrincipal : Form
        {
            //Fields
            private Button currentButton;
            private Random random;
            private int tempIndex;
            private Form activeForm;
            //...
        ````
    - Criar fun��o `selectThemeColor()`:
        ````cs
        //M�todo para selecionar uma cor aleat�ria para o tema da lista de cores (pode usar uma cor se quiser)
        private Color selectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        ````
    - Criar fun��o `activateButton(object btnSender)` - Ativa/destca bot�o clicado:
        ````cs
        // Ativa/destaca bot�o clicado
        private void activateButton(object btnSender)
        {
            if (btnSender != null)
            {
                btnCloseChildForm.Visible = true;
                if(currentButton != (Button)btnSender) 
                {
                    deactivateButton();
                    Color color = selectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.changeColorBrightness(color, -0.3);

                    ThemeColor.primaryColor = color;
                    ThemeColor.secondaryColor = ThemeColor.changeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        ````
    - Criar fun��o void deactivateButton(object btnSender) - Ativa/destaca bot�o clicado:
        ````cs
        //Desativa bot�o selecionado
        private void deactivateButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            }
        }
        ````
    - Adicionar label lblTitle ao painel panelTitleBar:
        Anchor "None" - permite que ao expandir ou diminuir o form mantenha a posi��o do label
        Font - Size:16
        Text: HOME
        ForeColor: ButtonHighlight
        Anchor:None 
    - Adicionar label lblLogo ao painel panelLogo:
        Fonte: Size:14
        Text: ZATEC APP
        ForeColor: ButtonHighlight
    - Adicionar bot�o ao btnCloseChildForm panelTitleBar:
        Text:
        FlatAppearance - BorderSize:0
        Image: uma imagem de x
    - Iniciar campo `random` no construtor Form1
        ````cs
        //Construtor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }
        ````
    - Adicionar chamada ao metodo activateButton ao evento clic dos bot�es e testar
        ````cs
        private void btnProduto_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }
        ````
    - Adicionar panelDesktop ao Form1:
    Recortar imagens e Adicionar panelDesktop ao Form1 de forma preencher toda parte branca (vazia)
    Em seguida, cole as imagens no panelDesktop. `Dock: Fill`
        > `StartPosition - CenterScreen`
        >><img src="readmeImages/projectImages/inclusaoPanelDesktop.png">
    - Criar fun��o openChildForm em Form1:
        ````cs
        //Abre form filho
        private void openChildForm(Form childForm, object btnSender)
        {
            //verifica se tem um form em active form. Caso tenha, ent�o, fecha para abrir outro
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }
        ````
    - Criar fun��o loadTheme no FrmProduto:
     Respons�vel por mudar as cores do form
        ````cs
        private void loadTheme()
        {
            foreach(Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondaryColor;
                }
            }
            lblCargo.ForeColor = ThemeColor.primaryColor; 
        }
        ````
    - Criar fun��o reset() e definir tamanho m�nimo ao redmensionar Form1:
        ````cs
                //Fun��o para retornar o Form1 a forma inicial
        private void reset()
        {
            deactivateButton();
            lblTitle.Text = "Home";
            panelTitleBar.BackColor = Color.FromArgb(0, 156, 136);
            //39; 39; 58
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            btnCloseChildForm.Visible = false;
        }
        ````
    - Ocultar bot�es pad�o do Form1 no construtor - os que ficam a direita canto superior
        ````cs
        //Construtor
        public Form1()
        {
            //...
            this.Text = string.Empty;
            this.ControlBox = false;
        ````
    - Configurar `panelTitleBar` Form1 para  possilitar arrastar
    Em eventos `MouseDown` - duplo click para abrir c�digo
        ````cs
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        ````
    - C�digo do evento - pode ficar em qualquer parte do c�digo do Form1
        ````cs
        [DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "MessageBox")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        ````
    - Definir Form1 para ficar expans�vel apenas na �rea de trabalho sem ultrapassar barra de tarefas.
        ````cs
         //Construtor
        public Form1()
        {
            //...
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        ````
    
    - Adicionar bot�o Minimizar(btnMinimizar), Maximizar(btnMaximizar) e  Fechar(btnFechar) ao panelTitleBar
        ````
        Text: O
        Font - Size:15
        FlatStyle: Flat - BorderSize:0
        ForeColor: Control
        Anchor: Top,Right
        ````
        Evento click do btnMinimizar
        ````cs
                private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        ````
        Evento click do btnMaximizar
        ````cs
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        ````

        Evento click do btnFechar
        ````cs
        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Caso queira incluir mensagem de aviso ao fechar o form, use o c�digo comentado
            //var res = MessageBox.Show("Deseja realmente Fechar?", "Exclus�o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (res == DialogResult.Yes)
            //{ 
            //    Application.Exit();
            //}

            Application.Exit();
        }
        ````
    - Incluir chamada `openChildForm` no evento click dos bot�es do menu:
      <br>Abre o form no panelDesktop
    Evento click `btnCargo`
        ````cs
        private void btnCargos_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            openChildForm(new cadastro.FrmCargo(), sender);
        }
        ````

        Evento click `btnClientes`
        ````cs
        private void btnClientes_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            openChildForm(new cadastro.FrmCliente(), sender);
        }
        ````
        Evento click `btnFuncionarios`
        ````cs
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            openChildForm(new cadastro.FrmFuncionario(), sender);
        }
        ````
    - Incluir campo `data` na tabela cargos, consulta sql em `listar` e `dtgridListCargos` de `FrmCargo`
        ````cs
        private void listar()
        {
            con.abrirConexao();
            sql = "select id, cargo, data from cargos order by cargo asc";
        //...
        ````
        ````cs
        private void formatarGD()
        {
            dtgridListCargos.Columns[0].HeaderText = "ID";
            dtgridListCargos.Columns[1].HeaderText = "Cargo";
            dtgridListCargos.Columns[2].HeaderText = "Data";


            dtgridListCargos.Columns[0].Width = 50;
            dtgridListCargos.Columns[1].Width = 100;
            dtgridListCargos.Columns[2].Width = 100;
            dtgridListCargos.Columns[0].Visible = false;
        }
        ````
        Testar sistema ap�s altera��o
    - Criar m�todo loadTheme no FrmCargo e incluir chamad o envento load
        ````cs
        private void loadTheme()
        {
            foreach(Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondaryColor;
                }
            }
            lblCargo.ForeColor = ThemeColor.primaryColor; 
        }
        ````
        ````cs
        private void FrmCargo_Load(object sender, EventArgs e)
        {
            loadTheme();
            listar();
        }
        ````
    - Criar m�todo loadTheme no FrmCliente e incluir chamad o envento load 
        ````cs
        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondaryColor;
                }
            }
            lblBuscarPorNome.ForeColor = ThemeColor.primaryColor;
        }
        ````
        ````cs
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            loadTheme()
            listar();
        }
        ````
    - Criar m�todo loadTheme no FrmFuncionarios e incluir chamad o envento load 
        ````cs
        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondaryColor;
                }
            }
            lblCadFuncNome.ForeColor = ThemeColor.primaryColor;
        }
        ````
        ````cs
        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            loadTheme();
            //...
        ````
    - Cria��o de labels para a imagens - lblMoviementacao, lblAbrirCaixa, lblFluxoCaixa e lblRelatorios
    - Adicionar toolStrip ao painelDesktop - com dois labels para data e dois para hora
        ````
        Name: toolStripBarraStatus
        Dock: bottom
        ````
    - Incluir timer painelDescktop - permite deixar o toolStrip din�mico com a hora
        ````cs
        //Name:timer
        //Enabled:true
        //ent Tick
        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            toolStripStatusHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        ````

    </p>

    </details> 

 
17. <span style="color:383E42"><b>Criar `FrmLogin` na Raiz do Projeto</b></span>
    <details><summary><span style="color:Chocolate">Detalhes</span></summary>
    <p>

    - Criar `pdv-windowsforms/FrmLogin`
    >Definir MaximumSize e MinimumSize caso quei controlar tamanho que pode expandir ou diminuir
    ````
    StartPosition: CenterScreen
    Text:Acessar
    BackColor:ActiveCaption
    ````
    - Adicionar label `lblUsuario`
        ````
        Font - Size:14        
        Text:Usu�rio
        ````
    - Adicionar label `lblSenha`
        ````
        Font - Size:14
        Text:Senha
        ````
    - Adicionar textBox `txtUsuario`
    - Adicionar textBox `txtSenha` 
    `PasswordChar:*`
    - Adicionar botton `btnEntrar`
        ````
        Font-Size:13
        Text:Entrar
        ````
    - Adicionar btnCancelar
        ````
        Font-Size:13
        Text:Cancelar
        ````
    - Definir abertura de `FrmLogin` em `Program.cs`
        ````cs
        static void Main()
        {
            //...
            Application.Run(new FrmLogin());

        }
        ````

    - Criar tabela usuarios no database `pdv` e inserir um usu�rio

    
        | Nome | Tipo | Cola��o | Atributos | Nulo | Padr�o | Coment�rios | Extra |
        | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | 
        | id Prim�ria | int(11) |  |  | N�o | Nenhum |  | AUTO_INCREMENT |
        | nome | varchar(30) | utf8_general_ci |  | N�o | Nenhum |  |  |
        | cargo | varchar(20) | utf8_general_ci |  | N�o | Nenhum |  |  |
        | usuario | varchar(30) | utf8_general_ci |  | N�o | Nenhum |  |  |
        | senha | varchar(30) | utf8_general_ci |  | N�o | Nenhum |  |  |
        | data | date |  |  | N�o | Nenhum |  |  |
    
        ````sql
        INSERT into usuarios(id,nome,cargo,usuario,senha,data) VALUES(null,'alex','Gerente','alex','123','2024-02-19');
        ````
    - Criar vari�veis em `FrmLogin`
        ````cs
        public partial class FrmLogin : Form
        {
            Conexao con = new Conexao();
            string sql;
            MySqlCommand cmd;
            //...
        ````
    - Criar classe `pdv-windowsforms/Verificar.cs` na raiz
        ````cs
        namespace pdv_windowsforms
        {
            class Verificar
            {
                public static string nomeUsuario;
                public static string cargoUsuario;

            }
        }
        ````
    - Exibir usu�rio logado no sistema: Adicionar labels
        ````
        label Usu�rio(toolStripStatusLblUsuario)
        label toolStripStatusLblNomeUsuario
        label toolStripStatusLblCargo
        ````
    - Incluir o nome de usu�rio e cargo no evento `load` de Form1
        ````cs
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLblNomeUsuario.Text = Verificar.nomeUsuario;
            toolStripStatusLblCargo.Text = Verificar.cargoUsuario;
        }
        ````
    - Criar fun��o `chamarLogin`
        ````cs
        private void chamarLogin()
        {
            //
            if (txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Informe o usu�rio e/ou senha!");
                return;
            }
            try
            {
                con.abrirConexao();
                MySqlCommand cmdVerificar;
                MySqlDataReader reader; //Com o reader podemos extrari dados da tabela e usar em outros forms

                cmdVerificar = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmdVerificar.Parameters.AddWithValue("@senha", txtSenha.Text);
                reader = cmdVerificar.ExecuteReader();
                if (reader.HasRows)
                {
                    //extraindo dados do login
                    while (reader.Read())
                    {
                        Verificar.nomeUsuario = Convert.ToString(reader["usuario"]);
                        Verificar.cargoUsuario = Convert.ToString(reader["cargo"]);

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usu�rio e/ou senha inv�lido!");
                    txtSenha.Text = "";
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                    //return;
                }
                con.fecharConexao();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        ````


    </p>

    </details> 



## Autor
><span style="color:383E42"><b>Cristiano Mendon�a Gueivara</b> </span>
>
>>[<img src="https://sspectro.github.io/images/githubIcon.png">](https://github.com/sspectro "Meu perfil no github")
>
>><a href="https://linkedin.com/in/cristiano-m-gueivara/"><img src="https://sspectro.github.io/images/linkedinIcon.png"></a> 
>
>>[<img src="https://sspectro.github.io/images/cristiano.jpg" height="25" width="25"> - Minha P�gina Github](https://sspectro.github.io/#home "Minha P�gina no github")<br>

><span style="color:383E42"><b>Licen�a:</b> </span> Distribu�do sobre a licen�a `Software Livre`. Veja Licen�a **[MIT](https://github.com/sspectro/Net-Core6-Com-Bootstrap5/blob/main/LICENSE)**.