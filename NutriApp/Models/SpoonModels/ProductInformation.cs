namespace NutriApp.Models.SpoonModels
{
    public class ProductInformation
    {
        public string Name { get; set; }
        public float Amount { get; set; }
        public Units Unit { get; set; }
        public IList<Nutrients> Nutrition { get; set; } = new List<Nutrients>();
    }
}
