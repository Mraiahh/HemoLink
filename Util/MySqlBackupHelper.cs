using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace SistDoacaoSangue.Util
{
    public class MySqlBackupHelper
    {
        private string _connectionString;

        public MySqlBackupHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void FazerBackup(string arquivoBackup)
        {
            using (var conn = new MySqlConnection(_connectionString))
            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = conn;
                var backup = new MySqlBackup(cmd);
                conn.Open();
                backup.ExportToFile(arquivoBackup);
                conn.Close();
            }
        }

        public void RestaurarBackup(string arquivoBackup)
        {
            using (var conn = new MySqlConnection(_connectionString))
            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = conn;
                var backup = new MySqlBackup(cmd);
                conn.Open();
                backup.ImportFromFile(arquivoBackup);
                conn.Close();
            }
        }
    }
}
