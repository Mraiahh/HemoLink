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
    public class Solicitacoes
    {
        public int IdSolicitacao { get; set; }
        public Hospitais Hospital { get; set; }
        public string TipoSanguineo { get; set; }
        public string QtdNecessaria { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return DataSolicitacao.ToString("dd/MM/yyyy");
        }
    }
} 

