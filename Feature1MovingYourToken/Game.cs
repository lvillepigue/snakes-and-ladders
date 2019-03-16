namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    public class Game : IGame
    {
        public void PlaceOnBoard(Token token)
        {
            token.Position = 1;
        }

        public int GetPosition(Token token)
        {
            return token.Position;
        }
    }
}