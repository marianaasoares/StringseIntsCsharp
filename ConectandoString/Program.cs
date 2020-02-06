using System;

namespace ConectandoString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu primeiro nome: ");
            var primeiroNome = Console.ReadLine();

            Console.WriteLine("Informe o seu segundo nome: ");
            string segundoNome = Console.ReadLine();

            Console.WriteLine($"Seu nome completo é: {primeiroNome} {segundoNome}");
        }
    }
}
