using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCMinificationAndBundling.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            StyleBundle styleBundle = new StyleBundle("~/Content/NITStyleBundle");
            styleBundle.Include("~/Content/Header.min.css", "~/Content/Paragraph.min.css");
            bundles.Add(styleBundle);

            // We have to combine these two file that i'm writeing this below line 
            // Debug means Development
            // In this case you see the total 3 requasets 1)Header.min.css 2)Paragraph.min.css 3)Index.cshtml
            // or //
            // We have onther option to do this in Web.config 
            // < compilation debug = "false" targetFramework = "4.8" />
            // Release means Production and run
            // In this case you see the total 2 requasets 1)Index.cshtml 2)NITStyleBundle
            BundleTable.EnableOptimizations = true;

        }
    }
}