using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PDFjsMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RegisterBundles(BundleTable.Bundles);
        }

        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true; // set true on production

            bundles.Add(new StyleBundle("~/pdf.js/css").Include(
                "~/pdf.js/viewer.css"
                ));

            bundles.Add(new ScriptBundle("~/pdf.js/js").Include(
                "~/pdf.js/compatibility.js",
                "~/pdf.js/l10n.js",
                "~/pdf.js/core.js",
                "~/pdf.js/util.js",
                "~/pdf.js/api.js",
                "~/pdf.js/metadata.js",
                "~/pdf.js/canvas.js",
                "~/pdf.js/obj.js",
                "~/pdf.js/function.js",
                "~/pdf.js/charsets.js",
                "~/pdf.js/cidmaps.js",
                "~/pdf.js/colorspace.js",
                "~/pdf.js/crypto.js",
                "~/pdf.js/evaluator.js",
                "~/pdf.js/fonts.js",
                "~/pdf.js/glyphlist.js",
                "~/pdf.js/image.js",
                "~/pdf.js/metrics.js",
                "~/pdf.js/parser.js",
                "~/pdf.js/pattern.js",
                "~/pdf.js/stream.js",
                "~/pdf.js/worker.js",
                "~/pdf.js/jpg.js",
                "~/pdf.js/jpx.js",
                "~/pdf.js/jbig2.js",
                "~/pdf.js/bidi.js"
                ));

            bundles.Add(new ScriptBundle("~/pdf.js/vd").Include(
                "~/pdf.js/viewer.js",
                "~/pdf.js/debugger.js"
                ));
        }
    }
}
