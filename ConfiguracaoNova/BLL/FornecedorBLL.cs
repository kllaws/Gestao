using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class FornecedorBLL
    {

        public void Inserir(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Inserir(_fornecedor);
        }
        public List<Fornecedor> BuscarTodos()
        {
            return new FornecedorDAL().BuscarTodos();
        }
        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            return new FornecedorDAL().BuscarPorNome(_nome);
        }
        public Fornecedor BuscarPorId(int _id)
        {
            return new FornecedorDAL().BuscarPorId(_id);
        }
        public List<Fornecedor> BuscarPorSite(string _site)
        {
            return new FornecedorDAL().BuscarPorNome(_site);
        }

        public void Alterar(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Alterar(_fornecedor);
        }
        public void Excluir(int _id)
        {
            new FornecedorDAL().Excluir(_id);
        }
    }
}
