using System;
using System.Collections.Generic;

namespace ExerciciosCSharp_01.Exercicios
{
    public class Exercicio10
    {
        public Exercicio10()
        {
            var listaJogadores = new List<Ganhador>();
            var jogador1 = new Ganhador("João");
            var jogador2 = new Ganhador("Pedro");
            var jogador3 = new Ganhador("Mateus");

            jogador1.receberPremio((46 * Premio) / 100);
            jogador2.receberPremio((32 * Premio) / 100);
            jogador3.receberPremio((22 * Premio) / 100);

            listaJogadores.Add(jogador1);
            listaJogadores.Add(jogador2);
            listaJogadores.Add(jogador3);

            try
            {
                Console.WriteLine($"Um premio de {Premio} foi sorteado. Conheça os ganhadores: \n");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}\n\n{e.StackTrace}");
            }
            finally
            {
                foreach(Ganhador ganhador in listaJogadores)
                {
                    Console.WriteLine($"O ganhador {ganhador.Nome} recebeu: {ganhador.QuantiaRecebida}");
                }
                Console.ReadKey();
            }
        }

        const double Premio = 780000;
    }

    public class Ganhador
    {
        public Ganhador(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
        public double QuantiaRecebida { get; private set; }

        public void receberPremio(double premio)
        {
            QuantiaRecebida = premio;
        }
    }
}
