using System;
using System.Linq;

namespace codility_test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    public static class Task1
    {
        public static int Function(int[] A)
        {
            if (A.Length == 0)
                return 0;

            var yMax = A.Max();

            if (A.Length <= 2)
                return yMax;

            bool brushToggle = false;
            int brushCount = 0;
            for (var y = 1; y <= yMax; y++)
            {
                for (var x = 0; x < A.Length; x++)
                {
                    if (A[x] >= y)
                        brushToggle = true;
                    else if (brushToggle)
                    {
                        brushCount++;
                        brushToggle = false;
                    }

                    if (brushCount > 1000000000)
                        return -1;
                }

                if (brushToggle)
                {
                    brushCount++;
                    brushToggle = false;
                }
            }

            return brushCount;
        }
    }

    public static class Task2
    {
        public static int Function(int[] A)
        {
            int N = A.Length;
            int result = 0;
            for (int i = 0; i < N; i++)
                for (int j = N - 1; j > i; j--)
                    if (A[i] != A[j])
                        result = Math.Max(result, j - i);

            return 0;
        }
    }

    public static class Task3
    {
        public static int Function(int[] A, int K)
        {
            int n = A.Length;
            int best = 0;
            int count = 0;
            for (int i = 0; i < n - K - 1; i++)
            {
                if (A[i] == A[i + 1])
                    count = count + 1;
                else
                    count = 0;
                if (count > best)
                    best = count;
            }
            int result = best + 1 + K;

            return result;
        }
    }
}