using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SistDoacaoSangue.Models;
using SistDoacaoSangue.Util;

namespace SistDoacaoSangue.Models
{
    public class AgendamentosDAO
    {
        public bool Create(Agendamentos agendamento)
        {
            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "INSERT INTO agendamentos (idUsuario, idHospital, dataAgendada, status) " +
                             "VALUES (@idUsuario, @idHospital, @dataAgendada, @status);";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@idUsuario", agendamento.Usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@idHospital", agendamento.Hospital.IdHospital);
                cmd.Parameters.AddWithValue("@dataAgendada", agendamento.DataAgendada);
                cmd.Parameters.AddWithValue("@status", agendamento.Status);

                bool executou = cmd.ExecuteNonQuery() > 0;
                if (executou)
                {
                    agendamento.IdAgendamento = (int)cmd.LastInsertedId;
                    Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Cadastro do agendamento de ID: {agendamento.IdAgendamento} no hospital de ID: {agendamento.Hospital.IdHospital}");
                }

                return executou;
            }
        }

        public bool Delete(int idAgendamento)
        {
            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "DELETE FROM agendamentos WHERE idAgendamento = @idAgendamento;";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idAgendamento", idAgendamento);
                
                bool excluiu = cmd.ExecuteNonQuery() > 0;

                if (excluiu)
                {
                    Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Exclusão do agendamento de ID: {idAgendamento}");
                }
                return excluiu;
            }
        }

        public bool Update(Agendamentos agendamento)
        {
            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "UPDATE agendamentos SET " +
                             "idUsuario = @idUsuario, " +
                             "idHospital = @idHospital, " +
                             "dataAgendada = @dataAgendada, " +
                             "status = @status " +
                             "WHERE idAgendamento = @idAgendamento;";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@idAgendamento", agendamento.IdAgendamento);
                cmd.Parameters.AddWithValue("@idUsuario", agendamento.Usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@idHospital", agendamento.Hospital.IdHospital);
                cmd.Parameters.AddWithValue("@dataAgendada", agendamento.DataAgendada);
                cmd.Parameters.AddWithValue("@status", agendamento.Status);

                bool alterou = cmd.ExecuteNonQuery() > 0;

                if (alterou)
                {
                    Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Atualização do agendamento de ID: {agendamento.IdAgendamento} no hospital de ID: {agendamento.Hospital.IdHospital}");
                }
                return alterou;
            }
        }

        public List<Agendamentos> ReadAll()
        {
            List<Agendamentos> listaAgendamentos = new List<Agendamentos>();

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "SELECT * FROM agendamentos ORDER BY idAgendamento;";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaAgendamentos.Add(new Agendamentos
                        {
                            IdAgendamento = reader.GetInt32("idAgendamento"),
                            Usuario = new Usuario { IdUsuario = reader.GetInt32("idUsuario") },
                            Hospital = new Hospitais { IdHospital = reader.GetInt32("idHospital") },
                            DataAgendada = reader.GetDateTime("dataAgendada"),
                            Status = reader.GetString("status")
                        });
                    }
                }
            }
            Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, "Verificação da lista de agendamentos");
            return listaAgendamentos;
        }

        public Agendamentos ReadByID(int idAgendamento)
        {
            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "SELECT * FROM agendamentos WHERE idAgendamento = @idAgendamento;";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idAgendamento", idAgendamento);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Agendamentos
                        {
                            IdAgendamento = reader.GetInt32("idAgendamento"),
                            Usuario = new Usuario { IdUsuario = reader.GetInt32("idUsuario") },
                            Hospital = new Hospitais { IdHospital = reader.GetInt32("idHospital") },
                            DataAgendada = reader.GetDateTime("dataAgendada"),
                            Status = reader.GetString("status")
                        };
                    }
                }
            }

            return null;
        }
    }
}
