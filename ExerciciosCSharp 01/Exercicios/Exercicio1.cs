using System;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio1
    {
        public Exercicio1()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"\n...\n\nQuadrado 1: {Math.Pow(valor1, 2)}\nQuadrado 2: {Math.Pow(valor2, 2)}\nQuadrado 3: {Math.Pow(valor3, 2)}\n\nA soma dos quadrados: ");
            Console.WriteLine($"\n{Math.Pow(valor1, 2) + Math.Pow(valor2, 2) + Math.Pow(valor3, 2)}");
        }

        public double valor1 { get; private set; }
        public double valor2 { get; private set; }
        public double valor3 { get; private set; }
    }
}
