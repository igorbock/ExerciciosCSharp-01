using System;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio8
    {
        public Exercicio8()
        {
            try
            {
                Console.WriteLine("Digite o valor do produto: ");
                valorProduto = decimal.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}\n\n{e.StackTrace}");
            }
            finally
            {
                Console.WriteLine($"O valor do produto com desconto é: R${valorProduto - ((desconto * valorProduto) / 100)}");
            }
        }

        public decimal valorProduto { get; set; }
        private const decimal desconto = 12M;
    }
}
