using LinkShortenService.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkShortenService.Site.Helpers
{
    public static class HttpContextHelper
    {
        public static LinkShortenDBEntities LinkShortenContext
        {
            get
            {
                return GetFromContext("linkShortenContext", () => new LinkShortenDBEntities());
            }
        }

        public static T GetFromContext<T>(string key, Func<T> lambda)
        {
            return (T)(HttpContext.Current.Items[key] ?? (HttpContext.Current.Items[key] = lambda()));
        }
    }
}