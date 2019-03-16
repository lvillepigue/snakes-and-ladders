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
            Assert.AreEqual(Constants.FirstPosition, _game.GetPosition(_token));
        }

        [TestMethod]
        public void MoveThreeSpaces()
        {
            _game.SetPosition(_token, Constants.FirstPosition);
            _game.Move(_token, 3);
            Assert.AreEqual(4, _game.GetPosition(_token));
        }

        [TestMethod]
        public void MoveThreeThenFourSpaces()
        {
            _game.SetPosition(_token, Constants.FirstPosition);
            _game.Move(_token, 3);
            _game.Move(_token, 4);
            Assert.AreEqual(8, _game.GetPosition(_token));
        }

        [TestMethod]
        public void TokenOnSquare97ThenMoved3Spaces()
        {
            _game.SetPosition(_token, 97);
            _game.Move(_token, 3);
            Assert.AreEqual(Constants.LastPosition, _game.GetPosition(_token));
            Assert.IsTrue(_game.HasWon(_token));
        }

        [TestMethod]
        public void TokenOnSquare97ThenMoved4Spaces()
        {
            _game.SetPosition(_token, 97);
            _game.Move(_token, 4);
            Assert.AreEqual(97, _game.GetPosition(_token));
            Assert.IsFalse(_game.HasWon(_token));
        }

        [TestCleanup]
        public void Cleanup()
        {
            _game = null;
            _token = null;
        }
    }
}
