using System;
using System.Collections.Generic;
using System.Linq;
namespace HackerRankProblemSolving
{
    public class MinimumDistances
    {
        private readonly List<int> _a;
        public MinimumDistances(List<int> a)
        {
            _a = a;
        }

        public int Solve()
        {
            int minimum = _a.Count+1;
            for( int i = 0,pairIndex; i < _a.Count; i++)
            {
                //get nearest pair
                pairIndex = _a.IndexOf(_a[i],i+1);
                
                if( pairIndex != -1)
                {
                    if (pairIndex - i < minimum)
                        minimum = pairIndex - i;
                }
            }

            return minimum == _a.Count+1 ? -1 : minimum;
        }
    }
}
