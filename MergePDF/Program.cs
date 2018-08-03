using System;
using System.IO;
using System.Linq;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace MergePDF
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetFile = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), args[1]));

            var folder = Path.Combine(Directory.GetCurrentDirectory(), args[0]);
            using (var output = new PdfDocument())
            {
                foreach (var file in Directory.GetFiles(folder, "*.pdf").OrderBy(f => f))
                {
                    if (new FileInfo(file).FullName == targetFile.FullName)
                    {
                        continue;
                    }

                    using (PdfDocument pdf = PdfReader.Open(file, PdfDocumentOpenMode.Import))
                    {
                        Console.WriteLine("Merging " + file);
                        CopyPages(pdf, output);
                    }
                }

                output.Save(targetFile.FullName);
            }
        }

        private static void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }
    }
}
