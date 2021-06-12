using System;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio9
    {
        public Exercicio9()
        {
            try
            {
                Console.WriteLine("Digite o salário do funcionário: ");
                salario = double.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}\n\n{e.StackTrace}");
            }
            finally
            {
                Console.WriteLine($"O funcionário recebeu um aumento de {aumento}%. Seu novo salário é: R${salario + ((salario * aumento) / 100)}");
            }
        }

        public double salario { get; private set; }
        private const double aumento = 25;
    }
}
