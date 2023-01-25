using NUnit.Framework;
using TicTacToeApp;
namespace TicTacToeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestXWinsFirstRow()
        {
            TicTacToe game = new TicTacToe();
            game.StartGame();
            TestContext.WriteLine("isPlayAgainstComputer = " + game.IsPlayAgainstComputer.ToString);
            game.TakeSpot(0);//x
            game.TakeSpot(3);//o
            game.TakeSpot(1);//x
            game.TakeSpot(6);//o
            game.TakeSpot(2);//x
            Assert.IsTrue(game.GameActive == false && game.Winner == TicTacToe.PLayerEnum.X, "GameActive = " + game.GameActive + " Game.Message = ") + game.Message;
            TestContext.WriteLine(game.SpotsReport);
            TestContext.WriteLine(game.Message);
        }
    }
}