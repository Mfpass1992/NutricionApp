namespace NutriApp.Models.SpoonModels
{
    public class RecipeModel
    {
        public int Id { get; set; }
        public int MissedIngredientCount { get; set; }
        public List<RecipeIngredientModel> MissingIngredients { get; set; }
        public string Title { get; set; }
        public List<RecipeIngredientModel> UnusedIngredients { get; set; }
        public int UsedIngredientCount { get; set; }
        public List<RecipeIngredientModel> UsedIngredients { get; set; }

    }
}
