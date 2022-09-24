using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriApp.Models.EF
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string? Description { get; set; }
        public byte[]? Image { get; set; }

        public Category Category { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
