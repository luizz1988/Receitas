using System.Web;
using System.Web.Mvc;

namespace OnHelp.Api.Receitas.Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
