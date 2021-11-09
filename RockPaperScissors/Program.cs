using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;


            Console.WriteLine("Choose between ROCK, PAPER, SCISSORS:     ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK!");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Draw!\n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("Player wins!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose PAPER!");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("CPU wins!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("Player wins!\n\n");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    inputCPU = "Scissors";
                    Console.WriteLine("Computer chose Scissors!");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Player wins!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("CPU Wins!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("Draw!\n\n");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Entry!");
                    break;
            }
        }
    }
}
