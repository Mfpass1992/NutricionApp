using NutriApp.Models.SpoonModels;

namespace NutriApp.WebAPI
{
    public interface ISpoonApiCaller
    {
        Task<ProductInformation> GetProductInfoById(int id);
        Task<List<ProductSelectionItem>> GetProductsByName(string name);
    }
}