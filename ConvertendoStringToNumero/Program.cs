using System;

namespace ConvertendoStringToNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            var MeuSalarioEmString = "2000,00";

            double MeuSalarioemDouble1 = Convert.ToDouble(MeuSalarioEmString);
            double meuSalarioemDouble2 = double.Parse(MeuSalarioEmString);



            Console.WriteLine($"Meu Salario é: {MeuSalarioemDouble1:C2}");
            Console.WriteLine($"Meu Salario é: {meuSalarioemDouble2:C2}");
            




        }
    }
}
