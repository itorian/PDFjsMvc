using System.Web.Mvc;

namespace MvcApplication25.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //// Local file
            //ViewBag.filePath = "/SamplePDF/sample-pdf.pdf";

            //// Remote file - enable CORS on storage account
            ViewBag.filePath = "https://knorishblobstoragepoc.blob.core.windows.net/test/sample-pdf.pdf";

            return View();
        }
    }
}
