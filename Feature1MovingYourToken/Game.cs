namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    public class Game : IGame
    {
        public bool HasWon(Token token)
        {
            return token.Position == 100;
        }
    }
}