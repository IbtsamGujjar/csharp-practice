using System;

namespace XmlParser
{
    class XmlConsumer
    {
        IXmlExractor _xmlExractor;
        public XmlConsumer(IXmlExractor xmlExractor)
        {
            _xmlExractor = xmlExractor;
        }

        public async void ExtractText(string sourcePath, string destinationPath, string attribute, string attributeValue)
        {
            await _xmlExractor.ExtractText(sourcePath, destinationPath, attribute, attributeValue);
        }
    }
}
