using System;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio7
    {
        public Exercicio7()
        {
            try
            {
                Console.WriteLine("Digite o raio do círculo: ");
                raioCirculo = double.Parse(Console.ReadLine());
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
                Console.WriteLine($"A área do círculo é: {Math.PI * Math.Pow(raioCirculo, 2)}");
            }
        }

        public double raioCirculo { get; private set; }
    }
}
