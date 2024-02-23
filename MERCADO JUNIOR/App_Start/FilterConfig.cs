using System.Web;
using System.Web.Mvc;

namespace MERCADO_JUNIOR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
