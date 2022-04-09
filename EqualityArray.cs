using System;
using System.Collections.Generic;
using System.Linq;
namespace HackerRankProblemSolving
{
    public class EqualityArray
    {

        private readonly int[] _arr;

        public EqualityArray(int[] arr)
        {
            _arr = arr;
        }

        public int Solve()
        {

            List<int> listArr = _arr.ToList();

            List<int> uniqueValues = listArr.Distinct().ToList();

            Dictionary<int, int> valueCounts = new Dictionary<int, int>();

            uniqueValues.Sort();


            foreach (var uniqueValue in uniqueValues)
            {
                valueCounts.Add(uniqueValue, listArr.Where(i => i == uniqueValue).Count());
            }

            valueCounts = valueCounts.OrderBy(count => count.Value).ToDictionary(d=>d.Key,d=>d.Value) ;

            int mostCommonElement = valueCounts.First(i => i.Value == valueCounts.Values.Max()).Key;


            return valueCounts.Where( i=> i.Key != mostCommonElement ).Sum( i => i.Value );
             
        }
    }
}
