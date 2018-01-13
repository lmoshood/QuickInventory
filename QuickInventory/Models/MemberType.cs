using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickInventory.Models
{
    public class MemberType
    {
        public int Id { get; set; }
        public int SignUpFee { get; set; }
        public int DurationMonths { get; set; }
        public int DiscountRate { get; set; }
        public string Name { get; set;}
    }
}