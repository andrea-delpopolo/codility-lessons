namespace Lesson3b
{
    using System.Collections.Generic;

    public class SolutionB
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
            {
                return 1;
            }
            var hashSet = new HashSet<int>(A);
            for (var i = 1; i <= A.Length + 1; i++)
            {
                if (!hashSet.Contains(i))
                {
                    return i;
                }
            }
            return -1; // ? we should not be here.
        }
    }
}
