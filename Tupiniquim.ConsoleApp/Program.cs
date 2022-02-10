using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TUPINIQUIM I");

            Console.Write("\nDigite as coordenadas do canto superior direito do grid: ");
            string[] grid = Console.ReadLine().Split(' ');
            int gridx = Convert.ToInt32(grid[0]);
            int gridy = Convert.ToInt32(grid[1]);
            while (true)
            {
                Console.Write("\nDigite a coordenada x inicial: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a coordenada y inicial: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o sentido inicial: ");
                char sentido = Convert.ToChar(Console.ReadLine().ToLower());

                Console.Write("\nDigite as instruções para o robô: ");
                string comandos = Console.ReadLine().ToLower();

                foreach (char comando in comandos)
                {
                    if (comando == 'm')
                    {
                        if (sentido == 'n')
                        {
                            y++;
                        }
                        else if (sentido == 'o')
                        {
                            x--;
                        }
                        else if (sentido == 'l')
                        {
                            x++;
                        }
                        else if (sentido == 's')
                        {
                            y--;
                        }

                    }
                    else if (comando == 'e')
                    {
                        if (sentido == 'n')
                        {
                            sentido = 'o';
                        }
                        else if (sentido == 'o')
                        {
                            sentido = 's';
                        }
                        else if (sentido == 's')
                        {
                            sentido = 'l';
                        }
                        else if (sentido == 'l')
                        {
                            sentido = 'n';
                        }

                    }
                    else if (comando == 'd')
                    {
                        if (sentido == 'n')
                        {
                            sentido = 'l';
                        }
                        else if (sentido == 'l')
                        {
                            sentido = 's';
                        }
                        else if (sentido == 's')
                        {
                            sentido = 'o';
                        }
                        else if (sentido == 'o')
                        {
                            sentido = 'n';
                        }
                    }
                }

                if (x > gridx || y > gridy || x < 0 || y < 0)
                {
                    Console.WriteLine("\nPERDÃO PRESIDENTE!!! O ROBÔ FUGIU DA ÁREA...");
                }
                else
                {
                    Console.WriteLine($"As coordenadas finais são: {x}, {y}, {char.ToUpper(sentido)}");
                }
            }
        }
    }
}