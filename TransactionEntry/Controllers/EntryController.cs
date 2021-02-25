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
        public string Search(string query)
        {
            var input = Server.HtmlEncode(query);
            return input;
        }
    }
}