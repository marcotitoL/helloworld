using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblemSolving
{
    public class CutTheSticks
    {
        readonly List<int> _arr;
        public CutTheSticks( List<int> arr)
        {
            _arr = arr;
        }

        public List<int> Solve()
        {
            int[] sticks =  _arr.ToArray();
            int cutLength;
            List<int> stickCount = new List<int>();
            do
            {
                stickCount.Add(sticks.Count());
                cutLength = sticks.Min();
                for ( int i = 0; i < sticks.Length; i++)
                {
                    sticks[i] = sticks[i] - cutLength;
                }
                sticks = sticks.Where(s => s > 0).ToArray();
                

            } while (sticks.Length>0);
                

            return stickCount;
        }
    }

}
