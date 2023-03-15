using ConsoleAppPrincipal;

namespace BLL
{
    public class PermissaoBLL
    {
        public static void Inserir(Permissao Permissao)
        {
            if (Permissao.Descricao.Length <= 30 || Permissao.Descricao.Length >= 250)
            {
                throw new Exception("A descrição deve ter entre 30 e 250 caracteres.");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(Permissao);
        }

        public static void Alterar(Permissao Permissao)
        {
            if (Permissao.Descricao.Length <= 30 || Permissao.Descricao.Length >= 250)
            {
                throw new Exception("A descrição deve ter entre 30 e 250 caracteres.");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(Permissao);
        }

        public void Excluir(int _IdDescricao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Excluir(_IdDescricao);
        }

        public static List<Permissao> BuscarPorIDDescricao(int IdDescricao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarPorIDDescricao(IdDescricao);
        }


    }
}
