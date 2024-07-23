using System.Web.Mvc;
using System.Web.Routing;

namespace MvcProjeKampi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
      name: "Heading",
      url: "Heading/{action}/{id}",
      defaults: new { controller = "Heading", action = "Index", id = UrlParameter.Optional }
  );



            // Diğer özel yönlendirme kuralları ekleyebilirsiniz
        }
    }
}
