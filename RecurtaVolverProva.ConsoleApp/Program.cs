using System;

namespace RecurtaVolverProva.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atenção recruta!");
            Console.WriteLine("Aperte qualquer botão");
            Console.ReadLine();

            Console.WriteLine("Escreva o número de comandos para o recruta!");
            string NUMEROS = Console.ReadLine();


            int NUMEROS1 = Convert.ToInt32(NUMEROS);
            Console.WriteLine("Para o recruta virar para direita escreva 'D' e para virar para esquerda digite 'E'");


            string comandos = Console.ReadLine();
            char[] comandosa = comandos.ToCharArray();

            Console.WriteLine("A direção inicial fica ao norte, digite a palavra 'Norte' para confirmar");
            string direcaoinicial = Console.ReadLine();


            Console.WriteLine("Aperte qualquer botão");
            Console.ReadKey();


            if (NUMEROS1 >= 1 && NUMEROS1 <= 100)
            {
                if (direcaoinicial == "Norte")
                {
                    for (int i = 0; i < comandosa.Length; i++)
                    {
                        if (comandosa[i] == 'D')
                        {
                            if (direcaoinicial == "Norte")
                            {
                                direcaoinicial = "Leste";

                            }
                            else if (direcaoinicial == "Leste")
                            {
                                direcaoinicial = "Sul";
                            }
                            else if (direcaoinicial == "Sul")
                            {
                                direcaoinicial = "Oeste";
                            }
                            else if (direcaoinicial == "Oeste")
                            {
                                direcaoinicial = "Norte";
                            }
                        }
                        if (comandosa[i] == 'E')
                        {
                            if (direcaoinicial == "Norte")
                            {
                                direcaoinicial = "Oeste";
                            }
                            else if (direcaoinicial == "Oeste")
                            {
                                direcaoinicial = "Sul";
                            }
                            else if (direcaoinicial == "Sul")
                            {
                                direcaoinicial = "Leste";
                            }
                            else if (direcaoinicial == "Leste")
                            {
                                direcaoinicial = "Norte";
                            }
                        }
                    }
                }

                Console.WriteLine("O recruta esta na direção: ");
                Console.WriteLine(direcaoinicial);

                Console.ReadKey();


            }
        }
    }
}
