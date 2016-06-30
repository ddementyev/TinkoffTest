﻿using System.Web.Optimization;

namespace TinkoffTest.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                       "~/Scripts/angular.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-1.10.2.js"));
            bundles.Add(new ScriptBundle("~/bundles/urls").Include(
                       "~/Scripts/App/UrlsController.js"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                       "~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/site").Include(
                       "~/Content/Css/site.css"));
        }
    }
}