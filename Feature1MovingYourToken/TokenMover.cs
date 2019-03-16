namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    public class TokenMover : ITokenMover
    {
        public void PlaceOnBoard(Token token)
        {
            token.Position = 1;
        }

        public int GetPosition(Token token)
        {
            return token.Position;
        }

        public void SetPosition(Token token, int position)
        {
            token.Position = position;
        }

        public void Move(Token token, int spaces)
        {
            var oldPosition = token.Position;
            token.Position += spaces;
            if (token.Position > 100)
                token.Position = oldPosition;
        }
    }
}