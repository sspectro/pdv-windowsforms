using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing.Printing;
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
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            limparFoto();
            listar();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Tratar dados
            if(txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if(txtCpf.Text == "   ,   ,   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Text = "";
                txtCpf.Focus();
                return;
            }

            con.abrirConexao();
            sql = "insert into funcionarios(nome, cpf, endereco, telefone, cargo, data, foto) values(@nome, @cpf, @endereco, @telefone, @cargo, curDate(), @foto)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@foto", img());//img() método criado para tratar imagem para o database


            cmd.ExecuteNonQuery();
            con.fecharConexao();


            limparFoto();
            listar();

            MessageBox.Show("Registro Salvao com Sucesso!","Cadastro funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            limparCampos();
            desabilitarCampos();
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

        private byte[] img()//Este metodo é padrão, serve sempre que desejar enviar imagem para o banco de dados
        {
            byte[] imagem_byte = null;
            if(foto == "") //a string foto, nuca vai estar vazia, porque no metodo LimparFoto() foi passado o caminho de uma imagem
            {
                return null;
            }

            //usar o FileStream para enviar imagem para o BD e tres parâmetros local(foto), tipo de imagem(FileMode), tipo de acesso(FileAcess)
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);//padrão
            BinaryReader br = new BinaryReader(fs);//serve para trabalhar com FileStream

            imagem_byte = br.ReadBytes((int)fs.Length);

            return imagem_byte;

        }
        private void limparFoto()
        {
            pictboxFoto.Image = Properties.Resources.sem_foto2; //Aqui coloca a imagem sem foto na picutre do form
            foto = "img/sem_foto2.jpg"; //atribuido um caminho de foto (assim esta imagem tem que estar na pasta debug
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

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

        private void limparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled=false;
            txtCpf.Enabled=false;
            txtEndereco.Enabled=false;
            txtTelefone.Enabled=false;
            cbCargo.Enabled=false;
        }

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

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
