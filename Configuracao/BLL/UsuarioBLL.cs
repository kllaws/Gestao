﻿using DAL ;
using  Models ;
using System;
using System.Linq;

namespace BLL
{
    public class UsuárioBLL
    {
        public void Inserir(Usuario _usuario)
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
            // TODO: Validar se já existe um usuário com nome existente.
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
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

    }
}