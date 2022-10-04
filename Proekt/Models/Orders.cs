using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proekt.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        public int Id { get; set; }
        [ForeignKey(nameof(Id))]
        public Proizvodi Proizvodi { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}