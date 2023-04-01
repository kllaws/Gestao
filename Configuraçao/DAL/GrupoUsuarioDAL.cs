using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace DAL
{
    public class GrupoUsuarioDAL
    {
        private GrupoUsuario grupousuario;
        private SqlTransaction _transaction;
        private object _idGrupoUsuario;
        private object _transation;
        private object _RemoverTodasPermissoes;

        public void Inserir(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO GrupoUsuario(GrupoUsuario) VALUES (@NomeGrupo)";
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
        public GrupoUsuario Buscar(GrupoUsuario grupousuario)
        {
            return new GrupoUsuario();
        }
        public void Alterar(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE GrupoUsuario SET NomeGrupo = @NomeGrupo WHERE Id = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupousuario.NomeGrupo);
                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Excluir(int _idGrupoUsuario, SqlTransaction _transation = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELET FROM GrupoUsuario WHERE id =@id", cn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", _idGrupoUsuario);
                    try
                    {
                        if (_transation == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        RemoverTodasPermissoes(_idGrupoUsuario, transaction);
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar excluir o Grupo de usuário no banco de dados" + ex.Message);
                    }
                }
            }

        }
        /*
                   public void Excluir(int idGrupoUsuario)
                   {
                       SqlConnection cn = new SqlConnection();
                       try
                       {
                           cn.ConnectionString = Conexao.StringDeConexao;
                           SqlCommand cmd = new SqlCommand();
                           cmd.CommandText = @"DELETE FROM GrupoUsuario WHERE Id = @Id";
                           cmd.CommandType = System.Data.CommandType.Text;
                           cmd.Parameters.AddWithValue("@Id", idGrupoUsuario);

                           cmd.Connection = cn;
                           cn.Open();
                           cmd.ExecuteNonQuery();
                       }
                       catch (Exception ex)
                       {

                           throw new Exception("Ocorreu um erro ao tentar excluir o grupo de usuario no banco: " + ex.Message);
                       }
                       finally
                       {
                           cn.Close();
                       }
                   }

                   */

        private void RemoverTodasPermissoes(int _idGrupoUsuario, SqlTransaction _transaction)
        {

            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELET FROM RemoverTodasPermissoes WHERE id =@id", cn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", _RemoverTodasPermissoes);
                    try
                    {
                        if (_transation == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        RemoverTodasPermissoes(_idGrupoUsuario, transaction);
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar excluir o Grupo de usuário no banco de dados" + ex.Message);
                    }
                }
            }

        }



        public List<GrupoUsuario> ExibirTodosGrupos()
                    {
                        SqlConnection cn = new SqlConnection();
                        List<GrupoUsuario> listaGrupoUsuario = new List<GrupoUsuario>();
                        try
                        {
                            cn.ConnectionString = Conexao.StringDeConexao;
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = cn;

                            cn.Open();
                            SqlDataReader dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                GrupoUsuario grupoUsuario = new GrupoUsuario();
                                grupoUsuario.IdGrupoUser = Convert.ToInt32(dr["Id"]);
                                grupoUsuario.NomeGrupo = dr["NomeGrupo"].ToString();
                                listaGrupoUsuario.Add(grupoUsuario);
                            }
                            return listaGrupoUsuario;

                        }
                        catch (Exception ex)
                        {

                            throw new Exception("Ocorreu um erro ao tentar buscar todos os grupos de usuario no banco: " + ex.Message);
                        }
                        finally
                        {
                            cn.Close();
                        }
                    }
                    public GrupoUsuario BuscarGrupoPorNome(String _nome)
                    {
                        GrupoUsuario grupoUsuario = new GrupoUsuario();
                        SqlConnection cn = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();

                        try
                        {
                            cn.ConnectionString = Conexao.StringDeConexao;
                            cmd.Connection = cn;
                            cmd.CommandText = "SELECT Id, NomeGrupo FROM GrupoUsuario WHERE NomeGrupo = @NomeDoGrupo";
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.Parameters.AddWithValue("@NomeGrupo", _nome);
                            cn.Open();
                            using (SqlDataReader rd = cmd.ExecuteReader())
                            {
                                if (rd.Read())
                                {
                                    grupousuario = new GrupoUsuario();
                                    grupousuario.IdGrupoUser = Convert.ToInt32(rd["Id"]);
                                    grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();

                                }
                                else
                                {
                                    throw new Exception("Grupo de usuario nao encontrado.");

                                }
                                return grupoUsuario;
                            }

                        }
                        catch (Exception ex)
                        {

                            throw new Exception("ocorreu um erro ao tentar buscar o grupo de usuario no banco: " + ex.Message);
                        }
                    }

                    public List<GrupoUsuario> BuscarPorIdUsuario(int _idGrupo)
                    {
                        List<GrupoUsuario> listaGrupoUsuario = new List<GrupoUsuario>();
                        GrupoUsuario grupoUsuario = new GrupoUsuario();

                        SqlConnection cn = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        try
                        {
                            cn.ConnectionString = Conexao.StringDeConexao;
                            cmd.Connection = cn;
                            cmd.CommandText = @"SELECT TOP 100 Id, GrupoUsuario FROM GrupoUsuario WHERE Id = @Id";
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.Parameters.AddWithValue("@Id", _idGrupo);

                            cn.Open();

                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                grupoUsuario = new GrupoUsuario();
                                grupoUsuario.IdGrupoUser = Convert.ToInt32(dr["Id"]);
                                grupoUsuario.NomeGrupo = dr["NomeGrupo"].ToString();
                                listaGrupoUsuario.Add(grupoUsuario);
                            }
                            return listaGrupoUsuario;

                        }
                        catch (Exception ex)
                        {

                            throw new Exception("Ocorreu um erro ao tentar buscar o grupo de usuario no banco: " + ex.Message);
                        }
                        finally
                        {
                            cn.Close();
                        }

                    }
    }
}
        
             
