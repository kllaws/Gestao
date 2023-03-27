using BLL;
using ConsoleAppPrincipal;

internal static class PermissaoBLLHelpers
{
        public static void Alterar(Permissao Permissao)
        {
            if (Permissao.Descricao.Length <= 30 || Permissao.Descricao.Length >= 250)
            {
                throw new Exception("A descrição deve ter entre 30 e 250 caracteres.");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(Permissao);
        }
    public static void Inserir(Permissao Permissao)
    {
        if (Permissao.Descricao.Length <= 30 || Permissao.Descricao.Length >= 250)
        {
            throw new Exception("A descrição deve ter entre 30 e 250 caracteres.");
        }

        PermissaoDAL permissaoDAL = new PermissaoDAL();
        permissaoDAL.Inserir(Permissao);
    }
}