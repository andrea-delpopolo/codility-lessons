namespace Lesson3c
{
    using System;
    using System.Collections.Generic;

    public class SolutionC
    {
        /*
        
        p=1 -> |a[0] - a[1]+a[2]+a[3]+a[4]|
        p=2 -> |a[0]+a[1] - a[2]+a[3]+a[4]|
        p=3 -> |a[0]+a[1]+a[2] - a[3]+a[4]|
        p=4 -> |a[0]+a[1]+a[2]+a[3] - a[4]|
 
        */
        public int solution(int[] A)
        {
            if (A.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            var sumOfRight = 0;
            var sumOfLeft = A[0];
            var stack = new Stack<int>();
            var index = A.Length - 1;
            while(index > 0)
            {
                sumOfRight += A[index];
                stack.Push(A[index--]);
            }

            var min = Math.Abs(sumOfLeft - sumOfRight);

            for(int p=2;p<A.Length;p++)
            {
                var oneFromRight = stack.Pop();
                sumOfLeft += oneFromRight;
                sumOfRight -= oneFromRight;
                var currMin = Math.Abs(sumOfLeft - sumOfRight);
                if(currMin < min)
                {
                    min = currMin;
                }

                if(currMin == 0)
                {
                    return 0; // absolute minimum, we short-circuit and exit.
                }
            }

            return min;
        }
    }
}
