using Newtonsoft.Json.Linq;
using NutriApp.Models.SpoonModels;
using System.Text.Json;

namespace NutriApp.WebAPI
{
    public class SpoonApiCaller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<ProductSelectionItem>> GetProductsByName(string name)
        {
           //TODO: Secure apiKey
           var response = await client.GetAsync("https://api.spoonacular.com/food/ingredients/search?" +
                "query=" + name + "&number=5" + "&apiKey=1d0fb0f11dc5437e8057f1cce707ab3f");

            string responseBody = await response.Content.ReadAsStringAsync();

            var root = JObject.Parse(responseBody);
            var results = root["results"].Children().ToList();

            IList<ProductSelectionItem> products = new List<ProductSelectionItem>();
            foreach (JToken result in results)
            {
                ProductSelectionItem product = result.ToObject<ProductSelectionItem>();
                products.Add(product);
            }

            return products.ToList();
        }

        public async Task<ProductInformation> GetProductInfoById(int id)
        {
            //GET https://api.spoonacular.com/food/ingredients/9266/information?amount=1
            var response = await client.GetAsync("https://api.spoonacular.com/food/ingredients/" + id
                + "/information?" + "apiKey=1d0fb0f11dc5437e8057f1cce707ab3f" + "&unit=g&amount=100");

            string responseBody = await response.Content.ReadAsStringAsync();
            var root = JObject.Parse(responseBody);

            ProductInformation productInfo = new ProductInformation();
            productInfo.Name = root["name"].ToString();
            Enum.TryParse(root["unit"].ToString(), out Units EUnit);
            productInfo.Unit = EUnit;
            productInfo.Amount = float.Parse(root["amount"].ToString());
            foreach (var n in root["nutrition"]["nutrients"])
            {
                Nutrients nutrition = new Nutrients();
                nutrition.Name = n["name"].ToString();
                nutrition.Amount = float.Parse(n["amount"].ToString());
                Enum.TryParse(n["unit"].ToString(), out Units NUnit);
                nutrition.Unit = NUnit;
                nutrition.PercentOfDailyNeeds = float.Parse(n["percentOfDailyNeeds"].ToString());
                productInfo.Nutrition.Add(nutrition);
            }

            return productInfo;
        }
    }
}
