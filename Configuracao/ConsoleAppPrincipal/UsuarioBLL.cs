﻿
using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            ValidarDados(_usuario);
            //TODO: Validar se já existe um usuário com este nome.

            Usuario usuario = new Usuario();
            usuario = BuscarPorNomeUsuario(_usuario.NomeUsuario);
            if (usuario.NomeUsuario == _usuario.NomeUsuario)
                throw new Exception("Ja existe um usuario com esse nome");


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
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");
            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O nome de usuário não pode conter espaço");

            if (_usuario.Senha.Contains("1234567"))
                throw new Exception("Não é permitido um número sequencial.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
        }
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
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