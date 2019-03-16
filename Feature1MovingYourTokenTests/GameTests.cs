using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    [TestClass]
    public class GameTests
    {
        private IGame2 _game;
        private IGame _tokenMover;
        private Token _token;

        [TestInitialize]
        public void Init()
        {
            _token = new Token();
            _tokenMover = new Game();
            _game = new Game2();
        }

        [TestMethod]
        public void TokenOnSquareOneWhenPlacedOnBoard()
        {
            _tokenMover.PlaceOnBoard(_token);
            Assert.AreEqual(Constants.FirstPosition, _tokenMover.GetPosition(_token));
        }

        [TestMethod]
        public void MoveThreeSpaces()
        {
            _tokenMover.SetPosition(_token, Constants.FirstPosition);
            _tokenMover.Move(_token, 3);
            Assert.AreEqual(4, _tokenMover.GetPosition(_token));
        }

        [TestMethod]
        public void MoveThreeThenFourSpaces()
        {
            _tokenMover.SetPosition(_token, Constants.FirstPosition);
            _tokenMover.Move(_token, 3);
            _tokenMover.Move(_token, 4);
            Assert.AreEqual(8, _tokenMover.GetPosition(_token));
        }

        [TestMethod]
        public void TokenOnSquare97ThenMoved3Spaces()
        {
            _tokenMover.SetPosition(_token, 97);
            _tokenMover.Move(_token, 3);
            Assert.AreEqual(Constants.LastPosition, _tokenMover.GetPosition(_token));
            Assert.IsTrue(_game.HasWon(_token));
        }

        [TestMethod]
        public void TokenOnSquare97ThenMoved4Spaces()
        {
            _tokenMover.SetPosition(_token, 97);
            _tokenMover.Move(_token, 4);
            Assert.AreEqual(97, _tokenMover.GetPosition(_token));
            Assert.IsFalse(_game.HasWon(_token));
        }

        [TestCleanup]
        public void Cleanup()
        {
            _tokenMover = null;
            _token = null;
        }
    }
}
