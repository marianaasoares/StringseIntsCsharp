using System;
using System.Globalization;

namespace FormataçãoInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuSalario = 2000.00;

            Console.WriteLine(meuSalario.ToString("C"));
            Console.WriteLine(meuSalario.ToString("C2"));
            Console.WriteLine(meuSalario.ToString("C3"));

            Console.WriteLine($"Outra forma de formatar o Inteiro: {meuSalario:C2}");

            Console.WriteLine(meuSalario.ToString("C4", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(meuSalario.ToString("C4", CultureInfo.CreateSpecificCulture("en-US")));

            var idade = 18;

            Console.WriteLine($"Minha Idade: {idade:N5}");
            Console.WriteLine($"Minha Idade: {idade:N}");

            var valorTotalAPagar = 1500;
            Console.WriteLine($"Valor total a pagar: {valorTotalAPagar:F2}");
        }
    }
}
    