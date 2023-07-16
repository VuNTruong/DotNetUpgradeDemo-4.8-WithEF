using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class PdfUtil
    {
        public void ExportToPDF()
        {
            string line = null;
            int yPoint = 0;
            TextReader readFile = new StreamReader("C:/Projects/Text.txt");

            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();

            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Regular);

            while (true)
            {
                line = readFile.ReadLine();
                if (line == null)
                {
                    break;
                }
                else
                {
                    graph.DrawString(line, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                    yPoint += 40;
                }
            }

            string pdfFileName = "C:/Projects/txttopdf.pdf";
            pdf.Save(pdfFileName);

            readFile.Close();
            readFile = null;
        }
    }
}
