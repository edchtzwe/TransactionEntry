using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TransactionEntry.ActionFilters;

namespace TransactionEntry.Controllers
{
    //[MyLogActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return WelcomeMessage();
        }
        [ActionName("Today")]
        public string GetToday()
        {
            return DateTime.Today.ToString();
        }
        [NonAction]
        public string WelcomeMessage()
        {
            return "Transaction Entry App Home";
        }
    }
}