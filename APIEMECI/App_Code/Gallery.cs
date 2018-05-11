using System;
using System.Drawing;
using System.IO;

namespace APIEMECI.App_Code
{
    public class Gallery
    {
        public Image Base64ToImage(string Base64String)
        {
            Image Img = null;
            try
            {
                byte[] Buffer = Convert.FromBase64String(Base64String);
                Img = Image.FromStream(new MemoryStream(Buffer, 0, Buffer.Length), true);
            }
            catch
            {
                return null;
            }

            return Img;
        }
    }
}