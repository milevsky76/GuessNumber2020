using System;
using ConsoleApp1;
using ConsoleApp1.Helpers;
using Moq;
using NUnit.Framework;

namespace UnitTestProject1
{
    
    public class GameTest
    {
        [TestCase(5, 5, 10, 9)]
        [TestCase(5, 4, 10, 0)]
        [TestCase(1, 1, 3, 2)]
        public void GameRoundTest(
            int userNumber, 
            int gameRuleNumber, 
            int maxAttemps,
            int expectedMoney)
        {
            var consoleHelperMock = new Mock<IConsoleHelper>();
            consoleHelperMock
                .Setup(x => x.ReadNumberFromConsole())
                .Returns(userNumber);

            var game = new Game(consoleHelperMock.Object);

            var gameRule = new GameRule
            {
                Number = gameRuleNumber,
                MaxAttempts = maxAttemps
            };

            var user = new User();

            game.StartGame(gameRule, user);

            Assert.AreEqual(expectedMoney, user.Money);
        }

    }
}
