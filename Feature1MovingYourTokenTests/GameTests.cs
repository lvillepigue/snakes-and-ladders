using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    [TestClass]
    public class GameTests
    {
        private IGame _game;
        private Token _token;

        [TestInitialize]
        public void Init()
        {
            _token = new Token();
            _game = new Game();
        }

        [TestMethod]
        public void TokenOnSquareOneWhenPlacedOnBoard()
        {
            _game.PlaceOnBoard(_token);
            Assert.AreEqual(1, _game.GetPosition(_token));
        }

        [TestCleanup]
        public void Cleanup()
        {
            _game = null;
            _token = null;
        }
    }
}
