using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"Insert into GrupoUsuario(NomeGrupo)
                                    Values(@NomeGrupo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("NomeGrupo", _grupoUsuario.NomeGrupo);

                cn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um grupo de usuários no banco de dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void ALterar(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"update GrupoUsuario set NomeGrupo = @NomeGrupo where IdGrupoUsuario = @IdGrupoUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoUsuario.NomeGrupo);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _grupoUsuario.IdGrupoUsuario);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar o nome do grupo no banco de dados: " + ex.Message);
            }
        }

        public void Excluir(int _IdGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"delete from GrupoUsuario where IdGrupoUsuario = @IdGrupoUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _IdGrupoUsuario);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a permissao no banco de dados: " + ex.Message);
            }
        }

        public GrupoUsuario BuscarPorID(int _idGrupoUsuario)
        {
            GrupoUsuario grupo = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"Select TOP 100 IdGrupoUsuario, NomeGrupo from GrupoUsuario where IdGrupoUsuario = @IdGrupoUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupo = new GrupoUsuario();
                        grupo.IdGrupoUsuario = Convert.ToInt32(rd["IdGrupoUsuario"]);
                        grupo.NomeGrupo = rd["NomeGrupo"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar grupo" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return grupo;
        }

        public List<GrupoUsuario> BuscarPorIDUsuario(int _IdUsuario)
        {
            SqlConnection cn = new SqlConnection();
            GrupoUsuario grupoUsuario;
            List<GrupoUsuario> grupos = new List<GrupoUsuario>();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT GrupoUsuario.IdGrupoUsuario, GrupoUsuario.NomeGrupo From GrupoUsuario inner join UsuarioGrupoUsuario on GrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.Cod_GrupoUsuario where UsuarioGrupoUsuario.Cod_Usuario = @Cod_Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Cod_Usuario", _IdUsuario);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.IdGrupoUsuario = Convert.ToInt32(rd["IdGrupoUsuario"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();

                        grupos.Add(grupoUsuario);
                    }
                }
                return grupos;
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

        public List<GrupoUsuario> BuscarTodosGrupos()
        {
            SqlConnection cn = new SqlConnection();
            GrupoUsuario grupoUsuario;
            List<GrupoUsuario> grupos = new List<GrupoUsuario>();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdGrupoUsuario, NomeGrupo From GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.IdGrupoUsuario = Convert.ToInt32(rd["IdGrupoUsuario"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();

                        grupos.Add(grupoUsuario);
                    }
                }
                return grupos;
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


    }
}
