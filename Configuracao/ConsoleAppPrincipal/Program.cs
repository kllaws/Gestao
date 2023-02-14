using BLL;
using Models;
using System;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = "kllaws silva";
            usuario.NomeUsuario = "kllaws";
            usuario.Ativo = true;
            usuario.Email = "martins199319@gmail.com";
            usuario.Cpf = "038.047.511-13";
            usuario.Senha = "123";
            usuarioBLL.Inserir(usuario);

           

        }
    }
}