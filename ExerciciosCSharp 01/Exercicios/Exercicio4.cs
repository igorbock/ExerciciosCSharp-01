using System;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio4
    {
        public Exercicio4()
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
                Console.WriteLine($"O sucessor: {numeroInteiro + 1} \nO antecessor: {numeroInteiro - 1}");
            }
        }

        public int numeroInteiro { get; private set; }
    }
}
