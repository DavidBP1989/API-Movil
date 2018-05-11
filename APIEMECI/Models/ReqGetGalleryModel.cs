namespace APIEMECI.Models
{
    public class ReqGetGalleryModel
    {
        public string Token { get; set; }
        public string Category { get; set; }
        public int? LastImages { get; set; }
    }
}