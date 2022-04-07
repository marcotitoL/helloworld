using System;
namespace HackerRankProblemSolving
{
    public class FindDigits
    {
        readonly int _n;
        public FindDigits(int n)
        {
            _n = n;
        }

        public int Solve()
        {

            char[] digitChars = _n.ToString().ToCharArray();
            int divisorCount = 0;
            

            for( int i =0; i<digitChars.Length;i++)
            {
                if (_n % Char.GetNumericValue(digitChars[i]) == 0)
                {
                    divisorCount+=1;
                }
                
            }


            return divisorCount;
        }
    }
}
