using ConsoleAppPrincipal;

namespace BLL
{
    public class GrupoUsuarioBLLBase
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
    }
}