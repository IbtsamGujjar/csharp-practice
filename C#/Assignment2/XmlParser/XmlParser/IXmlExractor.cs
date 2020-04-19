using System;
using System.Threading.Tasks;

namespace XmlParser
{
    interface IXmlExractor
    {
        Task ExtractText(string sourcePath, string destinationPath, string attribute, string attributeValue);
    }
}
