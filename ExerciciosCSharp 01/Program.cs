using ExerciciosCSharp_01.Exercicios;
using System;

namespace ExerciciosCSharp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escolha o exercício de 1 a 12: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Exercicio1 exercicio1 = new Exercicio1();
                        break;
                    case "2":
                        Console.Clear();
                        Exercicio2 exercicio2 = new Exercicio2();
                        break;
                    case "3":
                        Console.Clear();
                        Exercicio3 exercicio3 = new Exercicio3();
                        break;
                    case "4":
                        Console.Clear();
                        Exercicio4 exercicio4 = new Exercicio4();
                        break;
                    case "5":
                        Console.Clear();
                        Exercicio5 exercicio5 = new Exercicio5();
                        break;
                    case "6":
                        Console.Clear();
                        Exercicio6 exercicio6 = new Exercicio6();
                        break;
                    case "7":
                        Console.Clear();
                        Exercicio7 exercicio7 = new Exercicio7();
                        break;
                    case "8":
                        Console.Clear();
                        Exercicio8 exercicio8 = new Exercicio8();
                        break;
                    case "9":
                        Console.Clear();
                        Exercicio9 exercicio9 = new Exercicio9();
                        break;
                    case "10":
                        Console.Clear();
                        Exercicio10 exercicio10 = new Exercicio10();
                        break;
                    case "11":
                        Console.Clear();
                        Exercicio11 exercicio11 = new Exercicio11();
                        break;
                    case "12":
                        Console.Clear();
                        Exercicio12 exercicio12 = new Exercicio12();
                        break;
                    default:
                        Console.WriteLine("Comando não reconhecido...");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}\n\n{e.StackTrace}");
            }
            finally
            {
                Console.WriteLine("\n\nEncerrando...");
            }
        }
    }
}
