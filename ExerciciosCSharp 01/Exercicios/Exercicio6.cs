using System;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio6
    {
        public Exercicio6()
        {
            try
            {
                Console.WriteLine("Digite o lado de um quadrado: ");
                ladoQuadrado = double.Parse(Console.ReadLine());
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}\n\n{e.StackTrace}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}\n\n{e.StackTrace}");
            }
            finally
            {
                Console.WriteLine($"A área do quadrado é: {Math.Pow(ladoQuadrado, 2)}m²");
            }
        }

        public double ladoQuadrado { get; private set; }
    }
}
