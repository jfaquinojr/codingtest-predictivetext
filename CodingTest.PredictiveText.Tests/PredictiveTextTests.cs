using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingTest.PredictiveText.Core;
using System.Linq;

namespace CodingTest.PredictiveText.Tests
{
	[TestClass]
	public class PredictiveTextTests
	{
		private string[] _testWords = new string[]
		{
				"Test",
				"dog",
				"Bode",
				"hello",
				"world",
				"foo",
				"Code",
				"bar"
		};

		/* 
		 * For reference, here is Code table
			2 - A, B, C
			3 - D, E, F
			4 - G, H, I
			5 - J, K, L
			6 - M, N, O
			7 - P, Q, R, S
			8 - T, U, V
			9 - W, X, Y, Z
		*/

		[TestMethod]
		public void Test2633IsCodeAndBode()
		{
			var predictor = new TextPredictor();
			var results = predictor.Predict(2633, _testWords.ToList());

			Assert.IsTrue(results.Contains("Code"));
			Assert.IsTrue(results.Contains("Bode"));
			Assert.IsTrue(results.Count == 2);
		}

		[TestMethod]
		public void TestfooIs366()
		{
			var predictor = new TextPredictor();
			var results = predictor.Predict(366, _testWords.ToList());

			Assert.IsTrue(results.Contains("foo"));
			Assert.IsTrue(results.Count == 1);
		}

		[TestMethod]
		public void TestNoMatch()
		{
			var predictor = new TextPredictor();
			var results = predictor.Predict(777, _testWords.ToList());

			Assert.IsTrue(results.Count == 0);
		}

		[TestMethod]
		public void TestNoIndexOutOfRange()
		{
			var predictor = new TextPredictor();
			var results = predictor.Predict(435566893, _testWords.ToList());

			Assert.IsTrue(true);
		}
	}
}
