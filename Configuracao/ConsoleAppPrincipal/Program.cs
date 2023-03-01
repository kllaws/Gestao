using BLL;
using ConsoleAppPrincipal;
using Models;
using System;
using System.Runtime.CompilerServices;
/*
internal class Program
{
    public static object Private { get; private set; }

    private static void Main(string[] args)
    {
        int opcao = 0;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("     Escolha uma opcao               |");
        Console.WriteLine("1 - Cadastrar usuario                |");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("2 - Excluir usuario                  |");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("3 - Alterar usuario                  |");
        Console.WriteLine("4 - Buscar todos os usuarios         |");
        Console.WriteLine("_____________________________________|");

        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                CadastrarUuario();
                break;
            case 2:
                ExcluirUsuario();
                break;
            case 3:
                AlterarUsuario();
                break;

            case 4:
                BuscarTodosOsUsuarios1();
                break;


        }
    }


    private static void BuscarTodosOsUsuarios1()
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                List<Usuario> usuario = usuarioBLL.BuscarTodos();
                foreach (Usuario item in usuario)
                {
                    Console.Write("Id: " + item.Id);
                    Console.WriteLine("Nome de Usuario: " + item.NomeUsuario);
                    Console.WriteLine("Email: " + item.Email);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    private static void CadastrarUsuario()
        {
            try
            {
                Usuario usuario = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuario.Nome = "kllaws silva";
                usuario.NomeUsuario = "kllaws";

                Console.WriteLine("O usuario esta ativo (s) ou (n)");
                usuario.Ativo = true;//Console ReadLine() ToUpper() == "s";

                usuario.Email = "martins@gmail.com";
                usuario.Cpf = "03502503602";
                usuario.Senha = "frwf5+1215";

                usuarioBLL.Inserir(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void ExcluirUsuario()
        {
            Console.WriteLine("Excluir usuario");
        }
        private static void CadastrarUuario()
        {
            throw new NotImplementedException();
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
            } while (sn != 2);
        }
    
}
*/







internal class Program
{
    private static void Main(string[] args)
    {
        int opcao = 0;
        Console.WriteLine(@"Escolha uma opção:
                            \n\n1 - Cadastrar usuário
                            \n2 - Excluir usuário
                            \n3 - Buscar todos os usuários");


        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                CadastrarUsuario();
                break;
            case 2:
                ExcluirUsuario();
                break;
            case 3:
                BuscarTodosOsUsuarios();
                break;
            default:
                break;
        }
    }

    private static void BuscarTodosOsUsuarios()
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        List<Usuario> usuarios = usuarioBLL.BuscarTodos();

        foreach (Usuario item in usuarios)
        {
            Console.WriteLine("Id: " + item.Id);
            Console.WriteLine("Nome de usuário: " + item.NomeUsuario);
            Console.WriteLine("E-mail: " + item.Email);
        }

    }

    private static void CadastrarUsuario()
    {
        try
        {
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuario.Nome = "Erisvaldo Carvalho Silva";
            usuario.NomeUsuario = "erisvaldo";

            Console.WriteLine("O usuário estará ativo (S) ou (N)");
            usuario.Ativo = true;//Console.ReadLine().ToUpper() == "S";

            usuario.Email = "contato@erisvaldocarvalho.com.br";
            usuario.CPF = "458.158.442-88";
 usuario.Senha = "12asdfdfe3";

            usuarioBLL.Inserir(usuario);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void ExcluirUsuario()
    {
        Console.WriteLine("Excluir usuário");
    }
}

 