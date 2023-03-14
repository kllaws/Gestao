
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        private object _usuario;

        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();

            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close(); 
            }

        }
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
                cmd.Parameters.AddWithValue("@IdDescricao", _usuario.IDDescricao);
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
        public void Alterar (Usuario _usuario)
        {

            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE Permissao SET Descricao = @Descricao WHERE IdDescricao = @IdDescricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _usuario.IDDescricao);
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
        public void Excluir (int _id)
        {

            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM Permissao WHERE IdDescricao = @IdDescricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _usuario.IDDescricao);
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


    }
}