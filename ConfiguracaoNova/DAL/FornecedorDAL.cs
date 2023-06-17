using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedorDAL
    {

        public void Inserir(Fornecedor _fornecedor)

        {


            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Fornecedor(Nome, Fone, Email, Site) VALUES(@Nome, @Fone, @Email, @Site)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@Fone", _fornecedor.Fone);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Site", _fornecedor.Site);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar inserir Fornecedor no banco de dados", ex) { Data = { { "Id", 33 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Fornecedor> BuscarTodos()
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Fone, Email, Site FROM Fornecedor";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Email = rd["Site"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                }
                return fornecedorList;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Fornecedor no banco de dados", ex) { Data = { { "Id", 34 } } };
            }
            finally
            {
                cn.Close();
            }

        }
        public Fornecedor BuscarPorId(int _id)
        {
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Fone, Email, Site FROM fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Site"].ToString();



                    }
                }
                return fornecedor;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Fornecedor por Id  no banco de dados", ex) { Data = { { "Id", 18 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Fone, Email, Site FROM fornecedor WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Site = rd["Site"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                }
                return (List<Fornecedor>)fornecedorList;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar fornecedor por nome  no banco de dados", ex) { Data = { { "Id", 35 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public Fornecedor BuscarPorSite(string _site)
        {
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Fone, Email, Site FROM fornecedor WHERE Site = @Site";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Site", _site);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Site"].ToString();



                    }
                }
                return fornecedor;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Fornecedor por Site  no banco de dados", ex) { Data = { { "Id", 36 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Fornecedor _fornecedor)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Cliente SET Nome = @Nome, Fone = @Fone, Email = @Email, Site = @Site WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;


                cmd.Parameters.AddWithValue("@Id", _fornecedor.Id);
                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@Fone", _fornecedor.Fone);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Site", _fornecedor.Site);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar fornecedor no banco de dados ", ex) { Data = { { "Id", 37 } } };
            }
            finally
            {
                cn.Close();
            }

        }
        public void Excluir(int _id)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Fornecedor WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir fornecedor no banco de dados ", ex) { Data = { { "Id", 38 } } };
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
