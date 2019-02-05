namespace Lesson4
{
    using System.Linq;

    public class Solution4a
    {
        public int solution(int[] A)
        {
            if (A.Length == 1)
            {
                if (A[0] == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            var m = A.Max();
            var counting = new int[m];

            for (var i=0;i<A.Length;i++)
            {
                var curr = counting[A[i] - 1];
                if (curr != 0)
                {
                    return 0;
                }

                counting[A[i] - 1]++;
            }

            foreach (var count in counting)
            {
                if(count == 0)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
