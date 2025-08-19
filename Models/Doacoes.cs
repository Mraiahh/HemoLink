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
    public class Doacoes
    {
        public int IdDoacao { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataDoacao { get; set; }
        public string Local { get; set; }
        public string Observacao { get; set; }

        public override string ToString()
        {
            return Usuario.NomeUsuario;
        }
    }
} 

