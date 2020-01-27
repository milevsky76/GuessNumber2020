using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Ты тамада. Сколько дашь попыток?");

            var consoleHelper = new ConsoleHelper();
            var game = new Game(consoleHelper);

            var gameRule = new GameRule()
            {
                MaxAttempts = 3,
                Number = 42
            };
            var user = new User();
            game.StartGame(gameRule, user);

            Console.WriteLine($"User score: {user.Money}");

            Console.ReadLine();
        }
    }
}
