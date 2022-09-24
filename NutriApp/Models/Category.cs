using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string? Description { get; set; }
        public byte[]? Image { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
