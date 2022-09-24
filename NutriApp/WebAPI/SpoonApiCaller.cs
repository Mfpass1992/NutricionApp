using NutriApp.Models.SpoonModels;
using System.Text.Json;

namespace NutriApp.WebAPI
{
    public class SpoonApiCaller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task GetProductsByName(string name)
        {
           var response = await client.GetAsync("https://api.spoonacular.com/food/ingredients/search?" +
                "query=" + name + "&number=5" + "&apiKey=1d0fb0f11dc5437e8057f1cce707ab3f");

            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }

    }
}
