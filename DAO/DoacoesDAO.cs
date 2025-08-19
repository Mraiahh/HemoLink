using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SistDoacaoSangue.Models;
using SistDoacaoSangue.Util;

namespace SistDoacaoSangue.DAO
{
    public class DoacoesDAO
    {
        public bool Create(Doacoes doacao)
        {
            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "INSERT INTO doacoes (idUsuario, dataDoacao, local, observacao) VALUES (@idUsuario, @dataDoacao, @local, @observacao);";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", doacao.Usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@dataDoacao", doacao.DataDoacao);
                    cmd.Parameters.AddWithValue("@local", doacao.Local);
                    cmd.Parameters.AddWithValue("@observacao", doacao.Observacao);

                    bool executou = cmd.ExecuteNonQuery() > 0;

                    if (executou)
                    {
                        // Obtém o ID gerado para o novo registro inserido
                        doacao.IdDoacao = (int)cmd.LastInsertedId;
                        Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Cadastro da doação de ID: {doacao.IdDoacao}");
                    }
                    return executou;
                }
            }
        }

        public List<Doacoes> ReadAll()
        {
            List<Doacoes> listaDoacoes = new List<Doacoes>();

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "SELECT * FROM doacoes ORDER BY idUsuario;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doacoes doacoes = new Doacoes
                            {
                                IdDoacao = reader.GetInt32("idDoacao"),
                                Usuario = new Usuario { IdUsuario = reader.GetInt32("idUsuario") },
                                DataDoacao = reader.GetDateTime("dataDoacao"),
                                Local = reader.GetString("local"),
                                Observacao = reader.GetString("observacao")
                            };

                            listaDoacoes.Add(doacoes);
                        }
                    }
                }
            }
            Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, "Consulta da lista de doações");

            return listaDoacoes;
        }

        public bool Update(Doacoes doacao)
        {
            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "UPDATE doacoes SET dataDoacao = @dataDoacao, local = @local, observacao = @observacao WHERE idDoacao = @idDoacao;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idDoacao", doacao.IdDoacao);
                    cmd.Parameters.AddWithValue("@dataDoacao", doacao.DataDoacao);
                    cmd.Parameters.AddWithValue("@local", doacao.Local);
                    cmd.Parameters.AddWithValue("@observacao", doacao.Observacao);

                    bool alterou = cmd.ExecuteNonQuery() > 0;

                    if (alterou)
                    {
                        Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Atualização da doação de ID: {doacao.IdDoacao}");
                    }
                    return alterou;
                }
            }
        }

        public bool Delete(int idDoacao)
        {
            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "DELETE FROM doacoes WHERE idDoacao = @idDoacao;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idDoacao", idDoacao);
                    bool excluiu = cmd.ExecuteNonQuery() > 0;

                    if (excluiu)
                    {
                        Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Exclusão da doação de ID: {idDoacao}");
                    }

                    return excluiu;
                }
            }
        }

        public static Doacoes ReadByID(int idDoacao)
        {
            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                string sql = "SELECT * FROM doacoes WHERE idDoacao = @idDoacao;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idDoacao", idDoacao);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Doacoes doacoes = new Doacoes
                            {
                                IdDoacao = reader.GetInt32("idDoacao"),
                                Usuario = new Usuario { IdUsuario = reader.GetInt32("idUsuario") },
                                DataDoacao = reader.GetDateTime("dataDoacao"),
                                Local = reader.GetString("local"),
                                Observacao = reader.GetString("observacao")
                            };

                            return doacoes;
                        }
                    }
                }
            }

            return null;
        }
    }
}
