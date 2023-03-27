using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Models
{
    public class Permissao
    {
        public object IdDescricao;

        public string Descricao { get; set; }
       public List<GrupoUsuario> GrupoUsuario { get; set; }

    }
}
