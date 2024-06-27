using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv_windowsforms.cadastro
{
    public partial class FrmCliente : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        string id = "";
        string cpfAntigo = "";

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void formatarGD()
        {
            dtgridListClientes.Columns[0].HeaderText = "ID";
            dtgridListClientes.Columns[1].HeaderText = "Código";
            dtgridListClientes.Columns[2].HeaderText = "Nome";
            dtgridListClientes.Columns[3].HeaderText = "CPF";
            dtgridListClientes.Columns[4].HeaderText = "Em Aberto";
            dtgridListClientes.Columns[5].HeaderText = "Telefone";
            dtgridListClientes.Columns[6].HeaderText = "Email";
            dtgridListClientes.Columns[7].HeaderText = "Desbloqueado";
            dtgridListClientes.Columns[8].HeaderText = "Status";
            dtgridListClientes.Columns[9].HeaderText = "Endereço";
            dtgridListClientes.Columns[10].HeaderText = "Funcionário";
            dtgridListClientes.Columns[11].HeaderText = "igm";
            dtgridListClientes.Columns[12].HeaderText = "Data";
            //dtgridListClientes.Columns[0].Width = 50;
            dtgridListClientes.Columns[0].Visible = false;
            dtgridListClientes.Columns[11].Visible = false;
            dtgridListClientes.Columns[4].DefaultCellStyle.Format = "c2";


        }

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

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            loadTheme();
            listar();
        }

        //private void buscarPNome()
        //{
        //    con.abrirConexao();
        //    sql = "select * form clientes where nome like @nome order by nome asc"; //Like, busca nome por aproximação
        //    cmd = new MySqlCommand(sql, con.con);
        //    cmd.Parameters.AddWithValue("@nome", txtBuscarNome.Text + "%"); //"% - operador like, busca nome por aproximação
        //    MySqlDataAdapter adapter = new MySqlDataAdapter();
        //    adapter.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    dtgridListClientes.DataSource = dt;
        //    con.fecharConexao();

        //    formatarGD();
        //}

        //private void buscarCpf()
        //{
        //    con.abrirConexao();
        //    sql = "select * form clientes where cpf=@cpf order by nome asc";
        //    cmd = new MySqlCommand(sql, con.con);
        //    cmd.Parameters.AddWithValue("@nome", txtBuscarCpf.text);
        //    MySqlDataAdapter adapter = new MySqlDataAdapter();
        //    adapter.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    dtgridListClientes.DataSource = dt;
        //    con.fecharConexao();

        //    formatarGD();
        //}

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

        private void limparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            cblInadimplente.SelectedIndex = 0;
        }

        //private void ultimoIdCliente()
        //{
        //    con.abrirConexao();
        //    MySqlCommand cmdVerificar;
        //    MySqlDataReader reader; //Com reader vour conseguir extrair dados da tabela e usar em outros forms
        //    cmdVerificar = new MySqlCommand("select id from clientes order by id desc limit 1", con.con);
        //    MySqlDataAdapter da = new MySqlDataAdapter();
        //    da.SelectCommand = cmdVerificar;
        //    reader = cmdVerificar.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            //codReserva = Convert.ToString(reader["id"]);
        //            idAnterior = Convert.ToInt32(reader["id"]);
        //            codCliente = IdAnterior + 1;
        //        }
        //    }
        //}

        //private byte[] img() // Este método é padrão, serve para enviar um imagem para o banco de dados
        //{
        //    byte[] imagem_byte = null;
        //    if(foto == "")
        //    {
        //        return null;
        //    }

        //    // Usar o FileStream para enviar imagem para o BD e três parametros - local(foto) - tipo imagem(FileMode) - tipo de acesso(FileAcess
        //    FileStream fs = new FileStream(foto,FileMode.Open, FileAccess.Read); // padrão

        //    BinaryReader br = new BinaryReader(fs); // Serve para trabalhar com o FileStream

        //    imagem_byte = br.ReadBytes((int)fs.Length); //Pegando o comprimento de FileStream jogando dentro de um tipo Imagem BYTE

        //    return imagem_byte;

        //}

        //private void limparFoto()
        //{
        //    image.Image = Properties.Resources.perfil; // Coloca a imagem sem_foto na pictre do form
        //    foto = "img/perfil.jpg"; // Atribuindo um caminho de foto(esta imagem deve estar na pasta debug)
        //}

        //private void btnNovo_Click(object sender, EventArgs e)
        //{
        //    habilitarCampos();
        //    limparCampos();
        //    limparFoto();
        //    btnSalvar.Enabled = true;
        //    btnNovo.Enabled = false;
        //    btnEditar.Enabled = false;
        //    btnExcluir.Enabled = false;
        //    btnImg.Enabled = true;
        //}

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

    }//
}
