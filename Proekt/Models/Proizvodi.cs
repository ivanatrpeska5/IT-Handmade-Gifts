
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proekt.Models
{
    public class Proizvodi
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        //public string Colour { get; set; }
        //public Colour Colour { get; set; }
        //public List<string>Colours { get; set; }
    }
}
