namespace NutriApp.Models
{
    public class BMIEntry
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public BMIEntry(int weight, int height)
        {
            Weight = weight;
            Height = height;
        }

        public double BMI
        {
            get {
                double v = Convert.ToDouble(Weight);
                double h = Convert.ToDouble(Height);
                return Math.Round(v / Math.Pow(h / 100.0, 2), 2); 
            }
        }
    }

}
