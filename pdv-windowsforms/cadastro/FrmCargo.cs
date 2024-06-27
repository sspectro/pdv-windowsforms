using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string cargoAntigo = "";

        public FrmCargo()
        {
            InitializeComponent();
        }

        private void formatarGD()
        {
            dtgridListCargos.Columns[0].HeaderText = "ID";
            dtgridListCargos.Columns[1].HeaderText = "Cargo";

            dtgridListCargos.Columns[0].Width = 50;
            dtgridListCargos.Columns[1].Width = 100;
            dtgridListCargos.Columns[0].Visible = false;
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            listar();
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            txtCargo.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente Excluir o cargo " +cargoAntigo+ " ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {

                con.abrirConexao();
                sql = "delete from cargos where id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.fecharConexao();
                listar();
                MessageBox.Show("Cargo Exluído com sucesso!", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                txtCargo.Text = "";

            }
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
            sql = "insert into cargos(cargo, data) values(@cargo, curDate())";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);


            cmd.ExecuteNonQuery();
            con.fecharConexao();



            listar();

            MessageBox.Show("Registro Salvo com Sucesso!", "Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }
        private void listar()
        {
            con.abrirConexao();
            sql = "select id, cargo from cargos order by cargo asc";
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

            //Verifica se Cargo já existe
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
                    MessageBox.Show("Cargo "+txtCargo.Text+ " já registrado", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCargo.Text = "";
                    txtCargo.Focus();
                    return;
                }

            }

            //Botão Editar
            sql = "update cargos set cargo = @cargo where id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);

            cmd.ExecuteNonQuery();
            con.fecharConexao();
            listar();

            MessageBox.Show("Registro do " + txtCargo.Text + " Editado com sucesso!", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            txtCargo.Text = "";
        }

        private void dtgridListCargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;
                txtCargo.Enabled = true;

                id = dtgridListCargos.CurrentRow.Cells[0].Value.ToString();
                txtCargo.Text = dtgridListCargos.CurrentRow.Cells[1].Value.ToString();
                cargoAntigo = dtgridListCargos.CurrentRow.Cells[1].Value.ToString();//Não necessário, pois este valor já está no txtCargo.Text
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCargo.Enabled = true;
            btnSalvar.Enabled = true;
        }

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
            lblCargo.ForeColor = ThemeColor.primaryColor;
        }
    }//
}
