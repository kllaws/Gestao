﻿namespace BLL
{
    public class Usuario
    {
        public object NomeUsuario { get; internal set; }
        public object Senha { get; internal set; }
        public int IDUsuario { get; internal set; }
        public string? Nome { get; internal set; }
        public string? Email { get; internal set; }
        public string? CPF { get; internal set; }
        public bool Ativo { get; internal set; }
    }
}