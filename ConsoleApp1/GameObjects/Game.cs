using ConsoleApp1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game : IGame
    {
        public GameRule GameRule { get; private set; }

        public User User { get; private set; }

        public int Attempt { get; private set; }

        private IConsoleHelper _consoleHelper;
        public Game(IConsoleHelper consoleHelper)
        {
            _consoleHelper = consoleHelper;
        }

        public void StartGame(GameRule gameRule, User user)
        {
            GameRule = gameRule;
            User = user;

            GameRound();
        }

        public void GameRound()
        {
            Attempt++;
            if (Attempt > GameRule.MaxAttempts)
            {
                LoseGame();
                return;
            }

            Console.WriteLine($"Осталось попытом {GameRule.MaxAttempts - Attempt}. Введи число");
            var number = _consoleHelper.ReadNumberFromConsole();

            if (number > GameRule.Number)
            {
                Console.WriteLine("Твоё число больше чем надо");
            }
            else if (number < GameRule.Number)
            {
                Console.WriteLine("Твоё число меньше чем надо");
            }
            else
            {
                WinGame();
                return;
            }

            GameRound();
        }

        public void WinGame()
        {
            User.Money += GameRule.MaxAttempts - Attempt;
            Console.WriteLine("Win");
        }

        public void LoseGame()
        {
            Console.WriteLine("Looser");
        }
    }
}
