using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct GameRule
    {
        public int MaxAttempts;
        public int Number;
        public int MinNumber;
        public int MaxNumber;
        public SoHard SoHard;
        public TypeOfGame TypeOfGame;
    }

    public enum SoHard
    {
        easy,
        normal,
        hard
    }
}
