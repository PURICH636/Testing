using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class TIC_TAC_TOE
    {
        static int player = 1;
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int choice;
        static int flag = 0;
        static int count = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Player1:X and Player2:O");
            Console.WriteLine();
            do
            {
                if (player % 2 == 1)
                {
                    Console.WriteLine("Player 1 turn!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Player 2 turn!");
                    Console.WriteLine();
                }
                Board();
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 1)
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
                count++;
            } while (flag != 1 && flag != -1 && count != 8);
            Console.Clear();
            Board();
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Game is draw!");
            }
            
            Console.ReadKey();
        }

        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        private static int CheckWin()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[5] & arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            //Checking for draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
