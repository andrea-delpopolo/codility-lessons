namespace Lesson1
{
	using System;

	public class Solution
	{
		/// <summary>
		/// Given a positive integer N, returns the length of its longest binary gap
		/// </summary>
		/// <param name="N">
		/// A positive integer
		/// </param>
		/// <returns>
		/// The length of the input's longest binary gap
		/// </returns>
		/// <remarks>
		/// Complexity -> O(log2(N)) where N is the given input
		/// </remarks>
		public int Solve(int N)
		{
			if (N <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}

			var digits = Convert.ToString(N, 2);

			int biggestGap = 0;
			int gap = 0;
			var state = SearchState.Init;
			foreach (var digit in digits)
			{
				if (digit == '0')
				{
					switch (state)
					{
						case SearchState.Init:
							break;
						case SearchState.Found_1:
							state = SearchState.Counting_0;
							gap++;
							break;
						case SearchState.Counting_0:
							gap++;
							break;
					}
				}
				else
				{
					switch (state)
					{
						case SearchState.Init:
							state = SearchState.Found_1;
							break;
						case SearchState.Counting_0:
							state = SearchState.Found_1;
							if (gap > biggestGap)
							{
								biggestGap = gap;
							}
							gap = 0;
							break;
						case SearchState.Found_1:
							break;
					}
				}
			}

			return biggestGap;
		}
	}

	public enum SearchState
	{
		Init,
		Found_1,
		Counting_0
	}
}
