using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistDoacaoSangue.Models;
using SistDoacaoSangue.Util;

namespace SistDoacaoSangue.DAO
{
    public class UsuarioDAO
    {
        public bool Create(Usuario usuario)
        {
            string sql = @"INSERT INTO usuario 
                (nomeUsuario, senhaUsuario, email, telefone, dataNascimento, sexo, tipoSanguineo, cidade, estado, dataUltimaDoacao, statusDoador, aptidao, nivelAcesso) 
                VALUES (@nomeUsuario, @senhaUsuario, @email, @telefone, @dataNascimento, @sexo, @tipoSanguineo, @cidade, @estado, @dataUltimaDoacao, @statusDoador, @aptidao, @nivelAcesso);";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nomeUsuario", usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", usuario.SenhaUsuario);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@dataNascimento", usuario.DataNascimento);
                cmd.Parameters.AddWithValue("@sexo", usuario.Sexo);
                cmd.Parameters.AddWithValue("@tipoSanguineo", usuario.TipoSanguineo);
                cmd.Parameters.AddWithValue("@cidade", usuario.Cidade);
                cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                cmd.Parameters.AddWithValue("@dataUltimaDoacao", usuario.DataUltimaDoacao);
                cmd.Parameters.AddWithValue("@statusDoador", usuario.StatusDoador);
                cmd.Parameters.AddWithValue("@aptidao", usuario.Aptidao);
                cmd.Parameters.AddWithValue("@nivelAcesso", usuario.NivelAcesso);


                bool executou = cmd.ExecuteNonQuery() > 0;
                if (executou)
                {
                    // Obtém o ID gerado para o novo registro inserido
                    usuario.IdUsuario = (int)cmd.LastInsertedId;
                    Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Cadastro do usuário de ID: {usuario.IdUsuario}");
                }
                return executou;
            }
        }

        public List<Usuario> ReadAll()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string sql = "SELECT * FROM usuario ORDER BY nomeUsuario;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        IdUsuario = reader.GetInt32("idUsuario"),
                        NomeUsuario = reader.GetString("nomeUsuario"),
                        SenhaUsuario = reader.GetString("senhaUsuario"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        DataNascimento = reader.GetDateTime("dataNascimento"),
                        Sexo = reader.GetString("sexo"),
                        TipoSanguineo = reader.GetString("tipoSanguineo"),
                        Cidade = reader.GetString("cidade"),
                        Estado = reader.GetString("estado"),
                        DataUltimaDoacao = reader.GetDateTime("dataUltimaDoacao"),
                        StatusDoador = reader.GetString("statusDoador"),
                        Aptidao = reader.GetString("aptidao")
                    };

                    listaUsuarios.Add(usuario);
                }
            }
            Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, "Consulta da lista de usuários");
            return listaUsuarios;
        }

        public bool Update(Usuario usuario)
        {
            string sql = @"UPDATE usuario SET 
                nomeUsuario = @nomeUsuario,
                senhaUsuario = @senhaUsuario,
                email = @email,
                telefone = @telefone,
                dataNascimento = @dataNascimento,
                sexo = @sexo,
                tipoSanguineo = @tipoSanguineo,
                cidade = @cidade,
                estado = @estado,
                dataUltimaDoacao = @dataUltimaDoacao,
                statusDoador = @statusDoador,
                aptidao = @aptidao
                WHERE idUsuario = @idUsuario;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nomeUsuario", usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", usuario.SenhaUsuario);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@dataNascimento", usuario.DataNascimento);
                cmd.Parameters.AddWithValue("@sexo", usuario.Sexo);
                cmd.Parameters.AddWithValue("@tipoSanguineo", usuario.TipoSanguineo);
                cmd.Parameters.AddWithValue("@cidade", usuario.Cidade);
                cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                cmd.Parameters.AddWithValue("@dataUltimaDoacao", usuario.DataUltimaDoacao);
                cmd.Parameters.AddWithValue("@statusDoador", usuario.StatusDoador);
                cmd.Parameters.AddWithValue("@aptidao", usuario.Aptidao);
                cmd.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                // registra sempre, mesmo que linhasAfetadas == 0
                try
                {
                    Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Tentativa de atualização do usuário de ID: {usuario.IdUsuario} (Linhas afetadas: {linhasAfetadas})");
                }
                catch (Exception logEx)
                {
                    MessageBox.Show("Erro ao registrar log: " + logEx.Message);
                }

                return linhasAfetadas > 0;

            }
        }

        public bool Delete(int idUsuario)
        {
            string sql = "DELETE FROM usuario WHERE idUsuario = @idUsuario;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                
                bool excluiu = cmd.ExecuteNonQuery() > 0;

                if (excluiu)
                {
                    Logger.Registrar(Sessao.NomeUsuario, Sessao.IdUsuario, $"Exclusão do usuário de ID: {idUsuario}");
                }

                // Executa o comando e retorna se foi bem-sucedido
                return excluiu;
            }
        }

        public bool IsUsuario(string email)
        {
            string sql = "SELECT COUNT(*) FROM usuario WHERE email = @email;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@email", email);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public Usuario ReadByID(int idUsuario)
        {
            string sql = "SELECT * FROM usuario WHERE idUsuario = @idUsuario;";

            using (MySqlConnection conexao = Conexao.CriarNovaConexao())
            using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            IdUsuario = reader.GetInt32("idUsuario"),
                            NomeUsuario = reader.GetString("nomeUsuario"),
                            SenhaUsuario = reader.GetString("senhaUsuario"),
                            Email = reader.GetString("email"),
                            Telefone = reader.GetString("telefone"),
                            DataNascimento = reader.GetDateTime("dataNascimento"),
                            Sexo = reader.GetString("sexo"),
                            TipoSanguineo = reader.GetString("tipoSanguineo"),
                            Cidade = reader.GetString("cidade"),
                            Estado = reader.GetString("estado"),
                            DataUltimaDoacao = reader.GetDateTime("dataUltimaDoacao"),
                            StatusDoador = reader.GetString("statusDoador"),
                            Aptidao = reader.GetString("aptidao")
                        };
                    }
                }
            }
            return null;
        }

        public Usuario Autenticar(string email, string senha)
        {
            MySqlConnection conexao = Conexao.CriarNovaConexao();

            string sql = "SELECT * FROM usuario WHERE email = @email AND senhaUsuario =@senha;";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        IdUsuario = reader.GetInt32("idUsuario"),
                        NomeUsuario = reader.GetString("nomeUsuario"),
                        SenhaUsuario = reader.GetString("senhaUsuario"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        DataNascimento = reader.GetDateTime("dataNascimento"),
                        Sexo = reader.GetString("sexo"),
                        TipoSanguineo = reader.GetString("tipoSanguineo"),
                        Cidade = reader.GetString("cidade"),
                        Estado = reader.GetString("estado"),
                        DataUltimaDoacao = reader.GetDateTime("dataUltimaDoacao"),
                        StatusDoador = reader.GetString("statusDoador"),
                        Aptidao = reader.GetString("aptidao"),
                        NivelAcesso = reader.GetString("nivelAcesso")
                    };

                    Sessao.NomeUsuario = usuario.NomeUsuario;
                    Sessao.IdUsuario = usuario.IdUsuario;
                    Logger.Registrar(usuario.NomeUsuario, usuario.IdUsuario, "Login realizado com sucesso");
                    return usuario;
                }

                Logger.Registrar("Desconhecido", 0, $"Tentativa de login falhou para o email: {email}");
                return null;
            }
        }
    }
   
}
