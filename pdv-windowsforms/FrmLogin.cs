using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv_windowsforms
{
    public partial class FrmLogin : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void chamarLogin()
        {
            //
            if (txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Informe o usuário e/ou senha!");
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
                    MessageBox.Show("Usuário e/ou senha inválido!");
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            chamarLogin();
        }
    }//
}
