using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class UsuarioBLL
    {
        public object BLL { get; set; }

        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDados(_usuario, _confirmacaoDeSenha);
           
            


            // TODO: Validar se já existe um usuário com nome existente.
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }

        private void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception(" O nome do usuário deve ter mais de três caracteres. ");
            if (_usuario.NomeUsuario.Contains(" "))
            {
                throw new Exception(" O nome do usuário não pode conter espaço em branco. ");
            }
            if (_usuario.Senha.Contains(" 1234567 "))
            {
                throw new Exception(" Não é permitido um número sequencial. ");
            }
            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
            {
                throw new Exception(" A senha deve ter entre 7 e 11 caracteres. ");

            }
            if(_confirmacaoDeSenha != _usuario.Senha)
                throw new Exception("O campo senha e a confirmaçao de senha nao sao iguais");
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (String.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuario. ");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }

      
            
        private static void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
        }
        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public void Alterar (Usuario _usuario, string _confirmacaoDeSenha)
        {

        }
       
    }
}