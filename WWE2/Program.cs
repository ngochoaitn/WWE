using NCrawler;
using NCrawler.HtmlProcessor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace WWE2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            List<PropertyBag> collectedLinks = new List<PropertyBag>();
            new CrawlerConfiguration()
                .CrawlSeed("https://muaban.net/do-dung-gia-dinh-quan-tan-binh-l5922-c74/chuyen-mua-ban-do-cu-nha-hang-quan-an-quan-nhau-cafe-hcm-id37801792")
                .Do((crawler, bag) =>
                {
                    collectedLinks.Add(bag);
                })
                .MaxCrawlCount(1)
                .Download()
                .HtmlProcessor()
                .AddLoggerStep()
                .Run();

            Application.Run(new Form1());
        }
    }
}
