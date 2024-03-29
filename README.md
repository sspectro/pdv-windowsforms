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

12. <span style="color:383E42"><b>Formatar Grid e Criar Form Cargo</b></span>
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


## Meta
><span style="color:383E42"><b>Cristiano Mendon�a Gueivara</b> </span>
>
>>[<img src="readmeImages/githubIcon.png">](https://github.com/sspectro "Meu perfil no github")
>
>><a href="https://linkedin.com/in/cristiano-m-gueivara/"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white"></a> 
>
>>[<img src="https://sspectro.github.io/images/cristiano.jpg" height="25" width="25"> - Minha P�gina Github](https://sspectro.github.io/#home "Minha P�gina no github")<br>



><span style="color:383E42"><b>Licen�a:</b> </span> Distribu�do sobre a licen�a `Software Livre`. Veja Licen�a **[MIT](https://opensource.org/license/mit/)**.