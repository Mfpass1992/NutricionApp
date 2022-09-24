namespace NutriApp.Models.SpoonModels
{
    public class ProductInformation
    {
        public string Name { get; set; }
        public float Ammount { get; set; }
        public Units Unit { get; set; }
        public IEnumerable<Nutrients> Nutrition { get; set; }
    }
}
