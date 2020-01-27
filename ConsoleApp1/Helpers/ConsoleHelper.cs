using ConsoleApp1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConsoleHelper : IConsoleHelper
    {
        public int ReadNumberFromConsole()
        {
            var countOfAttemptMax = 0;
            var userString = "";
            do
            {
                userString = Console.ReadLine();
            } while (!int.TryParse(userString, out countOfAttemptMax));

            return countOfAttemptMax;
        }
    }
}
