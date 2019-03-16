namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    public interface IGame
    {
        void PlaceOnBoard(Token token);
        int GetPosition(Token token);
    }
}