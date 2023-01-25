using NUnit.Framework;
using TicTacToeApp;

namespace TicTacToeTest2
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
    [TestCase(6, 3, 7, 0, 8)]
    [TestCase(1, 3, 1, 6, 2)]
    [TestCase(3, 1, 4, 6, 5)]
    public void TestXWinsHorizontal(int x0, int o0, int x1, int o1, int x2)
    {
        TicTacToe game = new TicTacToe();
        game.StartGame();
        TestContext.WriteLine("isPlayAgainstComputer = " + game.IsPlayAgainstComputer.ToString);
        game.TakeSpot(x0);//x
        game.TakeSpot(o0);//o
        game.TakeSpot(x1);//x
        game.TakeSpot(o1);//o                                             
        game.TakeSpot(x2);//x
        Assert.IsTrue(game.GameActive == false && game.Winner == TicTacToe.PLayerEnum.X, "GameActive = " + game.GameActive + " Game.Message = ") + game.Message;
        TestContext.WriteLine(game.SpotsReport);
        TestContext.WriteLine(game.Message);
    }                                      
}