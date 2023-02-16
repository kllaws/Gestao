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
            try
            {
                string opc;
                string opcao;
                do
                {
                    Console.WriteLine("Digete seu nome");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digete seu nome de usuario? ");
                    usuario.NomeUsuario = Console.ReadLine();

 

                    Console.WriteLine("Digete seu Email");
                    usuario.Email = Console.ReadLine();

                    Console.WriteLine("Digete seu CPF");
                    usuario.Cpf = Console.ReadLine();

                    Console.WriteLine("Digete sua Senha");
                    usuario.Senha = Console.ReadLine();


                    Console.WriteLine("O usuario esta  ativo? (s) ou (n)");
                    usuario.Ativo = Console.ReadLine().ToUpper() == "s";


                    /*
                    usuario.Nome = "kllaws silva d";
                    usuario.NomeUsuario = "kllaws s";
                    usuario.Ativo = true;
                    usuario.Email = "martins199319@gmail.com";
                    usuario.Cpf = "038.047.511-13";
                    usuario.Senha = "123456597";
                    */


                    usuarioBLL.Inserir(usuario);
                    Console.WriteLine("Usuario criado com sucesso... \nDeseja continuar cadastrando? \n 1(sim) 2 (nao)");
                    opc = Console.ReadLine();

                } while (opc == "1");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}