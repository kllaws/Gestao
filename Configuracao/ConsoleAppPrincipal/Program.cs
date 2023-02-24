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
                int prog;
                do
                {
                    Console.Clear();
                    Console.Title = "MENU";
                    Console.WriteLine("\tMENU");
                    Console.WriteLine("Escolha uma opção: ");
                    Console.WriteLine("1 - Cadastrar Usuario");//Console.WriteLine("Escolha uma opção:\n\1 - Cadastrar usuário\n\2 - ");
                    Console.WriteLine("2 - Cadastrar Grupo");
                    Console.WriteLine("3 - Cadastrar Permissão");
                    Console.WriteLine("4 - Alterar Usuario");
                    Console.WriteLine("5 - Alterar Grupo");
                    Console.WriteLine("6 - Alterar Permissão");
                    Console.WriteLine("7 - Buscar");
                    Console.WriteLine("8 - Excluir Usuario");
                    Console.WriteLine("8 - Excluir Grupo");
                    Console.WriteLine("8 - Excluir Permissao");
                    Console.WriteLine("0 - Sair");
                    prog = Convert.ToInt32(Console.ReadLine());

                    switch (prog)
                    {
                        case 1:
                            CadastrarUsuario();
                            break;
                        case 2:
                            CadastrarGrupo();
                            break;
                        case 3:
                            CadastrarPermissao();
                            break;
                        case 4:
                            AlterarUsuario();
                            break;
                        case 5:
                            //AlterarGrupo();
                            break;
                        case 6:
                           // AlterarPermissao();
                            break;

                        default:
                            break;
                    }
                } while (prog != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void CadastrarPermissao()
        {
            int sn;
            Permissao permissao = new Permissao();
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Console.Clear();
            do
            {
                Console.WriteLine("\nCria Permissão\n\n");
                Console.WriteLine("Insira o nome da Permissão: ");
                permissao.Descricao = Console.ReadLine();
                permissaoBLL.Inserir(permissao);
                Console.WriteLine("Permissão criado com sucesso.\n\nDeseja criar uma nova Permissão: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (sn != 2);
        }
        private static void CadastrarGrupo()
        {
            int sn;
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            Console.Clear();
            do
            {
                Console.WriteLine("\nCria Grupo\n\n");
                Console.WriteLine("Insira o nome do grupo: ");
                grupoUsuario.NomeGrupo = Console.ReadLine();
                //Console.Clear();
                grupoUsuarioBLL.Inserir(grupoUsuario);
                Console.WriteLine("Grupo criado com sucesso.\n\nDeseja criar um novo grupo: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void CadastrarUsuario()
        {
            int sn;
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Console.Clear();
            do
            {
                Console.WriteLine("\nSistema de Cadastro\n\n");
                Console.WriteLine("Informe seu Nome Completo: ");
                usuario.Nome = Console.ReadLine();
                Console.WriteLine("Informe o nome de acesso do Usuário: ");
                usuario.NomeUsuario = Console.ReadLine();
                Console.WriteLine("Informe seu Email: ");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Informe o seu CPF: ");
                usuario.CPF = Console.ReadLine();
                Console.WriteLine("Cadastre sua Senha: ");
                usuario.Senha = Console.ReadLine();
                Console.WriteLine("O usuário estará ativo (S) ou (N)");
                usuario.Ativo = Console.ReadLine().ToLower() == "s";//armazendo expressao booleana
                Console.Clear();
                usuarioBLL.Inserir(usuario);
                Console.WriteLine("Usuário cadastrado com sucesso.\n\nDeseja cadastrar um novo usuário: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void AlterarUsuario()
        {
            int sn;
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nAlteração de Cadastro\n\n");
                Console.WriteLine("Informe seu Nome Completo: ");
                usuario.Nome = Console.ReadLine();
                Console.WriteLine("Informe o nome de acesso do Usuário: ");
                usuario.NomeUsuario = Console.ReadLine();
                Console.WriteLine("Informe seu Email: ");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Informe o seu CPF: ");
                usuario.CPF = Console.ReadLine();
                Console.WriteLine("Cadastre sua Senha: ");
                usuario.Senha = Console.ReadLine();
                Console.WriteLine("O usuário estará ativo (S) ou (N)");
                usuario.Ativo = Console.ReadLine().ToLower() == "s";//armazendo expressao booleana

                Console.Clear();

                usuarioBLL.Inserir(usuario);
                Console.WriteLine("Alteração de cadastrado com sucesso.\n\nDeseja alterar um novo usuário: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while(sn != 2);
        }
    }
}