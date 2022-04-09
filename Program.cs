using System;
using System.Collections.Generic;

namespace HackerRankProblemSolving
{
    class Program
    {
        static string _solutionOutput;

        static void Main(string[] args)
        {
            int probemNumber = 0;

            //Problem 1: https://www.hackerrank.com/challenges/find-digits/problem?isFullScreen=true

            int n = 1012;

            FindDigits findDigits = new FindDigits(n);

            _solutionOutput = findDigits.Solve().ToString();

            Console.WriteLine( $"Problem {++probemNumber}: \n" + _solutionOutput );

            //------------------------------------------------------------------------------------------------

            //Problem 2: https://www.hackerrank.com/challenges/extra-long-factorials/problem?isFullScreen=true

            n = 25;

            ExtraLongFactorials extraLongFactorials = new ExtraLongFactorials(n);

            _solutionOutput = extraLongFactorials.Solve();

            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput );


            //------------------------------------------------------------------------------------------------

            //Problem 3: https://www.hackerrank.com/challenges/append-and-delete/problem?isFullScreen=true

            string s = "hackerhappy";
            string t = "hackerrank";
            int k = 9;

            AppendAndDelete appendAndDelete = new AppendAndDelete(s,t,k);

            _solutionOutput = appendAndDelete.Solve();

            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput);


            //------------------------------------------------------------------------------------------------

            //Problem 4: https://www.hackerrank.com/challenges/sherlock-and-squares/problem?isFullScreen=true

            int a = 24;
            int b = 49;

            SherlockAndSquares sherlockAndSquares = new SherlockAndSquares(a,b);

            _solutionOutput = sherlockAndSquares.Solve().ToString();

            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput);


            //------------------------------------------------------------------------------------------------

            //Problem 5: https://www.hackerrank.com/challenges/library-fine/problem?isFullScreen=true

            int d1 = 15, m1 = 7, y1 = 2014;
            int d2 = 1, m2 = 7, y2 = 2015;

            LibraryFIne libraryFIne = new LibraryFIne(d1,m1,y1,d2,m2,y2);

            _solutionOutput = libraryFIne.Solve().ToString();

            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput);


            //------------------------------------------------------------------------------------------------


            //Problem 6: https://www.hackerrank.com/challenges/cut-the-sticks/problem?isFullScreen=true

            List<int> arr = new List<int>() { 5, 4, 4, 2, 2, 8 };

            CutTheSticks cutTheSticks = new CutTheSticks(arr);

            _solutionOutput = string.Join("\n", cutTheSticks.Solve());

            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput);


            //------------------------------------------------------------------------------------------------


            //Problem 7: https://www.hackerrank.com/challenges/equality-in-a-array/problem?isFullScreen=true

            int[] arrE = new int[] { 24, 29, 70, 43, 12, 27, 29, 24, 41, 12, 41, 43, 24, 70, 24, 100, 41, 43, 43, 100, 29, 70, 100, 43, 41, 27, 70, 70, 59, 41, 24, 24, 29, 43, 24, 27, 70, 24, 27, 70, 24, 70, 27, 24, 43, 27, 100, 41, 12, 70, 43, 70, 62, 12, 59, 29, 62, 41, 100, 43, 43, 59, 59, 70, 12, 27, 43, 43, 27, 27, 27, 24, 43, 43, 62, 43, 70, 29 };

            EqualityArray equalityArray = new EqualityArray(arrE);

            _solutionOutput = equalityArray.Solve().ToString();

            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput);


            //------------------------------------------------------------------------------------------------

            /* still working on this :( */
            //Problem 8: https://www.hackerrank.com/challenges/queens-attack-2/problem?isFullScreen=true

            n = 8;
            k = 0;
            int r_q = 5;
            int c_q = 4;//new List<int> { 5,5}, new List<int> { 4, 2 }, new List<int> { 2, 3 }
            List<List<int>> obstacles = new List<List<int>>(){  };

            QueensAttack queensAttack = new QueensAttack(n,k,r_q,c_q, obstacles);

            _solutionOutput = queensAttack.Solve().ToString();

            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput );


            //------------------------------------------------------------------------------------------------


            //Problem 9: https://www.hackerrank.com/challenges/beautiful-triplets/problem?isFullScreen=true

            int d = 3;
            List<int> arr2 = new List<int>() { 1, 2, 4, 5, 7, 8, 10 };

            BeautifulTriplets beautifulTriplets = new BeautifulTriplets(d, arr2);

            _solutionOutput = beautifulTriplets.Solve().ToString();

            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput);


            //------------------------------------------------------------------------------------------------


            //Problem 10: https://www.hackerrank.com/challenges/minimum-distances/problem

            arr = new List<int>() { 7, 1, 3, 4, 1, 7 };

            MinimumDistances minimumDistances = new MinimumDistances(arr);

            _solutionOutput = minimumDistances.Solve().ToString();

            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput );


            //------------------------------------------------------------------------------------------------


            //Problem 11: https://www.hackerrank.com/challenges/halloween-sale/problem?isFullScreen=true

            int p = 16, m = 1;
            d = 2;
            int _s = 9981;


            HalloweenSale halloweenSale = new HalloweenSale(p,d,m,_s);

            _solutionOutput = halloweenSale.Solve().ToString();

            Console.WriteLine($"Problem {++probemNumber}: \n"+  _solutionOutput );


            //Problem 12: https://www.hackerrank.com/challenges/service-lane/problem?isFullScreen=true


            List<int> width = new List<int>() { 2, 3, 1, 2, 3, 2, 3, 3 };
            List<List<int>> cases = new List<List<int>>() { new List<int> { 0, 3 }, new List<int> { 4, 6 }, new List<int> { 6, 7 }, new List<int> { 3, 5 }, new List<int> { 0, 7 } };

            ServiceLane serviceLane = new ServiceLane(width, cases);

            _solutionOutput = string.Join("\n", serviceLane.Solve() );
            Console.WriteLine($"Problem {++probemNumber}: \n" + _solutionOutput);
        }
    }
}
