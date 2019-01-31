namespace Lesson2
{
    using System.Linq;
    using System.Collections.Generic;

    public class Solution
    {
        public int Solve(int[] A)
        {
            var map = new Dictionary<int, int>();
            
            for(var i = 0; i< A.Length; i++)
            {
                var currentInteger = A[i];
                if (!map.ContainsKey(currentInteger))
                {
                    map.Add(currentInteger, 1);
                }
                else
                {
                    map[currentInteger]++;
                }
            }

            return map.FirstOrDefault(count => count.Value % 2 > 0).Key;
        }
    }
}
