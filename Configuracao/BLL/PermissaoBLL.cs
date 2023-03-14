using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppPrincipal;

namespace BLL
{
    internal class PermissaoBLL
    {
        public Usuario Buscar(string _nomeUsuario)
        {

            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"FROM TABLE Permissao SET Descricao = @Descricao WHERE IdDescricao = @IdDescricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _usuario.IdDescricao);
                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar uma descrição no banco: " + ex.Message);
            }
            finally

            {
                cn.Close();
            }
            return new Usuario();
        }
        public void Alterar(Usuario _usuario)
        {

            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE Permissao SET Descricao = @Descricao WHERE IdDescricao = @IdDescricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _usuario.IdDescricao);
                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar uma descrição no banco: " + ex.Message);
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
                cmd.CommandText = @"DELETE FROM Permissao WHERE IdDescricao = @IdDescricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _usuario.IdDescricao);
                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma descrição no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        internal void Excluir(Permissao permissao)
        {
            throw new NotImplementedException();
        }

        internal void Alterar(Permissao permissao)
        {
            throw new NotImplementedException();
        }

        internal void Inserir(Permissao permissao)
        {
            throw new NotImplementedException();
        }

        internal Permissao BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
