using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace ArquivosPDFUtilizandoItext
{
    class Program
    {
    
            /// <exception cref="System.IO.IOException"/>
            public static void Main(String[] args)
            {
                using(var file =new FileStream("HelloWorld.pdf", FileMode.OpenOrCreate))
                using (var document = new Document(new Rectangle(200, 100)))
                {
                    var writer = PdfWriter.GetInstance(document, file);
                    document.Open();
                    document.Add(new Paragraph("Hello World!"));
                }
              
            }
        }
    }   
