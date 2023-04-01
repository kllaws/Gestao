

using System.Collections.Generic;

namespace Models
{
    public class GrupoUsuario
    {
        public int id;

        public string NomeGrupo { get; set; }
        public List<Permissao> Permissao { get; set; }
        public int IdGrupoUser { get; set; }
        public int IdGrupoUsuario { get; set; }
        public List<Permissao> Permissoes { get; set; }
    }
}
