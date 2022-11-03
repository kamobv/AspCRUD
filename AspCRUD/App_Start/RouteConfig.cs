using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspCRUD
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "MovieDetails",
            //    url: "movies/details/{movieId}/{movieName}",
            //    defaults: new { controller = "Movies", action = "Details", movieId  = UrlParameter.Optional, movieName = UrlParameter.Optional}
            //    );

            routes.MapRoute(
            name: "MovieDetails2",
            url: "filmlər/ətraflı/{movieId}/{movieName}",
            defaults: new { controller = "Movies", action = "Details", movieId = UrlParameter.Optional, movieName = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Contact",
            url: "Ətraflı",
            defaults: new { controller = "Home", action = "Contact"}
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
