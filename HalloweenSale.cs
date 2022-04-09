using System;
namespace HackerRankProblemSolving
{
    public class HalloweenSale
    {
        private readonly int _p, _d, _m, _s;
        public HalloweenSale( int p, int d, int m, int s )
        {
            _p = p;
            _d = d;
            _m = m;
            _s = s;
        }

        public int Solve()
        {
            int unitsRemaining = _s;
            int currentCost = _p;
            int gamesBought = 0;
            
            if ( unitsRemaining >= _p)
            { 
                do
                {
                    unitsRemaining -= currentCost;

                    //compute currentCost
                    if( currentCost <= _m)
                    {
                        currentCost = _m;
                    }
                    else
                    {
                        currentCost = (currentCost - _d <= _m) ? _m : currentCost - _d;


                    }

                    
                    gamesBought++;

                } while (unitsRemaining - currentCost  >= 0 );
            }

            return gamesBought;
        }
    }
}
