using System.Web;
using System.Web.Mvc;

namespace monetarios_para_extenso
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
