using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickInventory.Models;

namespace QuickInventory.ViewModels
{
    public class RandomViewModel
    {
        public Item Item { get; set; }
        public List<Customer> Customers { get; set; }
    }
}