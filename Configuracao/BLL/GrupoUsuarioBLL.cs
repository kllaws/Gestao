﻿using ConsoleAppPrincipal;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public static void Inserir(GrupoUsuario GrupoUsuario)
        {
            if (GrupoUsuario.NomeGrupo.Length <= 15 || GrupoUsuario.NomeGrupo.Length >= 100)
            {
                throw new Exception("O nome do grupo do grupo deve ter entre 15 e 100 caracteres.");
            }

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Inserir(GrupoUsuario);
        }

        public static void Alterar(GrupoUsuario GrupoUsuario)
        {
            if (GrupoUsuario.NomeGrupo.Length <= 15 || GrupoUsuario.NomeGrupo.Length >= 100)
            {
                throw new Exception("O nome do grupo do grupo deve ter entre 15 e 100 caracteres.");
            }

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.ALterar(GrupoUsuario);
        }

        public void Excluir(int _IdGrupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Excluir(_IdGrupoUsuario);
        }
        public static GrupoUsuario BuscarPorID(int IdGrupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarPorID(IdGrupoUsuario);
        }

        public static List<GrupoUsuario> GetBuscarTodosGrupos()
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarTodosGrupos();
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
