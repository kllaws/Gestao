using System;
using System.Collections.Generic;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeUsuario { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public List<GrupoUsuario> GrupoUsuarios { get; set; }
<<<<<<< HEAD
=======
        public int IDUsuario { get; set; }
>>>>>>> 4a37f5e2fc1a1e69d5ef6830c1e758d793309b3a

        
    }
}