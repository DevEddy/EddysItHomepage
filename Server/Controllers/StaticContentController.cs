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
        [HttpGet]
        [Route(".well-known/assetlinks")]
        public ContentResult AssetLinksWellKnown()
        {
            // source in root of wwwroot folder
            const string source = @"assetlinks.json";
            var json = System.IO.File.ReadAllText(source);
            return Content(json, "application/json", Encoding.UTF8);
        }
        [HttpGet]
        [Route(".well-known/assetlinks.json")]
        public ContentResult AssetLinksWellKnownJson()
        {
            return AssetLinksWellKnown();
        }
        [HttpGet]
        [Route("assetlinks.json")]
        public ContentResult AssetLinksJson()
        {
            return AssetLinksWellKnown();
        }
        [HttpGet]
        [Route("assetlinks")]
        public ContentResult AssetLinks()
        {
            return AssetLinksWellKnown();
        }

        [HttpGet]
        [Route(".well-known/microsoft-identity-association.json")]
        public ContentResult MicrosoftIdentityAssociation()
        {            
            const string source = @"microsoft-identity-association.json";
            var json = System.IO.File.ReadAllText(source);
            return Content(json, "application/json", Encoding.UTF8);
        }
    }
}