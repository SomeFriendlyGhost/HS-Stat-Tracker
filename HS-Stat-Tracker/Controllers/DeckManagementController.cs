using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_Stat_Tracker.Controllers
{
    public class DeckManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
