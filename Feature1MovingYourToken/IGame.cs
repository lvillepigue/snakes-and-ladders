namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    public interface IGame
    {
        void PlaceOnBoard(Token token);
        int GetPosition(Token token);
        void SetPosition(Token token, int position);
        void Move(Token token, int spaces);
        bool HasWon(Token token);
    }
}