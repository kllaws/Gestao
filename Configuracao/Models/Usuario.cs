namespace Models
{
    public class Usuario
    {

        public string? Nome { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Ativo { get; set; }
        public List<GrupoUsuario> GrupoUsuarios { get; set; }



    }
}