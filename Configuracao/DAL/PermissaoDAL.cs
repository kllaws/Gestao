
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"Insert into Permissao(Descricao)
                                  Values(@Descricao)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);

                cn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma permissão no banco de dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"update Permissao set Descricao = @Descricao where IdDescricao = @IdDescricao ";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);
                cmd.Parameters.AddWithValue("@IdDescricao", _permissao.IdDescricao);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar a permissao no banco de dados: " + ex.Message);
            }
        }


        public void Excluir(int _IdDescricao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"delete from Permissao where IdDescricao = @IdDescricao";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _IdDescricao);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a permissao no banco de dados: " + ex.Message);
            }
        }


        public List<Permissao> BuscarPorIDDescricao(int _IdDescricao)
        {
            SqlConnection cn = new SqlConnection();
            Permissao permissao;
            List<Permissao> permissoes = new List<Permissao>();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao.IdDescricao, Permissao.Descricao from Permissao inner join PermissaoGrupoUsuario on Permissao.IdDescricao = PermissaoGrupoUsuario.Cod_GrupoUsuario where Permissao.IdDescricao = @Cod_Descricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Cod_Descricao", _IdDescricao);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.IdDescricao = Convert.ToInt32(rd["IdDescricao"]);
                        permissao.Descricao = rd["Descricao"].ToString();

                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as permissões: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

    }

}
