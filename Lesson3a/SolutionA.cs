namespace Lesson3a
{
    public class SolutionA
    {
        public int solution(int X, int Y, int D)
        {
            var distance = Y - X;
            var mod = distance % D;
            var steps = distance / D;
            return mod == 0 ? steps : steps + 1;
        }
    }
}
