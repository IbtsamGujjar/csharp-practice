using System;

namespace XmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            IXmlExractor xmlExtractor = new XmlExtractor();
            XmlConsumer xmlConsumer = new XmlConsumer(xmlExtractor);
            xmlConsumer.ExtractText("assets/file.xml", "assets/output.txt", "long-name", "Risk Factors");
        }
    }
}
