using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Qlik.Examples.CommonUserControls
{
    internal class XmlHandler
    {
        public static IEnumerable<KeyValuePair<string, List<string>>> LoadFile(string filePath)
        {
            if(!File.Exists(filePath))
            {
                return null;
            }
            var xdoc = XDocument.Load(filePath);
            var connection = xdoc.Descendants("Connection");
            var users = xdoc.Descendants("UserName");
            var virtualProxies = xdoc.Descendants("VirtualProxy");
            var myNewList = new List<KeyValuePair<string, List<string>>>();
            var xElements = connection as XElement[] ?? connection.ToArray();
            var enumerable = users as XElement[] ?? users.ToArray();
            var virtualProxyEnum = virtualProxies as XElement[] ?? virtualProxies.ToArray();
            var maxUser = enumerable.Count();
            for (int i = 0; i < xElements.Count(); i++)
            {
                var myconnection = xElements[i].Value;
                string myuser;
                if (i < maxUser) myuser = enumerable[i].Value;
                else myuser = string.Empty;
                var virtualProxy = i < virtualProxyEnum.Count() ? virtualProxyEnum[i].Value : string.Empty;
                
                myNewList.Add(new KeyValuePair<string, List<string>>(myconnection, new List<string>() {myuser, virtualProxy}));
            }

            return myNewList;
        }

        public static void WriteToXml(string filePath, List<KeyValuePair<string, List<string>>> myList)
        {
            var writer = new XmlTextWriter(filePath, Encoding.Unicode)
            {
                Formatting = Formatting.Indented,
                //Use indentation for readability.
                Indentation = 4
            };
            //writer.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
            //Write an element (this one is the root element).
            writer.WriteStartElement("ConnectionSettings");

            foreach (var keyValuePair in myList)
            {
                writer.WriteStartElement("Connection");
                writer.WriteString(keyValuePair.Key);
                writer.WriteEndElement();
                writer.WriteStartElement("UserName");
                writer.WriteString(keyValuePair.Value.First());
                writer.WriteEndElement();
                writer.WriteStartElement("VirtualProxy");
                writer.WriteString(keyValuePair.Value.Last());
                writer.WriteEndElement();
            }

            //Write the close tag for the root element.
            writer.WriteEndElement();

            //Write the XML to file and close the writer.
            writer.Close();
        }
    }
}
