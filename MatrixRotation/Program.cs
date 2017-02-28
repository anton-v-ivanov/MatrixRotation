using System;
using System.Linq;

namespace MatrixRotation
{
	public class Program
	{
		static void Main()
		{
			var tokens = Console.ReadLine().Split(' ');
			var m = Convert.ToInt32(tokens[0]);
			var n = Convert.ToInt32(tokens[1]);
			var r = Convert.ToInt32(tokens[2]);
			var matrix = new int[m][];
			for (var i = 0; i < m; i++)
			{
				matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			}

			var rotator = new InterviewMatrixRotator();
			var result = rotator.Rotate(matrix, r);
			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < m; j++)
				{
					Console.Write(result[i][j]);
					Console.Write(" ");
				}
				Console.WriteLine();
			}
		} 
	}
}