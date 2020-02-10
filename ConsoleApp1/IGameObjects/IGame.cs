using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IGame
    {
        GameRule GameRule { get; }

        User User { get; }

        int Attempt { get; }

        void StartGame(GameRule gameRule, User user);

        void GameRound();

        void WinGame();

        void LoseGame();
    }
}

