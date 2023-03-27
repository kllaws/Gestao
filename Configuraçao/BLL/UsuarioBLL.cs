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
            ValidarPermissao(1);

            ValidarDados(_usuario, _confirmacaoDeSenha);

            Usuario usuario = new Usuario();

            usuario = BuscarUsuarioPorNome(_usuario.NomeUsuario);
            if (usuario.NomeUsuario == _usuario.NomeUsuario)
                throw new Exception("Usuário já existente");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void ValidarPermissao(int _idDescricao)
        {
            if (!new UsuarioDAL().ValidarPermissao(Constantes.IdUsuarioLogado, _idDescricao))
                throw new Exception("Você não tem permissão para executar esta operação");
        }
        private void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");

            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O nome de usuário não pode conter espaço em branco.");

            if (_usuario.Senha.Contains("1234567"))
                throw new Exception("Não é permitido um número sequencial.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");

            if (_confirmacaoDeSenha != _usuario.Senha)
                throw new Exception("O campo senha e a confirmação da senha não são iguais.");
        }
        public Usuario BuscarUsuarioPorNome(string _nomeUsuario)
        {
            ValidarPermissao(4);
            if (String.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuário.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarUsuarioPorNome(_nomeUsuario);
        }
        public List<Usuario> BuscarTodos()
        {
            ValidarPermissao(4);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public Usuario BuscarPorId(int _idUsuario)
        {
            ValidarPermissao(4);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorId(_idUsuario);
        }
        public void Alterar(Usuario _alterarUsuario, string _confirmacaoDeSenha)
        {
            ValidarPermissao(2);
            ValidarDados(_alterarUsuario, _confirmacaoDeSenha);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_alterarUsuario);
        }
        public void Excluir(int _id)
        {
            ValidarPermissao(3);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }
        public void AdicionarGrupo(int _idUsuario, int _idGrupoUsuario)
        {
            ValidarPermissao(10);
            if (new UsuarioDAL().ExisteRelacionamento(_idUsuario, _idGrupoUsuario))
            {
                throw new Exception("Usuário já vinculado ao grupo.");
            }
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.AdicionarGrupo(_idUsuario, _idGrupoUsuario);
        }
        public void RemoverGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            ValidarPermissao(7);
            new UsuarioDAL().RemoverGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }
    }
}