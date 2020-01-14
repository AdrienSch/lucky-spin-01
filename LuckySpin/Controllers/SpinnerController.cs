using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        ILuckySpin _luckySpinner;
        public SpinnerController(ILuckySpin lucky)
        {
            _luckySpinner = lucky;
        }

        public IActionResult Index(int luck = 7)
        {
            return new ContentResult { Content = _luckySpinner.Output(luck), ContentType="text/html"};
        }
    }
}