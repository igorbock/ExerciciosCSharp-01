using System;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio5
    {
        public Exercicio5()
        {
            try
            {
                Console.WriteLine("Digite um número inteiro: ");
                numeroInteiro = int.Parse(Console.ReadLine());
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
                Console.WriteLine($"A soma do sucessor do seu triplo mais o antecessor do seu dobro: {((numeroInteiro * 3) + 1) + ((numeroInteiro * 2) - 1)}");
            }
        }

        public int numeroInteiro { get; private set; }
    }
}
