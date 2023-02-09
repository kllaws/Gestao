using System;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            while(true)
            {
               
                Console.WriteLine("informe o primeiro numero");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("informe o segundo numero");
                z = Convert.ToInt32(Console.ReadLine());

                try
                {
                    x = y / z;
                    Console.WriteLine( "O resultado e: "+ x);
                    Console.WriteLine("\nprecione enter para continuar. ");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao tentar");
                }
                
                  

            }
        }
    }
}