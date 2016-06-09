using System;
using System.Web.Optimization;

namespace LinkShortenService.Site
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new StyleBundle("~/bundles/css/").Include
                (
                    "~/Content/Css/Bootstrap/*.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app/libs/")
                .Include("~/App/Libraries/jQuery/jquery-1.9.1.js")
                .Include("~/App/Libraries/Bootstrap/bootstrap.js")
                .Include("~/App/Libraries/Core/angular.js")
                .Include("~/App/Libraries/Core/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/app/webapp/")
                .Include("~/App/App.js")
                .Include("~/App/Resources/*Module.js").Include("~/App/Resources/*.js")
                .Include("~/App/Controllers/LinkShortenModule.js").Include("~/App/Controllers/*Controller.js"));

        }
    }
}