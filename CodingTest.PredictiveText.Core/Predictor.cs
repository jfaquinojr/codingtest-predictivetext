using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.PredictiveText.Core
{
	public class TextPredictor : IPredictor<int, string>
	{

		public List<string> Predict(int codes, List<string> list)
		{

			List<string> result = list;
			string theCodes = codes.ToString();
			if(theCodes.Length == 0)
			{
				return result;
			}

			// get the equivalent letters for each code and filter as many times as needed
			for(int i = 0; i < theCodes.Length; i++)
			{
				var code = theCodes[i];

				var letters = getEquivalentLetters(code);

				var tempResult = new List<string>();
				foreach (char letter in letters)
				{
					tempResult.AddRange(result.FindAll((s) => { return s.IndexOf(letter.ToString(), i, 1, StringComparison.InvariantCultureIgnoreCase) >= 0; }));
				}
				result = tempResult;
			}

			return result;
		}


		private char[] getEquivalentLetters(char code)
		{
			/*
				2 - A, B, C
				3 - D, E, F
				4 - G, H, I
				5 - J, K, L
				6 - M, N, O
				7 - P, Q, R, S
				8 - T, U, V
				9 - W, X, Y, Z
			*/

			// we decided to implement as a simple switch statement. 
			// but the table could also be represented by something
			// else, a dictionary for example.
			switch (code)
			{
				case '2':
					return "ABC".ToArray();
				case '3':
					return "DEF".ToArray();
				case '4':
					return "GHI".ToArray();
				case '5':
					return "JKL".ToArray();
				case '6':
					return "MNO".ToArray();
				case '7':
					return "PQRS".ToArray();
				case '8':
					return "TUV".ToArray();
				case '9':
					return "WXYZ".ToArray();
				default:
					return "".ToArray();
					
			}
		}


	}
}
