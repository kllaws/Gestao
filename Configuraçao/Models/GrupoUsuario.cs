

using System.Collections.Generic;

namespace Models
{
    public class GrupoUsuario
    {
        public int id;

        public string NomeGrupo { get; set; }
        public List<Permissao> Permissao { get; set; }
    }
}
