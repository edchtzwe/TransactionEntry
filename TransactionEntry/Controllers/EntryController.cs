using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransactionEntry.Controllers
{
    public class EntryController : Controller
    {
        // GET: Entry
        [HttpGet]
        public ActionResult Search(string query)
        {
            var input = Server.HtmlEncode(query);
            return Content(input);
        }
        public string GetAllEntries()
        {
            return @"<ul>
            <li>One</li>
            <li>Two</li>
            <li>Three</li>
            </ul>";
        }
        public ActionResult ReturnHome()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}