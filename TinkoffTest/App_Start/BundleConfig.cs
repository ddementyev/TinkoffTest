using System.Web.Optimization;

namespace TinkoffTest.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                       "~/Scripts/angular.js"));
        }
    }
}