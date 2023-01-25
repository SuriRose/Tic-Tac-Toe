using NUnit.Framework;
using TicTacToeApp;

namespace TicTacToeTest3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            TicTacToe game = new TicTacToe();
            TestContext.WriteLine("IsPlayAgainstComputer = " + game.PlayAgainstComputer.ToString());
            game.StartGame();
            game.TakeSpot(0);//x
            game.TakeSpot(3);//o
            game.TakeSpot(1);//x
            game.TakeSpot(6);//o
            game.TakeSpot(2);//x
            Assert.IsTrue(game.GameActive == false && game.Message == "X is the winner!", "Game.GameActive = " + game.GameActive + " Game.Message = " + game.Message);
            TestContext.WriteLine(game.SpotsReport);
            TestContext.WriteLine(game.Message);
        }
        [TestCase(0, 3, 1, 6, 2)]
        [TestCase(3, 0, 4, 6, 5)]
        [TestCase(6, 3, 7, 0, 8)]
        public void TestXWinsHorizontal(int x0, int o0, int x1, int o1, int x2)
        {
            TicTacToe game = new TicTacToe();
            game.StartGame();
            TestContext.WriteLine("PlayAgainstComputer = " + game.PlayAgainstComputer.ToString());
            game.TakeSpot(x0);//x
            game.TakeSpot(o0);//o
            game.TakeSpot(x1);//x
            game.TakeSpot(o1);//o                                             
            game.TakeSpot(x2);//x
            Assert.IsTrue(game.GameActive == false && game.Winner == TicTacToe.PlayerEnum.X, "GameActive = " + game.GameActive + " Game.Message = " + game.Message);
            TestContext.WriteLine(game.SpotsReport);
            TestContext.WriteLine(game.Message);
        }
    }
}