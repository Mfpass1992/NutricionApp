namespace NutriApp.Models.SpoonModels
{
    public class RecipeIngredientModel
    {
        public double Amount { get; set; }
        public int Id { get; set; }
        public IEnumerable<string> meta { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}