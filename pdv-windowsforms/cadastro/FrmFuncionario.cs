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
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            limparFoto();

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
    }
}
