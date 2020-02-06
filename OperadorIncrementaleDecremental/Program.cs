using System;

namespace OperadorIncrementaleDecremental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pague X e leve mais 1 gratuito!");
            Console.WriteLine("Informe a quantidade que irá levar");

            string inputQtde = Console.ReadLine();

            var quantidade = int.Parse(inputQtde);

            //quantidade++;

            //quantidade = quantidade + 1;

            Console.WriteLine($"Quantidade total: {quantidade}");
            Console.WriteLine($"Quantidade total: {quantidade++}"); //pós incremental
            Console.WriteLine($"Quantidade total: {++quantidade}"); // pré incremental
        }
    }
}
