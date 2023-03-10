using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            ValidarDados(_usuario);
            //TODO: Validar se já existe um usuário com este nome.
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (String.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuário.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }
        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public void Alterar(Usuario _usuario)
        {

        }

        private static void ValidarDados(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
            {
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");
               
            }

            if (_usuario.NomeUsuario.Contains(" "))
            {
                if (_usuario.Senha.Contains("1234567"))
                {
                    throw new Exception("Não é permitido um número sequencial.");
                }

                if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                    throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
            }
            else
            {
                throw new Exception("O nome de usuário não pode conter espaço");
            }
        }
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }
    }
}


/*

namespace BLL
{
    public class UsuarioBLL
    {
        public object NomeUsuario { get; private set; }

        public void Inserir(UsuarioBLL _usuario)
        {
            if (_usuario.NomeUsuario.Length is <= (object)3 or >= (object)50)
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");
            if (_usuario.NomeUsuario.Contains(" "))
            {
                throw new Exception("O nome de usuário não pode conter espaço em branco.");
            }
            else
            {
                if (_usuario.Senha.Contains("1234567"))
                    throw new Exception("Não é permitido um número sequencial.");
                if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                    throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
                //TODO: Validar se já existe um usuário com nome existente.
                UsuarioBLL usuarioDAL = new UsuarioBLL();
                usuarioDAL.Inserir(_usuario);
            }
        }

        public UsuarioBLL Buscar(string _nomeUsuario)
        {
            return new UsuarioBLL();
        }
        public void Alterar(UsuarioBLL _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 100)
                throw new Exception("O nome do usuário deverá conter de 3 a 100 caracteres.");
            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O nome do usuário não pode conter espaço em branco.");
            if (_usuario.Senha.Contains("1234567"))
                throw new Exception("Não é permitido número sequencial.");
            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
            UsuarioBLL usuarioDAL = new UsuarioBLL();
            usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(UsuarioBLL _usuario)
        {
            UsuarioBLL usuarioDAL = new UsuarioBLL();
            usuarioDAL.Excluir(_usuario);
        }
    }
}
*/
