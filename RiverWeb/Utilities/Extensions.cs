using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RiverWeb.Utilities
{
    public static class Extensions
    {
        public static string IsActive(this IHtmlHelper html, string control, string action)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = routeData.Values["action"].ToString();
            var routeControl = routeData.Values["controller"].ToString();

            var returnActive = action == routeAction && control == routeControl;

            return returnActive ? "active" : "";
        }
    }
}
