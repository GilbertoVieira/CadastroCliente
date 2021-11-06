using System.Data.SqlClient;

namespace CadastroCliente
{
    class clsapoio
    {

        //CONEXÃO COM BANCO DE DADOS
        public SqlConnection conn = new SqlConnection();
        public void stringBD()
        {
            conn.ConnectionString = (@"Server=.\PDVNET;Database=clientes;User Id=sa;Password=inter#system;");
            conn.Open();
        }
        public void desconectarBD()
        {
            conn.Close();
        }
    }
}
