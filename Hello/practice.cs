using System;

namespace Hello
{
	public class practice
	{
		public delegate int Multipier (int i);

		static void Main (string[] args)
		{
			
			Multipier f1 = i => i * 2;

			int[] array = new int[]{ 4,6,7,-2,47};
			int[] doubled = DoubleElements (array);





			Console.WriteLine (f1 (5));
			Console.WriteLine (DoFiveTimes(2,f1));
		}

		static int DoFiveTimes(int i, Multipier f)
		{
			return f(f(f(f(f (i)))));
		}

		static int DoNTimes(int i, int n, Multipier f)
		{
			int value = i;

			for (int x = 0; x < n; x++) 
			{
				
			}

		}

		static int[] DoubleElements( int[] input)
		{
			int[] output = new int[input.Length];
			
			for(int i=0; i<input.Length; i++)
			{
				output [i] = input [i] * 2;
			}
			return output;
		}
	}
}

