namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    public class Game : IGame
    {
        private ITokenMover _tokenMover;
        private IDie _die;

        public Game(ITokenMover tokenMover, IDie die)
        {
            _tokenMover = tokenMover;
            _die = die;
        }

        public bool HasWon(Token token)
        {
            return token.Position == Constants.LastPosition;
        }

        public void MoveUsingDie(Token token)
        {
            int spaces = _die.Roll();
            _tokenMover.Move(token, spaces);
        }
    }
}
