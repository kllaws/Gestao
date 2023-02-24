using Models;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;

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
                cmd.Parameters.AddWithValue("@CPF", _usuario.Cpf);
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
            return new Usuario();//para solucionar o erro de vazio.
        }
        public static List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection();
            
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME, CPF, Email, Ativo FROM Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["id"]);
                        usuario.Nome = rd["nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Email = rd["email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);

                        usuario.Add(usuario);
                    }

                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(String.Format("Ocorreu o seguinte erro: {0} ao tentar buscar no banco, o numero do erro e {1}", ex.Message, 154));
                //Console.WriteLine($"Ocorreu o seguinte erro: {ex.Message} ao tentar buscar no banco o numero do erro");
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuarios: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return usuarios;
        }
        public void Alterar(Usuario usuario)
        {

        }
       // public void  Excluir(int _Id);
        public void Excluir(Usuario _IdUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                //cmd.Parameters.AddWithValue("@IdUsuario", _IdUsuario.);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public void Change(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
