using System;
using System.Linq;
using System.Web.Http;
using APIEMECI.Models;
using static System.IO.Directory;
using System.IO;
using static System.Configuration.ConfigurationManager;

namespace APIEMECI.Controllers
{
    public class AuthenticateController : ApiController
    {
        EmeciEntities DbModel = new EmeciEntities();

        [HttpPost]
        public IHttpActionResult LogIn([FromBody]ReqLoginModel Model)
        {
            var Response = new ResLoginModel();
            if (ModelState.IsValid)
            {
                try
                {
                    var _Query = (from p in DbModel.Paciente
                                  join r in DbModel.Registro on p.IdRegistro equals r.idRegistro
                                  where r.Emeci == Model.User &&
                                  r.clave == Model.Password
                                  select new { p.idPaciente, r.FechaExpiracion, r.Nombre, r.Apellido }).FirstOrDefault();
                    if (_Query == null)
                        return NotFound();

                    if (_Query.FechaExpiracion.HasValue && _Query.FechaExpiracion.Value > DateTime.Now.Date)
                    {
                        var _Cood = (from dt in DbModel.DatosTarjeta
                                     where dt.noTarjeta == Model.User &&
                                     dt.Coordenada == Model.Coordinate &&
                                     dt.Dato == Model.Value
                                     select dt.noTarjeta).FirstOrDefault();
                        if (_Cood == null)
                            return NotFound();

                        Response.Token = $"{_Query.idPaciente}/{Guid.NewGuid().ToString().Replace("-", "")}";
                        Response.UserName = _Query.Nombre.Trim();
                        Response.UserLastName = _Query.Apellido.Trim();
                        Response.ImageProfile = GetImageProfile(_Query.idPaciente);
                        Response.Success = true;
                    }
                }
                catch { }
            }

            if (Response.Success)
                return Ok(Response);
            else return NotFound();
        }



        string GetImageProfile(int IdPatient)
        {
            string Img = "https://www.emeci.com/profile.png";
            try
            {
                string Folder = $"{AppSettings["FolderImages"]}\\{IdPatient}\\Perfil";
                if (Exists(Folder))
                {
                    string[] Files = GetFiles(Folder);
                    if (Files.Length > 0)
                    {
                        string ImageName = Path.GetFileName(Files[0]);
                        Img = $"{AppSettings["UrlEmeci"]}{IdPatient}/Perfil/{ImageName}";
                    }
                }
            }
            catch { }
            return Img;
        }
    }
}
