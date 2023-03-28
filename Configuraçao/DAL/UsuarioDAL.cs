using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();//cn é um objeto de conexao
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO Usuario(Nome, NomeUsuario, CPF, Email, Senha, Ativo)
                                    VALUES (@Nome, @NomeUsuario, @CPF, @Email, @Senha, @Ativo)";//com o arroba ele aceita a quebra de linha
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            //SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);//dessa forma também funciona
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdUsuario, Nome, NomeUsuario, CPF, Email, Ativo FROM Usuario order by IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdUsuario((int)usuario.IdUsuario);

                        usuarios.Add(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return usuarios;
        }
        public Usuario BuscarPorId(int idUsuario)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Usuario usuario = new Usuario();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdUsuario, Nome, NomeUsuario, CPF, Email, Ativo 
                                    FROM Usuario WHERE IdUsuario = @IdUsuario";
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdUsuario((int)usuario.IdUsuario);
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um usuário: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario BuscarUsuarioPorNome(string _nomeUsuario)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Usuario usuario = new Usuario();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdUsuario, Nome, NomeUsuario, CPF, Email, Ativo 
                                    FROM Usuario WHERE NomeUsuario like @NomeUsuario order by Nome";
                cmd.Parameters.AddWithValue("@NomeUsuario", "%" + _nomeUsuario + "%");
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdUsuario((int)usuario.IdUsuario);
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um usuário: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE Usuario SET Nome = @Nome, NomeUsuario = @NomeUsuario, CPF = @CPF, Email = @Email, Senha = @Senha, Ativo = @Ativo WHERE IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Parameters.AddWithValue("@IdUsuario", _usuario.IdUsuario);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar o cadastro de usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM UsuarioGrupoUsuario WHERE Id_Usuario = @IDUsuario
                                    DELETE FROM Usuario WHERE IDUsuario = @IDUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDUsuario", _id);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir o usuário no banco de dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AdicionarGrupo(int idUsuario, int idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO UsuarioGrupoUsuario(Id_Usuario, Id_GrupoUsuario) 
                                    VALUES (@Id_Usuario, @Id_GrupoUsuario)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                cmd.Parameters.AddWithValue("@Id_GrupoUsuario", idGrupoUsuario);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void RemoverGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Usuario usuario = new Usuario();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM  UsuarioGrupoUsuario 
                                    WHERE Id_Usuario = @Id_Usuario 
                                    AND Id_GrupoUsuario = @Id_GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Usuario", _idUsuario);
                cmd.Parameters.AddWithValue("@Id_GrupoUsuario", _idGrupoUsuario);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um grupo: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool ExisteRelacionamento(int idUsuario, int idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS Retorno FROM  UsuarioGrupoUsuario 
                                    WHERE Id_Usuario = @Id_Usuario and Id_GrupoUsuario = @Id_GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                cmd.Parameters.AddWithValue("@Id_GrupoUsuario", idGrupoUsuario);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um usuário: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool ValidarPermissao(int _idUsuario, int _idDescricao)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Usuario usuario = new Usuario();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT TOP 1 1 AS Resultado FROM UsuarioGrupoUsuario
                                    INNER JOIN PermissaoGrupoUsuario 
                                        ON UsuarioGrupoUsuario.Id_GrupoUsuario = PermissaoGrupoUsuario.IDGrupoUsuario
                                    WHERE UsuarioGrupoUsuario.Id_Usuario = @Id_Usuario
                                        AND PermissaoGrupoUsuario.Id_Descricao = @Id_Descricao";
                cmd.Parameters.AddWithValue("@Id_Usuario", _idUsuario);
                cmd.Parameters.AddWithValue("@Id_Descricao", _idDescricao);
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar validar permissão do usuário no banco de dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BuscarPorNomeUsuario(string nomeUsuario)
        {
            throw new NotImplementedException();
        }
    }
}