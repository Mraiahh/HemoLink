using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SistDoacaoSangue.Models;
using SistDoacaoSangue.Util;

namespace SistDoacaoSangue.DAO
{
    public class HospitaisDAO
    {
        public bool Create(Hospitais hospital)
        {
            string sql = "INSERT INTO hospitais (nome, cidade, estado, telefone, email) VALUES (@nome, @cidade, @estado, @telefone, @email);";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", hospital.Nome);
                    cmd.Parameters.AddWithValue("@cidade", hospital.Cidade);
                    cmd.Parameters.AddWithValue("@estado", hospital.Estado);
                    cmd.Parameters.AddWithValue("@telefone", hospital.Telefone);
                    cmd.Parameters.AddWithValue("@email", hospital.Email);
                    bool executou = cmd.ExecuteNonQuery() > 0;

                    if (executou)
                    {
                        hospital.IdHospital = (int)cmd.LastInsertedId;
                        Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Cadastro do hospital de ID: {hospital.IdHospital}");
                    }

                    return executou;
                }
            }
        }

        public List<Hospitais> ReadAll()
        {
            List<Hospitais> lista = new List<Hospitais>();
            string sql = "SELECT * FROM hospitais ORDER BY nome;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Hospitais hospital = new Hospitais
                            {
                                IdHospital = reader.GetInt32("idHospital"),
                                Nome = reader.GetString("nome"),
                                Cidade = reader.GetString("cidade"),
                                Estado = reader.GetString("estado"),
                                Telefone = reader.GetString("telefone"),
                                Email = reader.GetString("email")
                            };
                            lista.Add(hospital);
                        }
                    }
                }
            }
            Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, "Consulta da lista de hospitais");

            return lista;
        }

        public bool Update(Hospitais hospital)
        {
            string sql = "UPDATE hospitais SET nome=@nome, cidade=@cidade, estado=@estado, telefone=@telefone, email=@email WHERE idHospital=@id;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", hospital.IdHospital);
                    comando.Parameters.AddWithValue("@nome", hospital.Nome);
                    comando.Parameters.AddWithValue("@cidade", hospital.Cidade);
                    comando.Parameters.AddWithValue("@estado", hospital.Estado);
                    comando.Parameters.AddWithValue("@telefone", hospital.Telefone);
                    comando.Parameters.AddWithValue("@email", hospital.Email);

                    bool alterou = comando.ExecuteNonQuery() > 0;

                    if (alterou)
                    {
                        Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Atualização do hospital de ID: {hospital.IdHospital}");
                    }

                    return alterou;
                }
            }
        }

        public bool Delete(int idHospital)
        {
            string sql = "DELETE FROM hospitais WHERE idHospital = @idHospital;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))

                {
                    cmd.Parameters.AddWithValue("@idHospital", idHospital);
                    bool excluiu = cmd.ExecuteNonQuery() > 0;

                    if (excluiu)
                    {
                        Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Exclusão do hospital de ID: {idHospital}");
                    }

                    return excluiu;
                }
            }
        }

        public bool IsHospital(string email)
        {
            string sql = "SELECT COUNT(*) FROM hospitais WHERE email = @email;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public Hospitais ReadByID(int idHospital)
        {
            string sql = "SELECT * FROM hospitais WHERE idHospital = @idHospital;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idHospital", idHospital);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Hospitais
                            {
                                IdHospital = reader.GetInt32("idHospital"),
                                Nome = reader.GetString("nome"),
                                Cidade = reader.GetString("cidade"),
                                Estado = reader.GetString("estado"),
                                Telefone = reader.GetString("telefone"),
                                Email = reader.GetString("email")
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
