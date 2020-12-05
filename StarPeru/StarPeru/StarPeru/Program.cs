using System.Collections.Generic;

namespace StarPeru
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler crawler = new Crawler();
            crawler.Start("HUU|LIM|2020|12|05|2021|12|05|E|O");
        }
    }
}
