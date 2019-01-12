using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        public IActionResult Index(int num = 7)
        {
            return new ContentResult { Content = new Lucky7().Output(num), ContentType="text/html"};
        }
    }
}