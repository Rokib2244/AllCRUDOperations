using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNumber4ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char [,] board = new char[3,3];
            //Initialize(board);
            while (true)
            {
                Console.Clear();
                Print(board);
                
                Console.WriteLine("Please Enter row:");
                int row = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter col:");
                int col = Convert.ToInt32(Console.ReadLine());
                board[row, col] = player;
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                {
                    Console.WriteLine(player+ " won the game");
                    Console.ReadKey();
                } 
                if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                {
                    Console.WriteLine(player + " won the game");
                    Console.ReadKey();
                }
                if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                {
                    Console.WriteLine(player + " won the game");
                    Console.ReadKey();
                }
                if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.WriteLine(player + " won the game");
                    Console.ReadKey();
                }
                if (player == board[2, 0] && player == board[1, 1] && player == board[0, 2])
                {
                    Console.WriteLine(player + " won the game");
                    Console.ReadKey();
                }
                if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                {
                    Console.WriteLine(player + " won the game");
                    Console.ReadKey();
                }
                

                //player = Changeturn
            }
             
        }
        static void Print(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                Console.Write(" ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

    }
}
