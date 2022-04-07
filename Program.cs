using System;
using System.Collections.Generic;

namespace HackerRankProblemSolving
{
    class Program
    {
        static string _solutionOutput;

        static void Main(string[] args)
        {

            //Problem 1: https://www.hackerrank.com/challenges/find-digits/problem?isFullScreen=true

            int n = 1012;

            FindDigits findDigits = new FindDigits(n);

            _solutionOutput = findDigits.Solve().ToString();

            Console.WriteLine( _solutionOutput );

            //------------------------------------------------------------------------------------------------

            //Problem 2: https://www.hackerrank.com/challenges/extra-long-factorials/problem?isFullScreen=true

            n = 25;

            ExtraLongFactorials extraLongFactorials = new ExtraLongFactorials(n);

            _solutionOutput = extraLongFactorials.Solve();

            Console.WriteLine( _solutionOutput );


            //------------------------------------------------------------------------------------------------

            //Problem 3: https://www.hackerrank.com/challenges/append-and-delete/problem?isFullScreen=true

            string s = "hackerhappy";
            string t = "hackerrank";
            int k = 9;

            AppendAndDelete appendAndDelete = new AppendAndDelete(s,t,k);

            _solutionOutput = appendAndDelete.Solve();

            Console.WriteLine(_solutionOutput);


            //------------------------------------------------------------------------------------------------

            //Problem 4: https://www.hackerrank.com/challenges/sherlock-and-squares/problem?isFullScreen=true

            int a = 24;
            int b = 49;

            SherlockAndSquares sherlockAndSquares = new SherlockAndSquares(a,b);

            _solutionOutput = sherlockAndSquares.Solve().ToString();

            Console.WriteLine(_solutionOutput);


            //------------------------------------------------------------------------------------------------

            //Problem 5: https://www.hackerrank.com/challenges/library-fine/problem?isFullScreen=true

            int d1 = 15, m1 = 7, y1 = 2014;
            int d2 = 1, m2 = 7, y2 = 2015;

            LibraryFIne libraryFIne = new LibraryFIne(d1,m1,y1,d2,m2,y2);

            _solutionOutput = libraryFIne.Solve().ToString();

            Console.WriteLine(_solutionOutput);


            //Problem 6: https://www.hackerrank.com/challenges/cut-the-sticks/problem?isFullScreen=true

            List<int> arr = new List<int>() { 5, 4, 4, 2, 2, 8 };

            CutTheSticks cutTheSticks = new CutTheSticks(arr);

            _solutionOutput = string.Join("\n", cutTheSticks.Solve());

            Console.WriteLine(_solutionOutput);

        }
    }
}
