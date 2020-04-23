using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1
{
    class ConsoleApp
    {
        private static void Main(string[] args)
        {
            TicTacToeEngine t = new TicTacToeEngine();

            Console.WriteLine(t.Board());

            String input = Console.ReadLine();

            while (input != "exit")
            {
                if (input != "reset")
                {
                    int value;
                    if (int.TryParse(input, out value))
                    {
                        if (t.ChooseCell(value))
                        {
                            t.AssignCell(value);
                            t.CheckWinner();
                            Console.WriteLine(t.Board());
                        }

                        input = Console.ReadLine();
                    }
                }
                else
                {
                    t.reset();
                    Console.WriteLine(t.Board());
                    input = Console.ReadLine();
                }
            }
        }
    }
}
