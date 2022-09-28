using Microsoft.AspNetCore.Mvc;
using NutriApp.Models.SpoonModels;
using NutriApp.WebAPI;

namespace NutriApp.Controllers
{
    public class ProductInfoController : Controller
    {
        private readonly ISpoonApiCaller _spoonApiCaller;

        public ProductInfoController(ISpoonApiCaller spoonApiCaller)
        {
            _spoonApiCaller = spoonApiCaller;
        }

        public IActionResult Index(string? name)
        {
            ViewData["ProductSelectionList"] = new List<ProductSelectionItem>();

            if (name != null)
            {
                var products = _spoonApiCaller.GetProductsByName(name);
                ViewData["ProductSelectionList"] = products.Result;
            }

            return View();
        }


        [HttpGet]
        public JsonResult GetProductInformation(int productId)
        {
            ProductInformation product = _spoonApiCaller.GetProductInfoById(productId).Result;

            if (product == null)
            {
                // TODO
            }

            return Json(product);
        }
    }
}
