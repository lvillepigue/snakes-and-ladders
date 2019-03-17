namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    public interface IGame
    {
        bool HasWon(Token token);
        void MoveUsingDie(Token token);
    }
}
