using System;

namespace MatrixRotation
{
	public class ClockwiseRotator : IMatrixRotator
	{
		/// <summary>
		/// Rotate matrix in anti-clockwise direction r times
		/// </summary>
		/// <param name="matrix">Initial matrix</param>
		/// <param name="r">Number of rotations</param>
		/// <returns>Rotated matrix</returns>
		public int[][] Rotate(int[][] matrix, int r)
		{
			var height = matrix.GetLength(0);
			var width = matrix[0].GetLength(0);

			var layers = Math.Min(width, height) / 2; // number of rotation 'rings'

			for (var layerNum = 0; layerNum < layers; layerNum++)
			{
				// get number of rotations needed for full circle rotation
				var fullCircleRotationsNeeded = height * 2 + width * 2 - 8 * layerNum - 4;
				// get the real number of needed rotations
				var numRotations = r % fullCircleRotationsNeeded;

				for (var rotation = 0; rotation < numRotations; rotation++)
				{
					var lastColumn = width - layerNum - 1;
					var lastRow = height - layerNum - 1;

					// Rotate top row to the left
					for (var i = lastColumn; i > layerNum; i--)
					{
						var prev = matrix[layerNum][i];
						matrix[layerNum][i] = matrix[layerNum][i - 1];
						matrix[layerNum][i - 1] = prev;
					}

					// Rotate left column down
					for (var i = layerNum; i < lastRow; i++)
					{
						var prev = matrix[i][layerNum];
						matrix[i][layerNum] = matrix[i + 1][layerNum];
						matrix[i + 1][layerNum] = prev;
					}

					// Rotate bottom row to the right
					for (var i = layerNum; i < lastColumn; i++)
					{
						var prev = matrix[lastRow][i];
						matrix[lastRow][i] = matrix[lastRow][i + 1];
						matrix[lastRow][i + 1] = prev;
					}

					// Rotate right column up
					for (var i = lastRow; i > layerNum + 1; i--)
					{
						var prev = matrix[i][lastColumn];
						matrix[i][lastColumn] = matrix[i - 1][lastColumn];
						matrix[i - 1][lastColumn] = prev;
					}
				}
			}

			return matrix;
		}
	}
}
