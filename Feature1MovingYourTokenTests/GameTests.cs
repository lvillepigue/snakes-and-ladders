using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    [TestClass]
    public class UnitTest1
    {
        private Token _token;
        private IGame _game;

        [TestInitialize]
        public void Init()
        {
            _token = new Token();
            _game = new Game();
        }

        [TestMethod]
        public void TestHasWon()
        {
            _token.Position = Constants.LastPosition;
            Assert.IsTrue(_game.HasWon(_token));
        }

        [TestMethod]
        public void TestHasNotWon()
        {
            _token.Position = 97;
            Assert.IsFalse(_game.HasWon(_token));
        }
    }
}
