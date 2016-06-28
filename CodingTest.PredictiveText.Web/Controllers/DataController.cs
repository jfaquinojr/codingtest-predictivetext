using CodingTest.PredictiveText.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodingTest.PredictiveText.Web.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
			var data = new Data();
			return View(data.GetAllWords().ToList());
        }

		public JsonResult Predict(string text)
		{
			int code;
			if(!int.TryParse(text, out code))
			{
				return Json(null, JsonRequestBehavior.AllowGet);
			}

			var predictor = new TextPredictor();
			var data = new Data();

			return Json(predictor.Predict(code, data.GetAllWords().ToList()), JsonRequestBehavior.AllowGet);
		}
    }
}