using System;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio3
    {
        public Exercicio3()
        {
            try
            {
                Console.WriteLine("Digite um valor em real: ");
                valorReal = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a cotação do dólar: ");
                cotacaoDolar = double.Parse(Console.ReadLine());
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}\n\n{e.StackTrace}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}\n\n{e.StackTrace}");
            }
            finally
            {
                Console.WriteLine($"O valor em dólares: {valorReal/cotacaoDolar}");
            }
        }

        public double valorReal { get; private set; }
        public double cotacaoDolar { get; private set; }
    }
}
