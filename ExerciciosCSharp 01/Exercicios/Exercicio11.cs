using System;

//Faça um programa que leia um numero inteiro positivo de tres dígitos (de 100 a 999).
//Gere outro número formado pelos dígitos invertidos do número lido.

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio11
    {
        public Exercicio11()
        {
            try
            {
                Console.WriteLine("Digite um número inteiro com 3 digitos: ");
                numeroLido = int.Parse(Console.ReadLine());
                while(numeroLido < 100 || numeroLido > 999)
                {
                    Console.Clear();
                    Console.WriteLine("Digite um número inteiro com 3 digitos: ");
                    numeroLido = int.Parse(Console.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
            finally
            {
                Console.WriteLine($"O número ao contrário é: {gerarNumeroContrario(numeroLido)}");
            }
        }

        public int numeroLido { get; private set; }

        public int gerarNumeroContrario(int numero)
        {
            int contrario = numero / 100;
            contrario += ((numero % 100) / 10) * 10;
            contrario += ((numero % 100) % 10) * 100;

            return contrario;
        }
    }
}
