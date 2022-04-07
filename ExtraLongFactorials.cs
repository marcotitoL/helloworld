using System;
using System.Numerics;
namespace HackerRankProblemSolving
{
    public class ExtraLongFactorials
    {
        readonly int _n;
        public ExtraLongFactorials(int n)
        {
            _n = n;
        }

        public string Solve()
        {
            BigInteger bigInteger = new BigInteger(_n);

            for(int i = 1; i < _n; i++)
            {
                bigInteger = BigInteger.Multiply( bigInteger, new BigInteger(_n-i));
            }

            return bigInteger.ToString();
        }

    }
}
