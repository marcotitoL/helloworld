using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblemSolving
{
    public class QueensAttack
    {

        private readonly int _n, _k, _r_q, _c_q;
        private readonly List<List<int>> _obstacles;

        public QueensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles )
        {
            _n = n;
            _k = k;
            _r_q = r_q-1;
            _c_q = c_q-1;
            _obstacles = obstacles;
        }

        public int Solve()
        {

            /*
             do you know how i know that my code probably wont pass all the test cases?
            It's when the line count reaches 50 or more for this Solve() Method. lol
            this is such a battle because i don't have a computer science theory background
            to rely on. Arrggh! but i know this is easy, I just need a long run this weekend :D
            */

            int totalSquares = 0;

            bool U = false, D = false, L = false, R = false, UL = false, UR = false, DL = false, DR = false;

            //Console.WriteLine("Q?=" + _obstacles.Exists(o => o[0] == 3 && o[1] == 3));


            for (int c = _c_q; c+1 < _n ||    _c_q-(c-_c_q)-1 >= 0 ; c++)
            {
                //Console.WriteLine("Iterate LEFT = " + (_c_q - (c - _c_q) - 1));

                //right
                if( c + 1 < _n && !R )
                {
                    if (!_obstacles.Exists(o => o[0] == _r_q + 1 && o[1] == c + 2 ))
                    {
                        totalSquares++;
                        //Console.WriteLine("R");
                    }
                    else R = !R;
                }


                //left

                if ( !L && _c_q - (c - _c_q) - 1 >=0 )
                {
                    if (!_obstacles.Exists(o => o[0] == _r_q + 1 && o[1] == c + 2 - _c_q))
                    {
                        totalSquares++;
                        //Console.WriteLine(_r_q + "L" + (c + 1 - _c_q));
                    }
                    else L = !L;
                }


                for (int r = _r_q+1,diag=1; r < _n && c == _c_q; r++,diag++)
                {
                    //for top half
                    if( !U )
                        if (!_obstacles.Exists(o => o[0] == r+1 && o[1] == c+1) )
                        {
                            totalSquares++;
                            //Console.WriteLine(r + ",." + c);
                        }
                        else U = !U;
                    if( !UR )
                        if (!_obstacles.Exists(o => o[0] == r+1 && o[1] == c+diag+1) && c+diag<_n )
                        {
                            totalSquares++;
                           // Console.WriteLine(r + "," + (c+diag));
                        }
                        else UR = !UR;

                    if( !UL )
                        if (!_obstacles.Exists(o => o[0] == r+1 && o[1] == c - diag+1) && c-diag>=0 )
                        {
                            totalSquares++;
                           // Console.WriteLine(r + "," + (c-diag));
                        }
                        else UL = !UL;

                }

                

                for (int r = _r_q - 1, diag = 1; r >= 0 && c == _c_q; r--, diag++)
                {
                    
                    //for bottom half
                    if ( !D )
                        if (!_obstacles.Exists(o => o[0] == r+1 && o[1] == c+1) )
                        {
                            totalSquares++;
                            //Console.WriteLine(r + ",a" + c);
                        }
                        else D = !D;

                    if (!DR)
                        if (!_obstacles.Exists(o => o[0] == r+1 && o[1] == c + diag+1) && c + diag < _n )
                        {
                            totalSquares++;
                            //Console.WriteLine(r + ",b" + (c + diag));
                        }
                        else DR = !DR;

                    if (!DL)
                        if (!_obstacles.Exists(o => o[0] == r && o[1] == c -diag+1) && c - diag >= 0 )
                        {
                            totalSquares++;
                            //Console.WriteLine(r + ",c" + (c - diag));
                        }
                        else DL = !DL;

                }
            }


            return totalSquares;
        }
    }
}
