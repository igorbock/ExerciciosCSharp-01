using System;

//Leia um número inteiro de 4 digitos (de 1000 a 9999) e imprima 1 dígito por linha.

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio12
    {
        public Exercicio12()
        {
            try
            {
                Console.WriteLine("Digite um número de quatro digitos: ");
                numeroQuatroDigitos = int.Parse(Console.ReadLine());
                while(numeroQuatroDigitos < 1000 || numeroQuatroDigitos > 9999)
                {
                    Console.Clear();
                    Console.WriteLine("Digite um número de quatro digitos: ");
                    numeroQuatroDigitos = int.Parse(Console.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Cada dígito em uma linha: ");
                int[] digitos = retornaArray(numeroQuatroDigitos);
                foreach(int i in digitos)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public int numeroQuatroDigitos { get; private set; }

        private int[] retornaArray(int numero)
        {
            int[] quatroDigitos = new int[4];
            quatroDigitos[0] = numero / 1000;
            quatroDigitos[1] = (numero % 1000) / 100;
            quatroDigitos[2] = ((numero % 1000) % 100) / 10;
            quatroDigitos[3] = ((numero % 1000) % 100) % 10;

            return quatroDigitos;
        }
    }
}
