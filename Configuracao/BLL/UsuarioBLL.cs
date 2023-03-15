using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDados(_usuario, _confirmacaoDeSenha);

            Usuario usuario = new Usuario();
            usuario = BuscarPorNomeUsuario(_usuario.NomeUsuario);
            if (usuario.NomeUsuario == _usuario.NomeUsuario)
                throw new Exception("Já existe um usuário com este nome");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }

        private Usuario BuscarPorNomeUsuario(object nomeUsuario)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (String.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuário.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }
        public Usuario BuscarPorId(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorId(_id);
        }
        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public void Alterar(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDados(_usuario, _confirmacaoDeSenha);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);
        }
        private static void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
            {
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");
            }

            if (_usuario.NomeUsuario.Contains(" "))
            {
                throw new Exception("O nome de usuário não pode conter espaço");
            }

            if (_usuario.Senha.Contains("1234567"))
            {
                throw new Exception("Não é permitido um número sequencial.");
            }

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");

            if (_confirmacaoDeSenha != _usuario.Senha)
                throw new Exception("O campo senha e a confirmação de senha não são iguais.");
        }
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }
    }
}






/*namespace BLL
{
    public class UsuarioBLL
    {
        private static void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            //Todo: Validar se a senha é maior que 50 ou menor que 3 e se contém espaço
            if (_usuario.NomeUsuario.Length is <= (object)3 or >= (object)50)
            {
                throw new Exception("O nome de usuário deve ter entre 3 e 50 caracteres.");
            }
            else
            {
                if (_usuario.NomeUsuario.Contains(" "))
                {
                    //Todo: Validar se a senha é maior que 11 ou menor que 7
                    if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                    {
                        throw new Exception("A senha deve ter entre 7 e 12 caracteres.");
                    }

                    //Todo: Validar se a senha não é 1234
                    if (_usuario.Senha.Contains("1234567"))
                    {
                        throw new Exception("Não é permitido números em sequência.");
                    }
                    else
                    {
                        //Validar se as senhas são iguais
                        if (_confirmacaoDeSenha != _usuario.Senha)
                        {
                            throw new Exception("O campo senha e a confirmação de senha não são iguais");
                        }
                    }
                }
                else
                {
                    throw new Exception("O nome de usuário não pode conter espaços.");
                }
            }
        }

        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {

            //Todo: Validar se já existe um usuário com este nome.
            ValidarDados(_usuario, _confirmacaoDeSenha);

            Usuario usuario = new Usuario();
            usuario = BuscarPorNomeUsuario(_usuario.NomeUsuario);
            if (usuario.NomeUsuario == _usuario.NomeUsuario)
            {
                throw new Exception("Já existe um usuário com este nome");
            }

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }

        private Usuario BuscarPorNomeUsuario(object nomeUsuario)
        {
            throw new Exception();
        }

        public void Alterar(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDados(_usuario, _confirmacaoDeSenha);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);
        }

        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }

        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (String.IsNullOrEmpty(_nomeUsuario))
            {
                throw new Exception("Informe o nome do usuário.");
            }

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }
    }
}*/