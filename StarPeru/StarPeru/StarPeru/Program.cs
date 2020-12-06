using System.Collections.Generic;

namespace StarPeru
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler crawler = new Crawler();
            crawler.Start("HUU|LIM|2020|12|06|2021|12|06|E|O");
        }
    }
}
