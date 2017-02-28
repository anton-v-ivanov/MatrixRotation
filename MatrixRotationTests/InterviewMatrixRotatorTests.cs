using System.Linq;
using MatrixRotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixRotationTests
{
	[TestClass]
	public class InterviewMatrixRotatorTests
	{
		private static IMatrixRotator _sut;

		[TestInitialize]
		public void Prepare()
		{
			_sut = new InterviewMatrixRotator();
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
			expected[0] = new[] { 2, 3, 4, 5, 10 };
			expected[1] = new[] { 1, 8, 9, 14, 15 };
			expected[2] = new[] { 6, 7, 12, 13, 20 };
			expected[3] = new[] { 11, 16, 17, 18, 19 };

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
			expected[0] = new[] { 2, 3, 4, 8 };
			expected[1] = new[] { 1, 7, 11, 12 };
			expected[2] = new[] { 5, 6, 10, 16 };
			expected[3] = new[] { 9, 13, 14, 15 };

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
			expected[0] = new[] { 3, 4, 8, 12 };
			expected[1] = new[] { 2, 11, 10, 16 };
			expected[2] = new[] { 1, 7, 6, 15 };
			expected[3] = new[] { 5, 9, 13, 14 };

			var result = _sut.Rotate(matrix, r);

			for (var i = 0; i < expected.Length; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}

		[TestMethod]
		public void RotateSevenTimesTest()
		{
			var r = 7;
			var matrix = new int[5][];
			matrix[0] = new[] { 1, 2, 3, 4 };
			matrix[1] = new[] { 7, 8, 9, 10 };
			matrix[2] = new[] { 13, 14, 15, 16 };
			matrix[3] = new[] { 19, 20, 21, 22 };
			matrix[4] = new[] { 25, 26, 27, 28 };

			var expected = new int[5][];
			expected[0] = new[] { 28, 27, 26, 25 };
			expected[1] = new[] { 22, 9, 15, 19 };
			expected[2] = new[] { 16, 8, 21, 13 };
			expected[3] = new[] { 10, 14, 20, 7 };
			expected[4] = new[] { 4, 3, 2, 1 };

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

		[TestMethod]
		public void RotateFullBigCircleTest()
		{
			var r = 4*2+5*2-4;
			var matrix = new int[4][];
			matrix[0] = new[] { 1, 2, 3, 4, 5 };
			matrix[1] = new[] { 6, 7, 8, 9, 10 };
			matrix[2] = new[] { 11, 12, 13, 14, 15 };
			matrix[3] = new[] { 16, 17, 18, 19, 20 };

			var expected = new int[4][];
			expected[0] = new[] { 1, 2, 3, 4, 5 };
			expected[1] = new[] { 6, 9, 14, 13, 10 };
			expected[2] = new[] { 11, 8, 7, 12, 15 };
			expected[3] = new[] { 16, 17, 18, 19, 20 };

			var result = _sut.Rotate(matrix, r);

			for (var i = 0; i < expected.Length; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}
	}
}
