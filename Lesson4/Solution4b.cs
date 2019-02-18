namespace Lesson4
{
    using System.Linq;

    public class Solution4b
    {
        public int solution(int X, int[] A)
        {
            if (A.Length < X)
            {
                return -1;
            }

            var buffer = new bool[X];

            bool isCompletePath = false;
            int index = 0;

            while(!isCompletePath)
            {
                var el = A[index];
                if (el - 1 <= buffer.Length)
                {
                    buffer[el - 1] = true;
                }
                else
                {
                    continue;
                }
                
                isCompletePath = (index + 1 >= X) && !buffer.Any(e => e == false);

                if (!isCompletePath && index == A.Length - 1)
                {
                    return -1;
                }

                index++;
            }

            return index - 1;
        }
    }
}
