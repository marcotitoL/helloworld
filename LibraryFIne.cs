using System;
namespace HackerRankProblemSolving
{
    public class LibraryFIne
    {
        private readonly int _d1, _m1, _y1, _d2, _m2, _y2;
        public LibraryFIne( int d1, int m1, int y1, int d2, int m2, int y2 )
        {
            _d1 = d1;
            _m1 = m1;
            _y1 = y1;

            _d2 = d2;
            _m2 = m2;
            _y2 = y2;
        }

        public int Solve()
        {

            if(_y2 < _y1)
            {
                return 10000;
            }
            else if (_y2 == _y1 && _m2 < _m1 )
            {
                return 500 * (_m1-_m2);
            }
            else if (_y2 == _y1 && _m2 == _m1 && _d2 < _d1 )
            {
                return 15 * (_d1-_d2);
            }
            else
            {
                return 0;
            }
        }
    }
}
