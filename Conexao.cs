
using MySql.Data.MySqlClient;

namespace SistemaChamados
{
    public class Conexao
    {
        private string conexaoString =
            "Server=127.0.0.1;Port=3336;Database=SistemaChamados;Uid=root;Pwd=root;";

        public MySqlConnection Conectar()
        {
            return new MySqlConnection(conexaoString);
        }
    }
}
