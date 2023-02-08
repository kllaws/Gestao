using System;
using System.ComponentModel;

namespace Models
{
    public class Permissao
    {

        public string Descricao { get; set; }
       public List<GrupoUsuario> GrupoUsuario { get; set; }

    }
}
