namespace Lesson2b
{
    using System;

    public class Solution
    {
        public int[] Solve(int[] A, int K)
        {
            if (A.Length == 0)
            {
                return A;
            }

            for (int i = 1; i <= K; i++)
            {
                var first = A[0];
                var last = A[A.Length - 1];

                var prev = first;
                for (int j = 1; j < A.Length; j++)
                {
                    var curr = A[j];
                    A[j] = prev;
                    prev = curr;
                }

                A[0] = last;
            }

            return A;
        }
    }
}
