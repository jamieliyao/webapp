using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly CMDBContext _cMDBContext;

        public HomeController(CMDBContext cMDBContext)
        {
            _cMDBContext = cMDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult SubPage()
        {
            return View();
        }
        public IActionResult EmailSys()
        {
            return View();
        }
        public IActionResult VirtualSys()
        {
            return View();
        }
        public IActionResult PrinterSys()
        {
            return View();
        }
        public IActionResult MonitorSys()
        {
            return View();
        }
        public IActionResult SCOMSys()
        {
            return View();
        }
        public IActionResult SCCMSys()
        {
            return View();

        }
        public IActionResult Page2()
        {
            return View();
        }
        public IActionResult serverCon()
        {
            return View();
        }
        public IActionResult servicesPriCon()
        {
            return View();
        }
        public IActionResult LogCon()
        {
            var list = _cMDBContext.EventLogs.GroupBy(x => x.EventId).Select(x => new EventLogsViewModel
            {
                Count = x.Count(),
                Description = x.FirstOrDefault().Description,
                EventId = x.FirstOrDefault().EventId
            }).ToList();
            return View(list);
        }
        public IActionResult MainListCon()
        {
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult PrintServices()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
