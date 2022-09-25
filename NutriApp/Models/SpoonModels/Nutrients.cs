namespace NutriApp.Models.SpoonModels
{
    public class Nutrients
    {
        public string Name { get; set; }
        public float Amount { get; set; }
        public Units Unit { get; set; }
        public float PercentOfDailyNeeds { get; set; }
    }
}
