using Microsoft.AspNetCore.Mvc;
using Cardiovascular_Disease_DetectionML.Model;

namespace Cardiovascular_Disease_Detection.Controllers
{
    public class CardiovascularDiseaseController : Controller
    {
        [HttpGet]
        public IActionResult Predict()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Predict(ModelInput input)
        {
            var prediction = ConsumeModel.Predict(input);
            ViewBag.Result = prediction;
            return View();
        }
    }
}
