using System.Web;
using System.Web.Mvc;

namespace ISE309_ProjeOdev_B181200039_B181200028
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
