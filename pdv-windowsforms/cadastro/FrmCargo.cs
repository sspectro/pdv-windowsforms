using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv_windowsforms.cadastro
{
    public partial class FrmCargo : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        string id = "";
        public FrmCargo()
        {
            InitializeComponent();
        }

        private void formatarGD()
        {
            dtgridListCargos.Columns[0].HeaderText = "ID";
            dtgridListCargos.Columns[1].HeaderText = "Cargo";

            dtgridListCargos.Columns[0].Width = 50;
            dtgridListCargos.Columns[1].Width = 50;
            dtgridListCargos.Columns[0].Visible = false;
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }
    }
}
