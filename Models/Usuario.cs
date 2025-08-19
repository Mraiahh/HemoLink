using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistDoacaoSangue.Models;
using SistDoacaoSangue.Util;

namespace SistDoacaoSangue.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string TipoSanguineo { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataUltimaDoacao { get; set; }
        public string StatusDoador { get; set; }
        public string Aptidao { get; set; }
        public string Telefone { get; set; }
        public string NivelAcesso { get; set; }

        public override string ToString()
        {
            return $"ID: {IdUsuario} | Nome: {NomeUsuario} | Email: {Email} | Telefone: {Telefone}";
        }
    }
}

