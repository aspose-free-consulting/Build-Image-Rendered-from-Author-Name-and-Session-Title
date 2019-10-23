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
        //Create an image from text using Aspose.Slides for .NET 
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ImageGenerate(object sender, EventArgs e)
        {
            try
            { 
                //here we're creating a title slide using Aspose.Slides' SlideLayoutType 
                Presentation pres = new Presentation();
                ISlide slide = pres.Slides.AddEmptySlide(pres.LayoutSlides.GetByType(SlideLayoutType.Title));

                //next, we take some text as input. You can use as much text as appropriate in your case. 
                //Setting title as author
                ((IAutoShape)slide.Shapes[0]).TextFrame.Text = TextBoxAuthor.Text;

                //Setting session as sub-tilte
                ((IAutoShape)slide.Shapes[1]).TextFrame.Text = TextBoxSession.Text;

                //You can also set scaling factor by your choice with Aspose.Slides API
                float ScaleFactor = 1;
                var image =slide.GetThumbnail(ScaleFactor, ScaleFactor);
                
                //the resultant image created from the text is saved to memory stream, but you can save it to disk or storage as well
                MemoryStream mem=SaveAsImage(image);

        
                //the image memory stream is rendered to the user and the user can see the output image 
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
            //Aspose.Slides provide different image formats in which you can save the output image
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
