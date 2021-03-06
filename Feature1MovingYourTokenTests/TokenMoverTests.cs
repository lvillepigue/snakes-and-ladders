﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    [TestClass]
    public class TokenMoverTests
    {
        private ITokenMover _tokenMover;
        private Token _token;

        [TestInitialize]
        public void Init()
        {
            _token = new Token();
            _tokenMover = new TokenMover();
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
        }

        [TestMethod]
        public void TokenOnSquare97ThenMoved4Spaces()
        {
            _tokenMover.SetPosition(_token, 97);
            _tokenMover.Move(_token, 4);
            Assert.AreEqual(97, _tokenMover.GetPosition(_token));
        }

        [TestCleanup]
        public void Cleanup()
        {
            _token = null;
            _tokenMover = null;
        }
    }
}
