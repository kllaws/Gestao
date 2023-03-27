using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO GrupoUsuario(NomeGrupo) VALUES (@NomeGrupo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupousuario.NomeGrupo);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o nome do grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> BuscarPorIdUsuario(int _idGrupousuario)
        {
            List<GrupoUsuario> grupos = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT GrupoUsuario.IdGrupoUsuario, GrupoUsuario.NomeGrupo FROM GrupoUsuario 
                                    INNER JOIN UsuarioGrupoUsuario ON GrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.Id_GrupoUsuario 
                                    WHERE Id_Usuario = @IdGrupoUsuario";
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupousuario);
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.IdGrupoUsuario = Convert.ToInt32(rd["IdGrupoUsuario"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        PermissaoDAL permissaoDAL = new PermissaoDAL();
                        grupoUsuario.Permissoes = permissaoDAL.BuscarPorIdGrupo(grupoUsuario.IdGrupoUsuario);
                        grupos.Add(grupoUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar listar grupo." + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return grupos;
        }
        public List<GrupoUsuario> BuscarGrupoPorNome(string _nomeGrupo)
        {
            List<GrupoUsuario> grupo_nomes = new List<GrupoUsuario>();
            GrupoUsuario grupo = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdGrupoUsuario, NomeGrupo FROM GrupoUsuario " +
                    "               WHERE NomeGrupo like @NomeGrupo order by NomeGrupo";
                cmd.Parameters.AddWithValue("@NomeGrupo", "%" + _nomeGrupo + "%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupo = new GrupoUsuario();
                        grupo.IdGrupoUsuario = Convert.ToInt32(rd["IdGrupoUsuario"]);
                        grupo.NomeGrupo = rd["NomeGrupo"].ToString();
                        PermissaoDAL permissaoDAL = new PermissaoDAL();
                        grupo.Permissoes = permissaoDAL.BuscarPorIdGrupo(grupo.IdGrupoUsuario);

                        grupo_nomes.Add(grupo);
                    }
                }
                return grupo_nomes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Nome do Grupo: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> BuscarTodosGrupos()
        {
            List<GrupoUsuario> grupo_usuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDGrupoUsuario, NomeGrupo FROM GrupoUsuario order by NomeGrupo";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.IdGrupoUsuario = Convert.ToInt32(rd["IdGrupoUsuario"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        PermissaoDAL permissaoDAL = new PermissaoDAL();
                        grupousuario.Permissoes = new PermissaoDAL().BuscarPorIdGrupo(grupousuario.IdGrupoUsuario);
                        grupo_usuarios.Add(grupousuario);
                    }
                }
                return grupo_usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Grupo de Usuarios: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE GrupoUsuario SET NomeGrupo = @NomeGrupo 
                                    WHERE IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _grupousuario.IdGrupoUsuario);
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupousuario.NomeGrupo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar o nome do grupo no banco: " + ex.Message);
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
                cmd.CommandText = @"DELETE FROM PermissaoGrupoUsuario WHERE IDGrupoUsuario = @IDGrupoUsuario
                                    DELETE FROM UsuarioGrupoUsuario WHERE Id_GrupoUsuario = @IDGrupoUsuario
                                    DELETE FROM GrupoUsuario WHERE IDGrupoUsuario = @IDGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDGrupoUsuario", _id);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir o grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> BuscarPorId(int idGrupoUsuario)
        {
            List<GrupoUsuario> grupo_usuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDGrupoUsuario, NomeGrupo FROM GrupoUsuario 
                                    WHERE IDGrupoUsuario = @IDGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDGrupoUsuario", idGrupoUsuario);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.IdGrupoUsuario = Convert.ToInt32(rd["IdGrupoUsuario"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        PermissaoDAL permissaoDAL = new PermissaoDAL();
                        grupousuario.Permissoes = permissaoDAL.BuscarPorIdGrupo(grupousuario.IdGrupoUsuario);

                        grupo_usuarios.Add(grupousuario);
                    }
                }
                return grupo_usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Grupo de Usuarios: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}