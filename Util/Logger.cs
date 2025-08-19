using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistDoacaoSangue.Models;

namespace SistDoacaoSangue.Util
{
    public static class Logger
    {
        private static string caminhoLog = "log_sistema.txt";

        public static void Registrar(string nomeUsuario, int idUsuario, string acao)
        {
            string linha = $"[{DateTime.Now}] | ID: {idUsuario} | Nome: {nomeUsuario} | Ação: {acao}";
            File.AppendAllText(caminhoLog, linha + Environment.NewLine);
        }
    }
}
