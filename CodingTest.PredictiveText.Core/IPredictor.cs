using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.PredictiveText.Core
{
	public interface IPredictor<TCode, TValue>
	{
		List<TValue> Predict(TCode code, List<TValue> list);
	}
}
