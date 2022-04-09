using System;
using System.Collections.Generic;
namespace HackerRankProblemSolving
{
    public class BeautifulTriplets
    {
        private readonly int _d;
        private readonly List<int> _arr;
        public BeautifulTriplets(int d, List<int> arr)
        {
            _d = d;
            _arr = arr;
        }

        public int Solve()
        {
            int num = 0;

            //get all triplets
            for(int i = 0; i < _arr.Count; i++)
            {
                for (int j = i+1; j < _arr.Count; j++)
                {

                    if (_arr[j] - _arr[i] == _d)
                    {
                        for (int k = j + 1; k < _arr.Count; k++)
                        {
                                if (_arr[k] - _arr[j] == _d)
                                {
                                    num++;
                                }
                        }
                    }

                }
            }


            return num;
        }
    }
}
