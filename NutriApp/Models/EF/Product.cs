using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriApp.Models.EF
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AttributesId { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string? Description { get; set; }
        public double EnergyValue { get; set; }
        public int Proteins { get; set; }
        public int Lipids { get; set; }
        public int CarboHydrates { get; set; }
        public byte[]? Image { get; set; }

        public Category Category { get; set; }
        public ICollection<Attributes> Attributes { get; set; }
    }
}
