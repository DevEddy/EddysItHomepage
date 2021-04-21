using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace EddysItHomepage.Server.Controllers
{
    public class StaticContentController : Controller
    {
        [HttpGet]
        [Route(".well-known/apple-app-site-association")]
        public ContentResult AppleAppSiteAssociationWellKnown()
        {
            // source in root of wwwroot folder
            const string source = @"apple-app-site-association.json";
            var json = System.IO.File.ReadAllText(source);
            return Content(json, "application/json", Encoding.UTF8);
        }
        [HttpGet]
        [Route("apple-app-site-association")]
        public ContentResult AppleAppSiteAssociation()
        {
            return AppleAppSiteAssociationWellKnown();
        }
    }
}