using System.Xml.Linq;

namespace Linq2XMLDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load xml doc
            XDocument xml = XDocument.Load("XMLFile1.xml");

            // get all books belogns to fantacy 

            var books = from b in xml.Descendants("book")
                        where b.Element("genre").Value == "Fantasy"
                        select b.Element("title").Value;

            // display
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }
    }
}