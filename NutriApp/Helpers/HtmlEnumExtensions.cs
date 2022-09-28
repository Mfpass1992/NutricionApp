using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace NutriApp.Helpers
{
    public static class EnumProviderExtensions
    {
        public static HtmlString EnumToString<T>(this IHtmlHelper helper)
        {
            var values = Enum.GetValues(typeof(T)).Cast<int>();
            var enumDict = values.ToDictionary(value => Enum.GetName(typeof(T), value));

            return new HtmlString(JsonConvert.SerializeObject(enumDict));
        }

        public static String HelloWorldString(this IHtmlHelper htmlHelper)
             => "<strong>Hello World</strong>";
    }
}
