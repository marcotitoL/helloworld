using System;
namespace HackerRankProblemSolving
{
    public class AppendAndDelete
    {
        private readonly string _s, _t;
        private readonly int _k;
        
        public AppendAndDelete(string s, string t, int k)
        {
            _s = s;
            _t = t;
            _k = k;
        }

        public string Solve()
        {
            int del = 0;
            int app;
            string tmp = _s;
            int remainingMoves;


            while (_t.IndexOf( tmp ) != 0 )
            {
                tmp = tmp.Remove( tmp.Length -1 );
                del++;
            }


            app = _t.Length - tmp.Length;


            

            if (tmp.Length == 0 && _k - del > _t.Length)
                return "Yes";

            remainingMoves = _k - (del + app);



            if ( app == 0)
            {
                return remainingMoves >= _t.Length || remainingMoves % 2 == 0  ? "Yes" : "No";
                
            }
            else
            {
                
                return del + app == _k || ( remainingMoves%2==0 && remainingMoves >= 0 ) ? "Yes" : "No";
            }


            
        }
    }
}
