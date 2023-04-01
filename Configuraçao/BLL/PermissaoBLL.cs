using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        public List<Permissao> BuscarPermissaoPorNome(string _nomePermissao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarPermissaoPorNome(_nomePermissao);
        }
        public void AdicionarPermissao(int _idPermissao, int _id)
        {
            new UsuarioBLL().ValidarPermissao(9);
            if (new PermissaoDAL().ExistirRelacionamento(_idPermissao, _id))
            {
                throw new Exception("Permissão já vinculada a Descrição.");
            }
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.AdicionarPermissao(_idPermissao, _id);
        }
    }
}