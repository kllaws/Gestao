using DAL;
using Models;
using System.Security.Cryptography.X509Certificates;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            ValidarDados(_usuario);
            //TODO: Validar se ja existe um usuario com este nome.
            UsuarioDAL usuarioDAL = new UsuarioDAL();
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (string.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("informe o nome do usuario.");

            UsuarioDAL _usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }
        public List<Usuario> BUscarTodos()
        {
            Public void Alterar(Usuario _usuario)

        }


        private void ValidarDados(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }

}





/*
namespace ConsoleAppPrincipal
{
    internal class UsuarioBLL
    {
        internal List<Usuario> BuscarTodos()
        {
            throw new Exception();
        }

        internal void Inserir(Usuario usuario)
        {
            throw new Exception();
        }
    }
}*/