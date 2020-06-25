using System.Web;
using System.Web.Mvc;

namespace LeTAnhDieu_1711061517
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
