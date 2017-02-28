using System.Linq;
using MatrixRotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixRotationTests
{
	[TestClass]
	public class ClockwiseMatrixRotatorTests
	{
		private static IMatrixRotator _sut;

		[TestInitialize]
		public void Prepare()
		{
			_sut = new ClockwiseRotator();
		}

		[TestMethod]
		public void RotateOneMoreTimeTest()
		{
			var r = 1;
			var matrix = new int[4][];
			matrix[0] = new[] { 1, 2, 3, 4, 5 };
			matrix[1] = new[] { 6, 7, 8, 9, 10 };
			matrix[2] = new[] { 11, 12, 13, 14, 15 };
			matrix[3] = new[] { 16, 17, 18, 19, 20 };

			var expected = new int[4][];
			expected[0] = new[] { 6, 1, 2, 3, 4 };
			expected[1] = new[] { 11, 12, 7, 8, 5 };
			expected[2] = new[] { 16, 13, 14, 9, 10 };
			expected[3] = new[] { 17, 18, 19, 20, 15 };

			
			var result = _sut.Rotate(matrix, r);

			for (var i = 0; i < expected.Length; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}

		[TestMethod]
		public void RotateOneTimeTest()
		{
			var r = 1;
			var matrix = new int[4][];
			matrix[0] = new[] { 1, 2, 3, 4 };
			matrix[1] = new[] { 5, 6, 7, 8 };
			matrix[2] = new[] { 9, 10, 11, 12 };
			matrix[3] = new[] { 13, 14, 15, 16 };

			var expected = new int[4][];
			expected[0] = new[] { 5, 1, 2, 3 };
			expected[1] = new[] { 9, 10, 6, 4 };
			expected[2] = new[] { 13, 11, 7, 8 };
			expected[3] = new[] { 14, 15, 16, 12 };

			var result = _sut.Rotate(matrix, r);

			for (var i = 0; i < expected.Length; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}

		[TestMethod]
		public void RotateTwoTimesTest()
		{
			var r = 2;
			var matrix = new int[4][];
			matrix[0] = new[] { 1, 2, 3, 4 };
			matrix[1] = new[] { 5, 6, 7, 8 };
			matrix[2] = new[] { 9, 10, 11, 12 };
			matrix[3] = new[] { 13, 14, 15, 16 };

			var expected = new int[4][];
			expected[0] = new[] { 9, 5, 1, 2 };
			expected[1] = new[] { 13, 11, 10, 3 };
			expected[2] = new[] { 14, 7, 6, 4 };
			expected[3] = new[] { 15, 16, 12, 8 };

			var result = _sut.Rotate(matrix, r);

			for (var i = 0; i < expected.Length; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}

		[TestMethod]
		public void RotateThreeTimesTest()
		{
			var r = 3;
			var matrix = new int[2][];
			matrix[0] = new[] { 1, 1 };
			matrix[1] = new[] { 1, 1 };

			var expected = new int[2][];
			expected[0] = new[] { 1, 1 };
			expected[1] = new[] { 1, 1 };

			var result = _sut.Rotate(matrix, r);

			for (var i = 0; i < expected.Length; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}
	}
}
