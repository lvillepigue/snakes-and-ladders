using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    [TestClass]
    public class UnitTest1
    {
        private Token _token;
        private ITokenMover _tokenMover;
        private IDie _die;
        private IGame _game;

        [TestInitialize]
        public void Init()
        {
            _token = new Token();
            _tokenMover = A.Fake<ITokenMover>();
            _die = A.Fake<IDie>();
            _game = new Game(_tokenMover, _die);
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

        [TestMethod]
        public void MoveUsingDie()
        {
            A.CallTo(() => _die.Roll()).Returns(4); 
            _game.MoveUsingDie(_token);
            A.CallTo(() => _tokenMover.Move(_token, 4)).MustHaveHappened();
        }
    }
}
