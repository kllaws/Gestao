namespace Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            bool ativo;
            string CPF;
            string opcao;

                Console.WriteLine( "informe o nome do usuario" );
            nome = Console.ReadLine();
            Console.WriteLine("informe o cpf do usuario");
            CPF = Console.ReadLine();
            Console.WriteLine("O usuario esta ativo? (s) ou (n)");
            opcao = Console.ReadLine();

            ativo = opcao == "s";

            UsuarioBLL usuarioBLL


        }
    }
}