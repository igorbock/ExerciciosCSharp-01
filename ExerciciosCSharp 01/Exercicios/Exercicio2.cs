using System;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio2
    {
        public Exercicio2()
        {
            Console.WriteLine("Digite a primeira nota: ");
            nota1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            nota3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            nota4 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nMédia aritmética das notas: ");
            Console.WriteLine($"\n{(nota1 + nota2 + nota3 + nota4) / 4}");
        }

        public decimal nota1 { get; private set; }
        public decimal nota2 { get; private set; }
        public decimal nota3 { get; private set; }
        public decimal nota4 { get; private set; }
    }
}
