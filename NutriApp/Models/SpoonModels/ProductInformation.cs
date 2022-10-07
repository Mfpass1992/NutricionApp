using System.Linq;

namespace NutriApp.Models.SpoonModels
{
    public class ProductInformation
    {
        public string Name { get; set; }
        public float Amount { get; set; }
        public Units Unit { get; set; }
        public IList<Nutrients> Nutrition { get; set; } = new List<Nutrients>();
        public IList<Nutrients> BasicNutrients { get {
                var lookfor = new[] { "Calories", "Fat", "Saturated Fat", "Carbohydrates", "Protein" };
                return Nutrition.Where(o => lookfor.Any(l => l == o.Name)).ToList();
            } 
        }
    }
}
