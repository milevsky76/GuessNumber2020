using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IGameSetuper
    {
        TypeOfGame GetTypeOfGame();

        GameRule UserCreateGameRule();

        GameRule AutoGenerateGameRule();
    }

    public enum TypeOfGame
    {
        WithBot,
        WithUser
    }
}
