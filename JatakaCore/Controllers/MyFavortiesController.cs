using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using JatakaCore.Factory;
using JatakaCore.Models;
using System;
using Grpc.Core;
using System.Drawing;
using DocumentFormat.OpenXml.Drawing;
using Paragraph = iText.Layout.Element.Paragraph;

namespace JatakaCore.Controllers
{
    public class MyFavortiesController : Controller
    {
        // GET: MyFavorties
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PdfResultsView(string all)
        {

            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter("C:\\demo.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("HEADER")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            document.Add(header);
            document.Close();


            //using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            //{
            //    Document document = new Document(PageSize.A4, 10, 10, 10, 10);

            //    PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
            //    document.Open();
            //    Story modelStory = new Story();
            //    DropdownModel model = new DropdownModel();

            //    //Create a single column table
            //    var t = new PdfPTable(1);

            //    //Tell it to fill the page horizontally
            //    t.WidthPercentage = 100;

            //    //Create a single cell
            //    var c = new PdfPCell();

            //    //Tell the cell to vertically align in the middle
            //    c.VerticalAlignment = Element.ALIGN_MIDDLE;

            //    //Tell the cell to fill the page vertically
            //    c.MinimumHeight = document.PageSize.Height - (document.BottomMargin + document.TopMargin);

            //    //Create a test paragraph
            //    //var p = new Paragraph("                    EBook Custom Favorite Recipes from whatscookingtreasures.com");
            //    //Add it a couple of times
            //    //c.AddElement(p);

            //    var imagePath1 = Server.MapPath("~/content/album.jpg");

            //    iTextSharp.text.Image pic1 = iTextSharp.text.Image.GetInstance(imagePath1);
            //    //pic1.BorderWidth = 0;
            //    pic1.BorderColor = Color.WHITE;

            //    c.AddElement(pic1);

            //    //Add the cell to the paragraph
            //    t.AddCell(c);

            //    //Add the table to the document
            //    document.Add(t);
            //    document.NewPage();



            //    string[] rowschosen = all.Split('|');
            //    int length = rowschosen.Length;

            //    for (int i = 0; i < length; i++)
            //    {
            //        var jatakaID = Convert.ToInt16(rowschosen[i]);
            //        GetLookups myGetLookups = new GetLookups();

            //        modelStory = myGetLookups.GetSpecificStory(jatakaID);
            //        var Stories = modelStory.Stories;

            //        Paragraph para = new Paragraph(Stories);
            //        para.Font = FontFactory.GetFont(FontFactory.HELVETICA, 14f);
            //        document.Add(para);
            //        if (i != length - 1)
            //        {
            //            document.NewPage();
            //        }

            //    }



            //    document.Close();
            //    byte[] bytes = memoryStream.ToArray();
            //    memoryStream.Close();
            //    Response.Clear();
            //    Response.ContentType = "application/pdf";

            //    string pdfName = "User";
            //    Response.AddHeader("Content-Disposition", "attachment; filename=" + pdfName + ".pdf");
            //    Response.ContentType = "application/pdf";
            //    Response.Buffer = true;
            //    Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            //    Response.BinaryWrite(bytes);
            //    Response.End();
            //    Response.Close();
            //}



            return View();



        }
    }
}

