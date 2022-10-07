using Microsoft.AspNetCore.Mvc;
using NutriApp.Models;

namespace NutriApp.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index(int? weight, int? height)
        {
            if (weight.HasValue && height.HasValue)
            {
                BMIEntry entry = new BMIEntry(weight.Value, height.Value);
                var r = entry.BMI;
                return View(entry);
            }
            return View();
        }

        public static string GetWeightCategory(double bmi)
        {
            switch (bmi)
            {
                case < 16:
                    return "Severe Thinness";
                case <= 17:
                    return "Moderate Thinness";
                case <= 18.5:
                    return "Mild Thinness";
                case <= 25:
                    return "Normal";
                case <= 30:
                    return "Overweight";
                case <= 35:
                    return "Obese Class I";
                case <= 40:
                    return "Obese Class II";
                case > 40:
                    return "Obese Class III";
            }
            return "";
        }

        public static double GetLowRangeForHeight(int height)
        {
            double _height = Convert.ToDouble(height);
            return Math.Round(18.5 * Math.Pow(_height/100, 2));
        }

        public static double GetHighRangeForHeight(int height)
        {
            double _height = Convert.ToDouble(height);
            return Math.Round(25 * Math.Pow(_height/100, 2));
        }

        public static double HowMuchToLose(BMIEntry entry)
        {
            var toLose = entry.BMI - 25;
            var power = Math.Pow(Convert.ToDouble(entry.Height) / 100, 2);
            var result = toLose * power;

            return Math.Round(result, 2);
        }

        public static double HowMuchToGain(BMIEntry entry)
        {
            var toLose = 18.5 - entry.BMI;
            var power = Math.Pow(Convert.ToDouble(entry.Height) / 100, 2);
            var result = toLose * power;

            return Math.Round(result, 2);
        }
    }
}
