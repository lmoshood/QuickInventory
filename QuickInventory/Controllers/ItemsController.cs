using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickInventory.Models;
using QuickInventory.ViewModels;

namespace QuickInventory.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items/Random
        public ActionResult index()
        {
            var item = new Item()
            {
                Name = "Dog"
            };
            var itemModel = new ItemViewModel();
            itemModel.Items = new List<Item>();
            itemModel.Items.Add(item);
            itemModel.Items.Add(item);
            itemModel.Items.Add(item);
            return View(itemModel);
        }

        [Route("items/added/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByDateAdded(int year, int month)
        {

            return Content(year + "/" + month);
        }
    }
}