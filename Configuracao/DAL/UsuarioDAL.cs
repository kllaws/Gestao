

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
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO Usuario(Nome, NomeUsuario, CPF, Email, Senha, Ativo) 
                                    VALUES(@Nome, @NomeUsuario, @CPF, @Email, @Senha, @Ativo)";

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
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, Email, Ativo
                                    FROM Usuario WHERE NomeUsuario = @NomeUsuario";

                cmd.Parameters.AddWithValue("@NomeUsuario", _nomeUsuario);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.ID = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = rd["Ativo"].ToString();
                       // usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar fazer busca de usuário por Nome de Usuário: " + ex.Message);
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

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, Email, Ativo, NomeUsuario 
                                    FROM Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.ID = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = rd["Ativo"].ToString();
                       // usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);

                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIDUsuario(usuario.ID);
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message);
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
                cmd.CommandText = @"UPDATE Usuario SET Nome = @Nome, NomeUsuario = @NomeUsuario, CPF = @CPF, Email = @Email, 
                                    Senha = @Senha, Ativo = @Ativo 
                                    WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Parameters.AddWithValue("@Id", _usuario.ID);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar um usuário no banco: " + ex.Message);
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
                cmd.CommandText = @"DELETE FROM Usuario WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BuscarPorId(int _id)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, Email, Ativo, NomeUsuario
                                    FROM Usuario WHERE Id = @Id";

                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario
                        {
                            ID = Convert.ToInt32(rd["Id"]),
                            Nome = rd["Nome"].ToString(),
                            NomeUsuario = rd["NomeUsuario"].ToString(),
                            CPF = rd["CPF"].ToString(),
                            Email = rd["Email"].ToString(),
                            Ativo = rd["Ativo"].ToString(),
                            //Ativo = Convert.ToBoolean(rd["Ativo"])
                        };
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar fazer busca de usuário por Nome de Usuário: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}







/*using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"Insert into Usuario(Nome, NomeUsuario, CPF, Email, Senha, Ativo) 
                                    Values(@Nome,@NomeUsuario,@CPF,@Email,@Senha,@Ativo)";

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
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco de dados: " + ex.Message);
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
                cmd.CommandText = @"UPDATE Usuario SET Nome = @Nome, NomeUsuario = @NomeUsuario, CPF = @CPF, Email = @Email, Senha = @Senha, Ativo = @Ativo WHERE ID= @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Parameters.AddWithValue("@IdUsuario", _usuario.ID);

                cn.Open();
                cmd.BeginExecuteNonQuery();

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
                cmd.CommandText = @"DELETE FROM Usuario WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

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

        public List<Usuario> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection();
            Usuario usuario;
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, NomeUsuario, Email, CPF, Ativo from Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario
                        {
                            ID = Convert.ToInt32(rd["ID"]),
                            Nome = rd["Nome"].ToString(),
                            NomeUsuario = rd["NomeUsuario"].ToString(),
                            Email = rd["Email"].ToString(),
                            CPF = rd["CPF"].ToString(),
                            Ativo = Convert.ToBoolean(rd["Ativo"])
                        };
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIDUsuario(usuario.ID);
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"Select ID, Nome, NomeUsuario, CPF, Email, Ativo
                                   From Usuario Where NomeUsuario = @NomeUsuario";

                cmd.Parameters.AddWithValue("@NomeUsuario", _nomeUsuario);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.ID = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar usuário: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}*/
