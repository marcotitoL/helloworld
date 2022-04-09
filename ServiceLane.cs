using System;
using System.Collections.Generic;
namespace HackerRankProblemSolving
{
    public class ServiceLane
    {
        private readonly List<int> _width;
        private readonly List<List<int>> _cases;
        public ServiceLane( List<int> width, List<List<int>> cases )
        {
            _width = width;
            _cases = cases;
        }

        public List<int> Solve()
        {
            List<int> tmp;
            List<int> maxWidths = new List<int>() { };

            foreach( List<int> acase in _cases)
            {

               tmp = _width.GetRange(acase[0], acase[1]+1 - acase[0]);
               tmp.Sort();
                
                maxWidths.Add(tmp[0]);
            }


            return maxWidths;
        }
    }
}
