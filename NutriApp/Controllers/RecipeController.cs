using Microsoft.AspNetCore.Mvc;
using NutriApp.Models.SpoonModels;
using NutriApp.WebAPI;

namespace NutriApp.Controllers
{
    public class RecipeController : Controller
    {
        private readonly ISpoonApiCaller _apiCaller;
        public RecipeController(ISpoonApiCaller apiCaller)
        {
            _apiCaller = apiCaller;
        }
        public List<ProductSelectionItem> GetProducts(string name)
        {
            List<ProductSelectionItem> products = _apiCaller.GetProductsByName(name).Result;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
