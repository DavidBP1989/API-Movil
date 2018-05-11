using APIEMECI.Models;
using System.Web.Http;
using static System.IO.Directory;
using static System.Configuration.ConfigurationManager;

namespace APIEMECI.Controllers
{
    public class CheckController : ApiController
    {
        public IHttpActionResult Get([FromUri]ReqGetGalleryModel Model)
        {
            int Count = -1;
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(Model.Category))
                    return NotFound();

                string IdPatient = Model.Token.Split('/')[0];
                string Folder = $"{AppSettings["FolderImages"]}\\{IdPatient}\\{Model.Category}";
                if (Exists(Folder))
                {
                    Count = GetFiles(Folder).Length;
                }
            }

            return Ok(new { TotalImages = Count });
        }
    }
}
