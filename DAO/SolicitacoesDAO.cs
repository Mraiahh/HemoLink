using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SistDoacaoSangue.Models;
using SistDoacaoSangue.Util;

namespace SistDoacaoSangue.DAO
{
    public class SolicitacoesDAO
    {
        public bool Create(Solicitacoes solicitacao)
        {
            string sql = "INSERT INTO solicitacoes (idHospital, tipoSanguineo, qtdNecessaria, dataSolicitacao, status) " +
                         "VALUES (@idHospital, @tipoSanguineo, @qtdNecessaria, @dataSolicitacao, @status);";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idHospital", solicitacao.Hospital.IdHospital);
                    cmd.Parameters.AddWithValue("@tipoSanguineo", solicitacao.TipoSanguineo);
                    cmd.Parameters.AddWithValue("@qtdNecessaria", solicitacao.QtdNecessaria);
                    cmd.Parameters.AddWithValue("@dataSolicitacao", solicitacao.DataSolicitacao);
                    cmd.Parameters.AddWithValue("@status", solicitacao.Status);

                    bool executou = cmd.ExecuteNonQuery() > 0;

                    if (executou)
                    {
                        solicitacao.IdSolicitacao = (int)cmd.LastInsertedId;
                        Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Cadastro da solicitação de ID: {solicitacao.IdSolicitacao} no hospital de ID: {solicitacao.Hospital.IdHospital}");
                    }
                    return executou;
                }
            }
        }

        public List<Solicitacoes> ReadAll()
        {
            List<Solicitacoes> listaSolicitacoes = new List<Solicitacoes>();
            string sql = "SELECT * FROM solicitacoes ORDER BY dataSolicitacao;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Solicitacoes solicitacao = new Solicitacoes
                            {
                                IdSolicitacao = reader.GetInt32("idSolicitacao"),
                                Hospital = new Hospitais { IdHospital = reader.GetInt32("idHospital") },
                                TipoSanguineo = reader.GetString("tipoSanguineo"),
                                QtdNecessaria = reader.GetString("qtdNecessaria"),
                                DataSolicitacao = reader.GetDateTime("dataSolicitacao"),
                                Status = reader.GetString("status")
                            };
                            listaSolicitacoes.Add(solicitacao);
                        }
                    }
                }
            }
            Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, "Consulta da lista de solicitações");
            return listaSolicitacoes;
        }

        public bool Update(Solicitacoes solicitacoes)
        {
            string sql = "UPDATE solicitacoes SET tipoSanguineo = @tipoSanguineo, qtdNecessaria = @qtdNecessaria, " +
                         "dataSolicitacao = @dataSolicitacao, status = @status WHERE idSolicitacao = @idSolicitacao";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idSolicitacao", solicitacoes.IdSolicitacao);
                    cmd.Parameters.AddWithValue("@tipoSanguineo", solicitacoes.TipoSanguineo);
                    cmd.Parameters.AddWithValue("@qtdNecessaria", solicitacoes.QtdNecessaria);
                    cmd.Parameters.AddWithValue("@dataSolicitacao", solicitacoes.DataSolicitacao);
                    cmd.Parameters.AddWithValue("@status", solicitacoes.Status);

                    bool alterou = cmd.ExecuteNonQuery() > 0;

                    if (alterou)
                    {
                        Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Atualização da solicitação de ID: {solicitacoes.IdSolicitacao}");
                    }

                    return alterou;
                }
            }
        }

        public bool Delete(int idSolicitacao)
        {
            string sql = "DELETE FROM solicitacoes WHERE idSolicitacao = @id";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", idSolicitacao);
                    bool excluiu = cmd.ExecuteNonQuery() > 0;

                    if (excluiu)
                    {
                        Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Exclusão da solicitação de ID: {idSolicitacao}");
                    }

                    return excluiu;
                }
            }
        }

        public Solicitacoes ReadById(int idSolicitacao)
        {
            string sql = "SELECT * FROM solicitacoes WHERE idSolicitacao = @idSolicitacao;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idSolicitacao", idSolicitacao);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Solicitacoes
                            {
                                IdSolicitacao = reader.GetInt32("idSolicitacao"),
                                Hospital = new Hospitais { IdHospital = reader.GetInt32("idHospital") },
                                TipoSanguineo = reader.GetString("tipoSanguineo"),
                                QtdNecessaria = reader.GetString("qtdNecessaria"),
                                DataSolicitacao = reader.GetDateTime("dataSolicitacao"),
                                Status = reader.GetString("status")
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
