using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace TestingConsoleApplication
{
    public class XmlFileReader
    {
         static void Main(string[] args)
        {
            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><r><a><k>key1</k><v><![CDATA[<?xml version=\"1.0\" encoding=\"utf-8\"?><foo><bar>Hahaha</bar></foo>]]></v></a><a><k>key2</k><v>value2</v></a></r>";

            PrintDictionary(XmlToDictionaryLinq(xml));
            PrintDictionary(XmlToDictionaryNoLinq(xml));
            string param = "<fieldvaluepairs><fieldvaluepair><field>name</field><value>books</value></fieldvaluepair><fieldvaluepair><field>value</field><value>101 Ways to Love</value></fieldvaluepair><fieldvaluepair><field>type</field><value>System.String</value></fieldvaluepair></fieldvaluepairs>";
            var reader = XmlReader.Create(new StringReader(param));
            var dictionary = new Dictionary<string, string>();
            reader.ReadStartElement();
            while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
            {
                reader.ReadStartElement("fieldvaluepair");
                reader.ReadStartElement("field");
                string key = reader.ReadString();
                reader.ReadEndElement();
                reader.ReadStartElement("value");
                string value = reader.NodeType == XmlNodeType.Element
                    ? reader.ReadOuterXml() : reader.ReadString();
                reader.ReadEndElement();
                dictionary.Add(key, value);
                reader.ReadEndElement();
            }
            reader.ReadEndElement();
            reader.Close();
        }

        private static Dictionary<string, string> XmlToDictionaryNoLinq(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var nodes = doc.SelectNodes("//a");

            var result = new Dictionary<string, string>();
            if (nodes != null)
                foreach (XmlNode node in nodes)
                {
                    if (node != null && !result.ContainsKey(key: node["k"]?.InnerText))
                        result.Add(node["k"]?.InnerText, node["v"].InnerText);
                }

            return result;
        }

        private static Dictionary<string, string> XmlToDictionaryLinq(string xml)
        {
            var doc = XDocument.Parse(xml);
            var result =
                (doc.Descendants("a")
                    .Select(node => new {key = node.Element("k")?.Value, value = node.Element("v").Value}))
                .ToDictionary(e => e.key, e => e.value);
            return result;
        }

        private static void PrintDictionary(Dictionary<string, string> result)
        {
            foreach (var i in result)
            {
                Console.WriteLine("key: {0}, value: {1}", i.Key, i.Value);
            }
        }
        ///<summary>
        /// Steve Lydford - 12/05/2008.
        ///
        /// Encrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        private void EncryptFile(string inputFile, string outputFile)
        {

            try
            {
                string password = @"myKey123"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
               Console.WriteLine("Encryption failed!");
            }
        }
    }
}