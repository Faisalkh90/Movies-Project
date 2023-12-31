﻿using System.Web;
using System.Web.Optimization;

namespace MoviesDB
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/OwlCarousel2-2.3.4-js/owl.carousel.js",
                      "~/Scripts/jquery.magnific-popup.min.js",
                      "~/Scripts/select2.min.js",
                      "~/Scripts/admin.js",
                      "~/Scripts/MyScript.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/OwlCarousel2-2.3.4-css/owl.carousel.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/select2.min.css"
                      //,
                      ));
                      //"~/Content/admin.css",
                      //"~/Content/site.css"));
        }
    }
}
