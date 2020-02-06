using System;

namespace FirsHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário: ");

            var salarioUsuario = Console.ReadLine();

            double salarioUsuarioDouble = Convert.ToDouble(salarioUsuario);

            Console.WriteLine($"Seu salário em formato Double, com 2 casas decimais é: {salarioUsuarioDouble:C2}");


            

            var meuSalarioemInteiro = Convert.ToInt32(salarioUsuario);
            var meuSalarioemInteiro2 = int.Parse(salarioUsuario);
            var meuSalarioemLong = Convert.ToInt64(salarioUsuario);
            var meuSalarioemLong2 = long.Parse(salarioUsuario);

            Console.WriteLine($"Meu Salario é: {meuSalarioemInteiro:C2}");
            Console.WriteLine($"Meu Salario é: {meuSalarioemInteiro2:C2}");
            Console.WriteLine($"Meu Salario é: {meuSalarioemLong:C2}");
            Console.WriteLine($"Meu Salario é: {meuSalarioemLong2:C2}");
        }
    }
}
