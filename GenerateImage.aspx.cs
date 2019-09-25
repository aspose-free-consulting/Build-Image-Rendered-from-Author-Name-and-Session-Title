using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Slides;

namespace SlideImageGenerator
{
    public partial class GenerateImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ImageGenerate(object sender, EventArgs e)
        {
            try
            { 
                Presentation pres = new Presentation();
                ISlide slide = pres.Slides.AddEmptySlide(pres.LayoutSlides.GetByType(SlideLayoutType.Title));

                //Setting title as author
                ((IAutoShape)slide.Shapes[0]).TextFrame.Text = TextBoxAuthor.Text;

                //Setting session as sub-tilte
                ((IAutoShape)slide.Shapes[1]).TextFrame.Text = TextBoxSession.Text;

                float ScaleFactor = 1;
                var image =slide.GetThumbnail(ScaleFactor, ScaleFactor);
                MemoryStream mem=SaveAsImage(image);

                Response.Clear();
                Response.ContentType = "Application/png";
                Response.AppendHeader("Content-Disposition", "attachment; filename="+TextBoxAuthor.Text+".png");
                Response.BinaryWrite(mem.ToArray());
                Response.Flush();
                Response.Close();
                Response.End();
            }

            catch (Exception ex)
            {

            }

        }

      
        private static void SaveAsImage(System.Drawing.Bitmap img, string path)
        {
            //save the image in the form of PNG
            img.Save(path, ImageFormat.Png);
        }

        private static MemoryStream SaveAsImage(System.Drawing.Bitmap img)
        {
            MemoryStream mem =new MemoryStream();
            img.Save(mem, ImageFormat.Png);
            mem.Position = 0;
            return mem;
        }

    }
}