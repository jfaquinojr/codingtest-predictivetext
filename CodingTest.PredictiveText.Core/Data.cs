using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.PredictiveText.Core
{
	public class Data
	{
		private string[] _sortedWords;
		public Data()
		{
			// in real world app, this could come from a database
			_sortedWords = new string[]
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

			Array.Sort(_sortedWords);
		}
		public Data(string[] words)
		{
			Array.Sort(words);
			Array.Copy(words, _sortedWords, words.Length);
		}

		public string[] GetAllWords()
		{
			return _sortedWords;
		}
	}
}
