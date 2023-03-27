using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupousuario)
        {
            new UsuarioBLL().ValidarPermissao(1);
            if (_grupousuario.NomeGrupo.Length <= 3 || _grupousuario.NomeGrupo.Length >= 150)
                throw new Exception("O nome do grupo deverá conter de 3 a 150 caracteres.");

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Inserir(_grupousuario);
        }
        public List<GrupoUsuario> BuscarPorId(int _idGrupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(8);
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarPorId(_idGrupoUsuario);
        }
        public List<GrupoUsuario> BuscarTodosGrupos()
        {
            new UsuarioBLL().ValidarPermissao(8);
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarTodosGrupos();
        }
        public List<GrupoUsuario> BuscarGrupoPorNome(string _nomeGrupo)
        {
            new UsuarioBLL().ValidarPermissao(8);
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarGrupoPorNome(_nomeGrupo);
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(6);
            if (_grupoUsuario.NomeGrupo.Length <= 3 || _grupoUsuario.NomeGrupo.Length >= 150)
                throw new Exception("O nome do grupo deverá conter de 3 a 150 caracteres.");

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Alterar(_grupoUsuario);
        }
        public void Excluir(int _idgrupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(3);
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Excluir(_idgrupoUsuario);
        }
        public void RemoverDescricaoGrupo(int _idgrupoUsuario, int _idDescricao)
        {
            new PermissaoDAL().RemoverDescricaoGrupo(_idgrupoUsuario, _idDescricao);
        }
    }
}
