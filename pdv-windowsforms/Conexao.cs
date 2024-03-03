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
