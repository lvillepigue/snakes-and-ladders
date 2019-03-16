namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    public class Game2 : IGame2
    {
        public bool HasWon(Token token)
        {
            return token.Position == 100;
        }
    }
}