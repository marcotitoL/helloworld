using System;
namespace HackerRankProblemSolving
{
    public class SherlockAndSquares
    {
        private readonly int _a, _b;
        public SherlockAndSquares(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public int Solve()
        {

            int currentSquared = 1;
            int numSquares = 0;

            while( currentSquared*currentSquared <= _b)
            {


                if( currentSquared * currentSquared >= _a)
                    numSquares++;

                currentSquared++;
            }



            return numSquares;
            
        }
    }
}
