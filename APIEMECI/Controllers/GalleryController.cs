using APIEMECI.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using static System.IO.Directory;
using System.Web.Http;
using static System.Configuration.ConfigurationManager;
using APIEMECI.App_Code;
using System.Drawing;
using System;
using System.Text.RegularExpressions;

namespace APIEMECI.Controllers
{
    public class GalleryController : ApiController
    {

        public IHttpActionResult Get([FromUri]ReqGetGalleryModel Model)
        {
            var Result = new Dictionary<string, List<string>>();
            if (ModelState.IsValid)
            {
                try
                {
                    string IdPatient = Model.Token.Split('/')[0];
                    string FolderImages = $"{AppSettings["FolderImages"]}\\{IdPatient}\\";

                    List<string> Categories = new List<string>
                    {
                        "vacunas",
                        "medicamentos",
                        "recetas",
                        "generales",
                        "laboratorio",
                        "diagnosticos"
                    };

                    if (!string.IsNullOrEmpty(Model.Category))
                    {
                        Categories = new List<string> { Model.Category.ToLower() };
                    }

                    foreach(string Category in Categories)
                    {
                        string Folder = $"{FolderImages}{Category}";
                        if (Exists(Folder))
                        {
                            List<string> Images = new List<string>();

                            string[] Files;
                            if (Model.LastImages.HasValue && Model.LastImages.Value > 0)
                                Files = (string[])GetFiles(Folder).OrderByDescending(x => new FileInfo(x).CreationTime).Take(Model.LastImages.Value);
                            else
                                Files = GetFiles(Folder).OrderByDescending(x => new FileInfo(x).CreationTime).ToArray();

                            foreach (string Img in Files)
                            {
                                if (!((File.GetAttributes(Img) & FileAttributes.Hidden) == FileAttributes.Hidden))
                                {
                                    string FileName = Path.GetFileName(Img);
                                    string Url = $"{AppSettings["UrlEmeci"]}{IdPatient}/{Category}/{FileName}";
                                    Images.Add(Url);
                                }    
                            }

                            Result.Add(Category, Images);
                        }
                        else Result.Add(Category, new List<string>());
                    }
                }
                catch {  }
            }

            if (Result.Count > 0)
                return Ok(new
                {
                    Success = true,
                    Images = Result
                });
            else return NotFound();
        }


        public IHttpActionResult Post([FromBody]ReqAddGalleryModel Model)
        {
            var Result = new ResAddGalleryModel();
            if (ModelState.IsValid)
            {
                try
                {
                    string IdPatient = Model.Token.Split('/')[0];
                    string Root = $"{AppSettings["FolderImages"]}\\{IdPatient}\\";

                    switch (Model.Category)
                    {
                        case "vacunas":
                            Root += "vacunas";
                            break;
                        case "medicamentos":
                            Root += "medicamentos";
                            break;
                        case "recetas":
                            Root += "recetas";
                            break;
                        case "generales":
                            Root += "generales";
                            break;
                        case "laboratorio":
                            Root += "laboratorio";
                            break;
                        case "diagnosticos":
                            Root += "diagnosticos";
                            break;
                    }

                    if (!Exists(Root))
                        CreateDirectory(Root);
                    string Title = $"{CheckFileName(Model.Title)}{Model.Extension}";
                    Root = $"{Root}\\{Title}";

                    Image Img = new Gallery().Base64ToImage(Model.Image);
                    if (Img != null)
                    {
                        try
                        {
                            Img.Save(Root);
                            Result.Url = $"{AppSettings["UrlEmeci"]}{IdPatient}/{Model.Category}/{Title}";
                            Result.Success = true;
                        }
                        catch (Exception ex)
                        {
                            Result.Error = $"Imagen no valida: {ex.Message}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Result.Error = $"Error al guardar la imagen: {ex.Message}";
                }
            }

            return Ok(Result);
        }


        string CheckFileName(string ImageName)
        {
            Regex illegalInFileName =
                        new Regex(string.Format("[{0}]", Regex.Escape(new string(Path.GetInvalidFileNameChars()))), RegexOptions.Compiled);
            return $"{illegalInFileName.Replace(ImageName, "")}";
        }
    }
}
