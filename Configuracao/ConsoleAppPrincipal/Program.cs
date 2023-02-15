using BLL;
using Models;
using System;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Nome = "kllaws silva d";
                usuario.NomeUsuario = "kllaws s";
                usuario.Ativo = true;
                usuario.Email = "martins199319@gmail.com";
                usuario.Cpf = "038.047.511-13";
                usuario.Senha = "123456597";

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBLL.Inserir(usuario);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}