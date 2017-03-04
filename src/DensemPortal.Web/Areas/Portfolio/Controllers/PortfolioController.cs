using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DensemPortal.Web.Areas.Portfolio.Controllers
{
    [Area("Portfolio")]
    [Route("portfolio")]
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("puzzle")]
        public IActionResult Puzzle()
        {
            return View();
        }
    }
}