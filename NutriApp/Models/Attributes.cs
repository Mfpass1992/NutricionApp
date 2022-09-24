using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriApp.Models
{
    public class Attributes
    {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string Notes { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
