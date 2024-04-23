using Microsoft.AspNetCore.Mvc;

namespace BotoxCalculator.Controllers
{
    using BotoxCalculator.Models;
    using Microsoft.AspNetCore.Mvc;

    public class BotoxController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(BotoxCalculatorModel model)
        {
            double result;
            if (model.SyringeVolume == 1.0)
            {
                result = (model.SyringeVolume / model.DilutionVolume * model.UnitsCount) / 100 * model.SyringeVolume;
            }
            else
            {
                result = ((model.SyringeVolume / model.DilutionVolume * model.UnitsCount) / 100 * model.SyringeVolume) * 2;
            }

            ViewBag.Result = result;
            return View("Index");
        }
    }

}
