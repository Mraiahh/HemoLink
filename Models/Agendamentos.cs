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
    public class Agendamentos
    {
        public int IdAgendamento { get; set; }
        public Usuario Usuario { get; set; } 
        public Hospitais Hospital { get; set; }
        public DateTime DataAgendada { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return DataAgendada.ToString("dd/MM/yyyy");
        }
    }
} 

