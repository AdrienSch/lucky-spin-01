using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Lucky7 _luckySpinner;
        public SpinnerController(Lucky7 lucky7)
        {
            _luckySpinner = lucky7;
        }

        public IActionResult Index(int luck = 7)
        {
            return new ContentResult { Content = _luckySpinner.Output(luck), ContentType="text/html"};
        }
    }
}