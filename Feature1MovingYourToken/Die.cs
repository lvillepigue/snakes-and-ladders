using System;

namespace Navico.SnakesAndLadders.Feature1MovingYourToken
{
    public class Die : IDie
    {
        public int Roll()
        {
            return new Random().Next(1, 7);
        }
    }
}