using System;
using MySql.Data.MySqlClient;

namespace SistDoacaoSangue.Util
{
    /// <summary>
    /// Classe responsável por gerenciar a conexão com o banco de dados MySQL.
    /// </summary>
    public class Conexao
    {
        // Configurações de acesso ao banco
        private static readonly string HOST = "127.0.0.1";
        private static readonly string USER = "root";
        private static readonly string PWD = "";
        private static readonly string DB = "Banco";
        private static readonly int PORT = 3306;

        /// <summary>
        /// Cria e retorna uma nova conexão aberta com o banco de dados MySQL.
        /// Use este método dentro de um 'using' para garantir fechamento correto.
        /// </summary>
        /// <returns>Nova instância de MySqlConnection aberta.</returns>
        public static MySqlConnection CriarNovaConexao()
        {
            string connectionString = $"Server={HOST};Port={PORT};Database={DB};User={USER};Password={PWD};";
            var conexao = new MySqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }

        /// <summary>
        /// Retorna a string de conexão (útil para debug ou outras finalidades).
        /// </summary>
        public static string GetConnectionString()
        {
            return $"Server={HOST};Port={PORT};Database={DB};User={USER};Password={PWD};";
        }
    }
}
