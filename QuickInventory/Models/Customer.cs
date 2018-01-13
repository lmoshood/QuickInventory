using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuickInventory.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribed { get; set; }
        public MemberType MemberType { get; set; }
        public int MemberTypeId { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}