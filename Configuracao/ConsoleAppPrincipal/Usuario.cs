namespace ConsoleAppPrincipal
{
    internal class Usuario
    {
        public int IDUsuario { get; internal set; }
        public string? Nome { get; internal set; }
        public string? NomeUsuario { get; internal set; }
        public string? Email { get; internal set; }
        public string? CPF { get; internal set; }
        public string? Senha { get; internal set; }
        public bool Ativo { get; internal set; }
    }
}